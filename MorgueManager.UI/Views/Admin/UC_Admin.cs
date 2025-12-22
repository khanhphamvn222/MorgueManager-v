using Microsoft.Extensions.DependencyInjection;
using MorgueManager.Core.DTOs;
using MorgueManager.Core.Enums;
using MorgueManager.Core.Interfaces.Services;
using MorgueManager.UI.Views.Common;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MorgueManager.UI.Views.Admin
{
    public partial class UC_Admin : UserControl
    {
        private readonly IAdminService _adminService = null!;

        public UC_Admin()
        {
            InitializeComponent();
        }

        [ActivatorUtilitiesConstructor]
        public UC_Admin(IAdminService adminService)
        {
            InitializeComponent();
            _adminService = adminService;

            SetupGridColumns();

            this.Load += async (s, e) =>
            {
                await LoadUsersAsync();
                await LoadSettingsAsync();
            };

            btnAddUser.Click += async (s, e) => await HandleCreateUser();
            btnCleanup.Click += async (s, e) => await HandleCleanup();
            btnSaveConfig.Click += async (s, e) => await HandleSaveConfig();

            gridUsers.CellPainting += GridUsers_CellPainting;
            gridUsers.CellMouseClick += GridUsers_CellMouseClick;
        }

        private void SetupGridColumns()
        {
            gridUsers.AutoGenerateColumns = false;
            gridUsers.RowTemplate.Height = 50;

            gridUsers.Columns.Clear();
            gridUsers.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "ID", DataPropertyName = "Id", Width = 50 });
            gridUsers.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Tên đăng nhập", DataPropertyName = "Username", Width = 150 });
            gridUsers.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Họ tên", DataPropertyName = "FullName", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });
            gridUsers.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Vai trò", DataPropertyName = "Role", Width = 120 });

            gridUsers.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Trạng thái", Name = "colStatus", Width = 120 });
            gridUsers.Columns.Add(new DataGridViewButtonColumn { HeaderText = "Hành động", Name = "colActions", Width = 150 });
        }

        private async System.Threading.Tasks.Task LoadUsersAsync()
        {
            try
            {
                var result = await _adminService.GetAllUsersAsync();
                if (result.Success) gridUsers.DataSource = result.Data;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
            }
        }

        private void GridUsers_CellPainting(object? sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var user = (UserListDto)gridUsers.Rows[e.RowIndex].DataBoundItem;

            // 1. Vẽ Badge Trạng Thái
            if (gridUsers.Columns[e.ColumnIndex].Name == "colStatus")
            {
                e.PaintBackground(e.CellBounds, true);

                if (e.Graphics == null) return;

                bool isActive = user.IsActive;
                string statusText = isActive ? "Active" : "Locked";
                Color bgColor = isActive ? Color.FromArgb(209, 250, 229) : Color.FromArgb(254, 226, 226);
                Color textColor = isActive ? Color.FromArgb(6, 95, 70) : Color.FromArgb(153, 27, 27);
                Color borderColor = isActive ? Color.FromArgb(52, 211, 153) : Color.FromArgb(248, 113, 113);

                // Căn giữa Badge
                var rect = new Rectangle(e.CellBounds.X + (e.CellBounds.Width - 80) / 2, e.CellBounds.Y + 12, 80, 26);

                using (var brush = new SolidBrush(bgColor))
                using (var pen = new Pen(borderColor))
                using (var textBrush = new SolidBrush(textColor))
                {
                    e.Graphics.FillRectangle(brush, rect);
                    e.Graphics.DrawRectangle(pen, rect);

                    var sf = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };
                    e.Graphics.DrawString(statusText, new Font("Segoe UI", 9, FontStyle.Bold), textBrush, rect, sf);
                }
                e.Handled = true;
            }

            // 2. Vẽ Action Icons
            if (gridUsers.Columns[e.ColumnIndex].Name == "colActions")
            {
                e.PaintBackground(e.CellBounds, true);

                if (e.Graphics == null) return;

                // Tính toán vị trí căn giữa 2 icon
                int cellW = e.CellBounds.Width;
                int iconW = 30;
                int space = 10;
                int startX = e.CellBounds.X + (cellW - (iconW * 2 + space)) / 2;
                int startY = e.CellBounds.Y + 10;

                var rectReset = new Rectangle(startX, startY, iconW, iconW);
                var rectLock = new Rectangle(startX + iconW + space, startY, iconW, iconW);

                // Vẽ icon Chìa khóa (Key)
                using (var font = new Font("Segoe UI Emoji", 14))
                {
                    TextRenderer.DrawText(e.Graphics, "🔑", font, rectReset, Color.Black, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);

                    // Vẽ icon Ổ khóa (Lock/Unlock) - SỬA LẠI CHỖ NÀY DÙNG EMOJI
                    string lockIcon = user.IsActive ? "🔒" : "🔓"; // 🔒 (Khóa nếu đang Active để bấm vào khóa), 🔓 (Mở nếu đang Locked)
                    // Hoặc logic ngược lại: Hiện trạng thái hiện tại. Ở đây ta hiện hành động có thể làm (Active -> Hiện Lock để bấm khóa)
                    // Logic chuẩn: 
                    // - User đang Active (Xanh) -> Nút bấm là Lock (🔒) để khóa.
                    // - User đang Locked (Đỏ) -> Nút bấm là Unlock (🔓) để mở.
                    lockIcon = user.IsActive ? "🔒" : "🔓";

                    TextRenderer.DrawText(e.Graphics, lockIcon, font, rectLock, Color.Black, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
                }

                e.Handled = true;
            }
        }

        private async void GridUsers_CellMouseClick(object? sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var user = (UserListDto)gridUsers.Rows[e.RowIndex].DataBoundItem;

            if (gridUsers.Columns[e.ColumnIndex].Name == "colActions")
            {
                // Tính toán lại vùng click (phải khớp với CellPainting)
                int cellW = gridUsers.Columns[e.ColumnIndex].Width;
                int iconW = 30;
                int space = 10;
                int startX = (cellW - (iconW * 2 + space)) / 2;

                // Click vào Icon Reset (Bên trái)
                if (e.X >= startX && e.X <= startX + iconW)
                {
                    if (MessageBox.Show($"Đặt lại mật khẩu cho {user.Username}?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        var result = await _adminService.ResetPasswordAsync(user.Id);
                        if (result.Success)
                        {
                            ToastForm.Show("Reset mật khẩu thành công!");
                            new PasswordResultDialog("ĐẶT LẠI MẬT KHẨU", user.Username, result.Data!).ShowDialog();
                        }
                    }
                }
                // Click vào Icon Lock (Bên phải)
                else if (e.X >= startX + iconW + space && e.X <= startX + iconW + space + iconW)
                {
                    await _adminService.ToggleUserStatusAsync(user.Id);
                    await LoadUsersAsync();
                    ToastForm.Show(user.IsActive ? "Đã mở khóa tài khoản" : "Đã khóa tài khoản", true);
                }
            }
        }

        private async System.Threading.Tasks.Task HandleCreateUser()
        {
            var dialog = new AddUserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var result = await _adminService.CreateUserAsync(dialog.UserRequest);
                if (result.Success)
                {
                    ToastForm.Show("Tạo người dùng thành công!");
                    new PasswordResultDialog("CẤP MỚI TÀI KHOẢN", dialog.UserRequest.Username, result.Data!).ShowDialog();
                    await LoadUsersAsync();
                }
                else
                {
                    ToastForm.Show(result.Message, false);
                }
            }
        }

        private async System.Threading.Tasks.Task HandleCleanup()
        {
            if (MessageBox.Show("CẢNH BÁO: Dữ liệu đã xóa sẽ không thể khôi phục. Tiếp tục?", "VÙNG NGUY HIỂM", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {
                var result = await _adminService.CleanupOldDataAsync();
                if (result.Success) ToastForm.Show(result.Message);
            }
        }

        // --- CẤU HÌNH ---
        private async System.Threading.Tasks.Task LoadSettingsAsync()
        {
            var result = await _adminService.GetSystemSettingsAsync();
            if (result.Success && result.Data != null)
            {
                txtOrgName.Text = result.Data.OrganizationName;
                numPrice.Value = result.Data.PricePerDay;
            }
        }

        private async System.Threading.Tasks.Task HandleSaveConfig()
        {
            if (numPrice.Value < 0)
            {
                ToastForm.Show("Giá tiền không hợp lệ!", false);
                return;
            }

            var settings = new SystemSettingsDto
            {
                OrganizationName = txtOrgName.Text.Trim(),
                PricePerDay = numPrice.Value
            };

            var result = await _adminService.UpdateSystemSettingsAsync(settings);

            if (result.Success)
            {
                ToastForm.Show("Đã lưu cấu hình hệ thống!");
            }
            else
            {
                MessageBox.Show(result.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}