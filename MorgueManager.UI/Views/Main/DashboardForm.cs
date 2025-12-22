using Guna.UI2.WinForms;
using Microsoft.Extensions.DependencyInjection;
using MorgueManager.UI.Views.Admin; // <--- QUAN TRỌNG: Thêm namespace này
using MorgueManager.UI.Views.Auth;
using MorgueManager.UI.Views.Corpse;
using MorgueManager.UI.Views.Overview;
using MorgueManager.UI.Views.Storage;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MorgueManager.UI.Views.Main
{
    public partial class DashboardForm : Form
    {
        // FIX: Thêm "= null!;" để trình biên dịch hiểu rằng biến này sẽ được khởi tạo sau, tránh lỗi CS8618
        private readonly IServiceProvider _serviceProvider = null!;
        private Guna2Button _currentActiveButton = null!;

        public DashboardForm(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;

            SetupNavigation();

            // Mặc định load trang Dashboard
            LoadView<UC_Dashboard>("TỔNG QUAN HỆ THỐNG");
            SetButtonActive(btnOverview);
        }

        // Constructor mặc định cho Designer
        public DashboardForm()
        {
            InitializeComponent();
        }

        private void SetupNavigation()
        {
            // Gán sự kiện Click cho các nút menu
            btnOverview.Click += (s, e) => { LoadView<UC_Dashboard>("TỔNG QUAN HỆ THỐNG"); SetButtonActive(btnOverview); };
            btnCorpse.Click += (s, e) => { LoadView<UC_CorpseList>("QUẢN LÝ THI THỂ"); SetButtonActive(btnCorpse); };
            btnStorage.Click += (s, e) => { LoadView<UC_StorageMap>("SƠ ĐỒ KHO LẠNH"); SetButtonActive(btnStorage); };

            // --- CẬP NHẬT DÒNG NÀY: Mở màn hình Admin ---
            btnAdmin.Click += (s, e) => { LoadView<UC_Admin>("QUẢN TRỊ HỆ THỐNG"); SetButtonActive(btnAdmin); };

            // Logout
            btnLogout.Click += (s, e) => PerformLogout();
        }

        private void SetButtonActive(Guna2Button btn)
        {
            if (btn == null) return;

            if (_currentActiveButton != null)
            {
                _currentActiveButton.Checked = false;
            }

            _currentActiveButton = btn;
            _currentActiveButton.Checked = true;
        }

        // Hàm này yêu cầu T phải là UserControl. 
        public void LoadView<T>(string title) where T : UserControl
        {
            lblPageTitle.Text = title;
            pnlContent.Controls.Clear();

            try
            {
                // Lấy UserControl từ DI Container
                var view = _serviceProvider.GetRequiredService<T>();
                view.Dock = DockStyle.Fill;
                pnlContent.Controls.Add(view);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Không thể tải màn hình: {ex.Message}\n(Kiểm tra xem đã đăng ký trong Program.cs chưa?)");
            }
        }

        private void PerformLogout()
        {
            var confirm = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                this.Hide();
                var loginForm = _serviceProvider.GetRequiredService<LoginSplitForm>();
                loginForm.Show();
                this.Close();
            }
        }
        
        public static bool IsPrivacyMode = false;

        
        private Guna2ToggleSwitch tglPrivacy = null!;

        
        private void SetupPrivacyToggle()
        {
            tglPrivacy = new Guna2ToggleSwitch();
            tglPrivacy.Location = new Point(pnlHeader.Width - 150, 25);
            tglPrivacy.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            tglPrivacy.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            tglPrivacy.CheckedState.InnerBorderColor = Color.White;
            tglPrivacy.CheckedState.InnerColor = Color.White;

            // Label đi kèm
            Label lblPrivacy = new Label { Text = "Riêng tư", Location = new Point(pnlHeader.Width - 210, 28), AutoSize = true, ForeColor = Color.Gray };

            tglPrivacy.CheckedChanged += (s, e) =>
            {
                IsPrivacyMode = tglPrivacy.Checked;
                // Refresh lại View hiện tại để áp dụng
                if (pnlContent.Controls.Count > 0 && pnlContent.Controls[0] is UserControl uc)
                {
                    // Gọi hàm RefreshData nếu UC đó có hỗ trợ (Cần Interface chung hoặc Cast kiểu)
                    // Ở đây đơn giản là reload lại view đang mở
                    // LoadView... (Logic reload)
                }
            };

            pnlHeader.Controls.Add(tglPrivacy);
            pnlHeader.Controls.Add(lblPrivacy);
        }

        // --- HÀM BACKDROP (Làm tối nền khi mở Dialog) ---
        public static void ShowDialogWithBackdrop(Form parent, Form dialog)
        {
            Form modalBackground = new Form();
            using (modalBackground)
            {
                modalBackground.StartPosition = FormStartPosition.Manual;
                modalBackground.FormBorderStyle = FormBorderStyle.None;
                modalBackground.Opacity = 0.50d; // Độ mờ 50%
                modalBackground.BackColor = Color.Black;
                modalBackground.Size = parent.Size;
                modalBackground.Location = parent.Location;
                modalBackground.ShowInTaskbar = false;
                modalBackground.Show(parent);

                dialog.Owner = modalBackground;
                dialog.ShowDialog();
            }
        }
    }
}