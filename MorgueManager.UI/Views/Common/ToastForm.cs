using Guna.UI2.WinForms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MorgueManager.UI.Views.Common
{
    // FIX: Thêm từ khóa 'partial' để khớp với file Designer
    public partial class ToastForm : Form
    {
        private System.Windows.Forms.Timer _timer;
        private int _displayTime = 0;

        public ToastForm(string message, bool isSuccess)
        {
            InitializeComponent(); // Gọi Designer

            // Setup UI logic
            this.FormBorderStyle = FormBorderStyle.None;
            this.Size = new Size(300, 60);
            this.StartPosition = FormStartPosition.Manual;
            this.ShowInTaskbar = false;
            this.TopMost = true;

            Color baseColor = isSuccess ? Color.FromArgb(6, 95, 70) : Color.FromArgb(153, 27, 27);
            this.BackColor = baseColor;

            // Update Labels (Các control này đã có trong Designer, ta chỉ gán text/màu)
            lblIcon.Text = isSuccess ? "✔" : "⚠";
            lblMsg.Text = message;

            // Timer Logic
            _timer = timerClose; // Sử dụng timer từ Designer
            _timer.Interval = 100;
            _timer.Tick += (s, e) =>
            {
                _displayTime += 100;
                if (_displayTime >= 3000)
                {
                    this.Opacity -= 0.1;
                    if (this.Opacity <= 0) this.Close();
                }
            };
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            var screen = Screen.PrimaryScreen?.WorkingArea ?? Screen.AllScreens[0].WorkingArea;
            this.Location = new Point(screen.Right - this.Width - 20, screen.Top + 20);
            _timer.Start();
        }

        public static void Show(string msg, bool success = true)
        {
            new ToastForm(msg, success).Show();
        }
    }
}