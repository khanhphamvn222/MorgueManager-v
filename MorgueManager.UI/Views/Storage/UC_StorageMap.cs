using Guna.UI2.WinForms;
using Microsoft.Extensions.DependencyInjection;
using MorgueManager.Core.DTOs;
using MorgueManager.Core.Enums;
using MorgueManager.Core.Interfaces.Services;
using MorgueManager.UI.Views.Corpse;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace MorgueManager.UI.Views.Storage
{
    public partial class UC_StorageMap : UserControl
    {
        private readonly IStorageService _storageService = null!;
        private readonly ICorpseService _corpseService = null!;

        public UC_StorageMap() { InitializeComponent(); }

        [ActivatorUtilitiesConstructor]
        public UC_StorageMap(IStorageService storageService, ICorpseService corpseService)
        {
            InitializeComponent();
            _storageService = storageService;
            _corpseService = corpseService;

            this.Load += async (s, e) => await LoadMapAsync();
            btnRefresh.Click += async (s, e) => await LoadMapAsync();
        }

        private async System.Threading.Tasks.Task LoadMapAsync()
        {
            try
            {
                var result = await _storageService.GetStorageMapAsync();
                if (result.Success && result.Data != null) RenderMap(result.Data);
            }
            catch (Exception ex) { MessageBox.Show("Lỗi tải sơ đồ: " + ex.Message); }
        }

        private void RenderMap(List<StorageMapDto> data)
        {
            flowMap.Controls.Clear();
            foreach (var item in data)
            {
                flowMap.Controls.Add(CreateStorageCard(item));
            }
        }

        private Guna2Button CreateStorageCard(StorageMapDto item)
        {
            Color color;
            string statusText = "";

            switch (item.State)
            {
                case StorageState.Occupied:
                    color = Color.FromArgb(239, 68, 68); // Red
                    statusText = "Có người";
                    break;
                case StorageState.Maintenance:
                    color = Color.FromArgb(245, 158, 11); // Orange
                    statusText = "Bảo trì";
                    break;
                case StorageState.PendingCleaning: // --- MÀU TÍM CHO CHỜ VỆ SINH ---
                    color = Color.FromArgb(147, 51, 234); // Purple
                    statusText = "Chờ VS";
                    break;
                default:
                    color = Color.FromArgb(16, 185, 129); // Green
                    statusText = "Trống";
                    break;
            }

            var btn = new Guna2Button
            {
                Width = 120,
                Height = 120,
                BorderRadius = 15,
                FillColor = color,
                Text = $"{item.LocationCode}\n\n{statusText}",
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                ForeColor = Color.White,
                Margin = new Padding(10),
                Cursor = Cursors.Hand
            };

            if (item.State == StorageState.Occupied)
            {
                string info = $"<b>NGĂN {item.LocationCode}</b><br/>Họ tên: {item.OccupantName}<br/>Giới tính: {item.Gender}<br/>Tiếp nhận: {item.ReceptionDate}";
                toolTipInfo.SetToolTip(btn, info);
            }

            // Events
            btn.MouseDown += (s, e) =>
            {
                if (e.Button == MouseButtons.Right) ShowContextMenu(btn, item, e.Location);
            };

            btn.DoubleClick += async (s, e) =>
            {
                if (item.State == StorageState.Occupied) await OpenCorpseDetails(item.LocationCode);
            };

            return btn;
        }

        private async System.Threading.Tasks.Task OpenCorpseDetails(string locationCode)
        {
            var result = await _corpseService.GetAllCorpsesAsync(locationCode);
            if (result.Success && result.Data != null && result.Data.Count > 0)
            {
                var corpseId = result.Data.First().Id;
                using (var scope = UI.Program.ServiceProvider.CreateScope())
                {
                    var form = scope.ServiceProvider.GetRequiredService<CorpseDetailsDialog>();
                    form.LoadData(corpseId);
                    if (form.ShowDialog() == DialogResult.OK) await LoadMapAsync();
                }
            }
        }

        private void ShowContextMenu(Control control, StorageMapDto item, Point position)
        {
            var menu = new ContextMenuStrip();

            if (item.State == StorageState.Available)
            {
                menu.Items.Add("⚠️ Báo hỏng / Bảo trì", null, async (s, e) => await HandleMaintenance(item));
            }
            else if (item.State == StorageState.Maintenance)
            {
                menu.Items.Add("✅ Hoàn tất bảo trì", null, async (s, e) => await HandleMaintenance(item));
            }
            // --- MENU MỚI: XÁC NHẬN VỆ SINH ---
            else if (item.State == StorageState.PendingCleaning)
            {
                menu.Items.Add("✨ Xác nhận ĐÃ KHỬ KHUẨN", null, async (s, e) =>
                {
                    if (MessageBox.Show("Xác nhận đã vệ sinh và khử khuẩn ngăn này?", "Quy trình Y tế", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        var res = await _storageService.ConfirmCleaningAsync(item.Id);
                        if (res.Success) await LoadMapAsync();
                        else MessageBox.Show(res.Message);
                    }
                });
            }
            else
            {
                menu.Items.Add("⛔ Không thể thao tác (Đang có người)");
            }

            menu.Show(control, position);
        }

        private async System.Threading.Tasks.Task HandleMaintenance(StorageMapDto item)
        {
            string reason = "Bảo trì định kỳ";
            if (item.State == StorageState.Available)
            {
                var dialog = new MaintenanceDialog();
                if (dialog.ShowDialog() != DialogResult.OK) return;
                reason = dialog.Reason;
            }

            var result = await _storageService.ToggleMaintenanceAsync(item.Id, reason);
            if (result.Success) await LoadMapAsync();
            else MessageBox.Show(result.Message);
        }
    }
}