using Guna.UI2.WinForms;
using MorgueManager.Core.DTOs;
using MorgueManager.Core.Enums;
using System;
using System.Windows.Forms;

namespace MorgueManager.UI.Views.Admin
{
    public partial class AddUserDialog : Form
    {
        // Property để Form cha (UC_Admin) lấy dữ liệu sau khi đóng Dialog
        public CreateUserRequest UserRequest { get; private set; } = null!;

        public AddUserDialog()
        {
            // Gọi hàm khởi tạo từ Designer
            InitializeComponent();

            // Gán sự kiện cho các nút bấm
            btnSave.Click += BtnSave_Click;
            btnCancel.Click += (s, e) => this.Close();

            // Mặc định chọn Staff (Index 1) để an toàn
            cboRole.StartIndex = 1;
        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            // 1. Validate dữ liệu đầu vào
            if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Tên đăng nhập và Họ tên!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Map dữ liệu từ UI sang DTO
            UserRequest = new CreateUserRequest
            {
                Username = txtUsername.Text.Trim(),
                FullName = txtFullName.Text.Trim(),
                // Index 0: Admin, Index 1: Staff (Theo thứ tự trong Designer)
                Role = cboRole.SelectedIndex == 0 ? UserRole.Admin : UserRole.Staff
            };

            // 3. Trả về kết quả OK và đóng form
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}