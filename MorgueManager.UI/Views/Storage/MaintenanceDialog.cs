using Guna.UI2.WinForms;
using System;
using System.Windows.Forms;

namespace MorgueManager.UI.Views.Storage
{
    public partial class MaintenanceDialog : Form
    {
        // Property để lưu lý do nhập vào, Form cha sẽ đọc giá trị này
        public string Reason { get; private set; } = string.Empty;

        public MaintenanceDialog()
        {
            // Hàm này sẽ gọi code trong file Designer.cs để vẽ giao diện
            InitializeComponent();

            // Gán sự kiện cho các nút
            btnConfirm.Click += BtnConfirm_Click;
            btnCancel.Click += (s, e) => this.Close();
        }

        private void BtnConfirm_Click(object? sender, EventArgs e)
        {
            // Validate đầu vào
            if (string.IsNullOrWhiteSpace(txtReason.Text))
            {
                MessageBox.Show("Vui lòng nhập lý do!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lưu lý do và đóng form
            Reason = txtReason.Text.Trim();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}