using System;
using System.Drawing;
using System.Windows.Forms;

namespace MorgueManager.UI.Views.Admin
{
    public partial class PasswordResultDialog : Form
    {
        private string _password;

        public PasswordResultDialog(string title, string username, string password)
        {
            InitializeComponent();
            _password = password;

            // Gán dữ liệu vào UI Designer
            lblTitle.Text = title.ToUpper();
            lblUsername.Text = $"Tài khoản: {username}";
            lblPassword.Text = password; // Control này phải có trong Designer

            // Sự kiện
            btnCopy.Click += BtnCopy_Click;

            // Timer từ Designer (timerResetIcon)
            timerResetIcon.Tick += (s, e) =>
            {
                btnCopy.Text = "📋";
                btnCopy.FillColor = Color.Transparent;
                timerResetIcon.Stop();
            };
        }

        private void BtnCopy_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_password)) return;

            Clipboard.SetText(_password);

            // Visual Feedback
            btnCopy.Text = "✔";
            btnCopy.FillColor = Color.FromArgb(16, 185, 129); // Green Background

            timerResetIcon.Start();
        }
    }
}