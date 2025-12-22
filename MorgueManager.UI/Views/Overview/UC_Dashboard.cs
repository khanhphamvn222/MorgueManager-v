using Guna.UI2.WinForms;
using Microsoft.Extensions.DependencyInjection;
using MorgueManager.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MorgueManager.UI.Views.Overview
{
    public partial class UC_Dashboard : UserControl
    {
        private readonly IDashboardService _dashboardService = null!;
        private System.Windows.Forms.Timer _refreshTimer = null!;

        public UC_Dashboard()
        {
            InitializeComponent();
        }

        [ActivatorUtilitiesConstructor]
        public UC_Dashboard(IDashboardService dashboardService)
        {
            InitializeComponent();
            _dashboardService = dashboardService;

            // 1. Thay thế Chart bằng thông báo placeholder (đã bỏ thư viện Chart)
            ShowChartPlaceholder();

            LoadDummyNotifications();

            // 2. Setup Timer refresh 60s
            if (this.components == null) this.components = new System.ComponentModel.Container();

            _refreshTimer = new System.Windows.Forms.Timer(this.components);
            _refreshTimer.Interval = 60000;
            _refreshTimer.Tick += async (s, e) => await LoadDataAsync();
            _refreshTimer.Start();

            // 3. Load dữ liệu lần đầu
            this.Load += async (s, e) => await LoadDataAsync();
        }

        private void ShowChartPlaceholder()
        {
            Label lblMsg = new Label();
            lblMsg.Text = "Biểu đồ thống kê\n(Đã tắt tính năng Chart)";
            lblMsg.Dock = DockStyle.Fill;
            lblMsg.TextAlign = ContentAlignment.MiddleCenter;
            lblMsg.ForeColor = Color.Gray;
            lblMsg.Font = new Font("Segoe UI", 12, FontStyle.Italic);

            // Thêm vào Panel container có sẵn trong Designer
            pnlChartContainer.Controls.Clear();
            pnlChartContainer.Controls.Add(lblMsg);
        }

        private async System.Threading.Tasks.Task LoadDataAsync()
        {
            try
            {
                var result = await _dashboardService.GetDashboardDataAsync();

                if (result.Success && result.Data != null)
                {
                    var data = result.Data;

                    // --- Cập nhật số liệu KPI ---

                    // 1. Tổng hồ sơ
                    lblKpi1Value.Text = data.TotalCorpsesInMorgue.ToString("N0");

                    // 2. Sức chứa
                    int totalSlots = data.AvailableSlots + data.OccupiedSlots + data.MaintenanceSlots;
                    lblKpi2Value.Text = $"{data.OccupiedSlots}/{totalSlots}";

                    // 3. Chờ bàn giao (tạm lấy số đang lưu kho)
                    lblKpi3Value.Text = data.OccupiedSlots.ToString("00");

                    // 4. CẬP NHẬT GIÁ LƯU TRỮ (MỚI)
                    // Lấy từ DB config thông qua Service
                    lblKpi4Value.Text = string.Format("{0:N0}₫", data.CurrentStoragePrice);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Dashboard Load Error: {ex.Message}");
            }
        }

        private void LoadDummyNotifications()
        {
            flowNotiList.Controls.Clear();
            AddNotificationItem("Hệ thống", "Đã sao lưu dữ liệu thành công lúc 02:00 AM", DateTime.Now);
            AddNotificationItem("Cảnh báo", "Ngăn lạnh A-05 sắp hết hạn lưu trữ", DateTime.Now.AddHours(-2));
            AddNotificationItem("Tiếp nhận", "Đã tiếp nhận thi thể mới: Nguyễn Văn A", DateTime.Now.AddHours(-5));
            AddNotificationItem("Admin", "Hệ thống bảo trì định kỳ hoàn tất", DateTime.Now.AddDays(-1));
        }

        private void AddNotificationItem(string title, string content, DateTime time)
        {
            var pnlItem = new Guna2Panel
            {
                Width = flowNotiList.Width - 25,
                Height = 70,
                BorderColor = Color.FromArgb(51, 65, 85),
                BorderThickness = 1,
                BorderRadius = 8,
                FillColor = Color.FromArgb(30, 41, 59),
                Margin = new Padding(0, 0, 0, 10)
            };

            var lblTitle = new Label
            {
                Text = title,
                ForeColor = Color.FromArgb(129, 140, 248),
                Font = new Font("Segoe UI", 9, FontStyle.Bold),
                Location = new Point(10, 10),
                AutoSize = true
            };

            var lblTime = new Label
            {
                Text = time.ToString("HH:mm dd/MM"),
                ForeColor = Color.Gray,
                Font = new Font("Segoe UI", 8),
                Location = new Point(pnlItem.Width - 90, 10),
                AutoSize = true
            };

            var lblContent = new Label
            {
                Text = content,
                ForeColor = Color.WhiteSmoke,
                Font = new Font("Segoe UI", 9),
                Location = new Point(10, 35),
                AutoSize = true,
                MaximumSize = new Size(pnlItem.Width - 20, 0)
            };

            pnlItem.Controls.Add(lblTitle);
            pnlItem.Controls.Add(lblTime);
            pnlItem.Controls.Add(lblContent);

            flowNotiList.Controls.Add(pnlItem);
        }
    }
}