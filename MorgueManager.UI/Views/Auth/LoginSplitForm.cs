using Guna.UI2.WinForms;
using Microsoft.Extensions.DependencyInjection;
using MorgueManager.Core.DTOs;
using MorgueManager.Core.Interfaces.Services;
using MorgueManager.UI.Views.Main; // Import namespace Dashboard
using System;
using System.Windows.Forms;

namespace MorgueManager.UI.Views.Auth
{
    public partial class LoginSplitForm : Form
    {
        private readonly IAuthService _authService = null!;
        private readonly IServiceProvider _serviceProvider = null!;

        // Constructor bắt buộc cho DI
        public LoginSplitForm(IAuthService authService, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _authService = authService;
            _serviceProvider = serviceProvider;

            // Setup sự kiện
            btnLogin.Click += BtnLogin_Click;
            txtPassword.KeyDown += (s, e) => { if (e.KeyCode == Keys.Enter) BtnLogin_Click(s, e); };
        }

        // Constructor mặc định (để Designer không lỗi)
        public LoginSplitForm()
        {
            InitializeComponent();
        }

        private async void BtnLogin_Click(object? sender, EventArgs e)
        {
            // 1. Validate sơ bộ
            if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                btnLogin.Enabled = false;
                btnLogin.Text = "Đang xử lý...";

                // 2. Gọi Service
                var request = new LoginRequest
                {
                    Username = txtUsername.Text.Trim(),
                    Password = txtPassword.Text.Trim()
                };

                var result = await _authService.LoginAsync(request);

                if (result.Success)
                {
                    this.Hide();

                    // 3. Mở DashboardForm thay vì Form1
                    var mainForm = _serviceProvider.GetRequiredService<DashboardForm>();
                    mainForm.FormClosed += (s, args) => this.Close(); // Đóng Login khi Main đóng
                    mainForm.Show();
                }
                else
                {
                    MessageBox.Show(result.Message, "Đăng nhập thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi hệ thống: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnLogin.Enabled = true;
                btnLogin.Text = "ĐĂNG NHẬP";
            }
        }
    }
}