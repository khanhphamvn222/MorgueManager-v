using Guna.UI2.WinForms;
using Microsoft.Extensions.DependencyInjection;
using MorgueManager.Core.DTOs;
using MorgueManager.Core.Enums;
using MorgueManager.Core.Interfaces.Services;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;

namespace MorgueManager.UI.Views.Corpse
{
    public partial class CorpseDetailsDialog : Form
    {
        private readonly ICorpseService _corpseService = null!;
        private readonly IPdfService _pdfService = null!;
        private int _currentCorpseId;
        private CorpseDetailDto? _currentData;

        // Panel vẽ Timeline (được tạo bằng code)
        private Guna2Panel pnlTimeline = null!;

        public CorpseDetailsDialog()
        {
            InitializeComponent();
        }

        // Constructor DI
        [ActivatorUtilitiesConstructor]
        public CorpseDetailsDialog(ICorpseService corpseService, IPdfService pdfService)
        {
            InitializeComponent();
            _corpseService = corpseService;
            _pdfService = pdfService;

            // 1. Khởi tạo giao diện Timeline
            SetupTimelineUI();

            // 2. Gán sự kiện
            btnClose.Click += (s, e) => this.Close();
            btnHandover.Click += async (s, e) => await HandleHandoverAsync();
            btnPrint.Click += BtnPrint_Click;
        }

        // --- HÀM TẠO TIMELINE DYNAMIC ---
        private void SetupTimelineUI()
        {
            // Tạo Panel chứa Timeline
            pnlTimeline = new Guna2Panel
            {
                // Đặt vị trí Y=400 (Dưới label Giá tiền, trên các nút bấm)
                Location = new Point(0, 400),
                Size = new Size(500, 120),
                BackColor = Color.Transparent
            };

            // Thêm trực tiếp vào pnlRight (Biến này đã có trong Designer.cs)
            this.pnlRight.Controls.Add(pnlTimeline);

            // Gán sự kiện vẽ
            pnlTimeline.Paint += PnlTimeline_Paint;
        }

        // Logic vẽ đồ họa cho Timeline
        private void PnlTimeline_Paint(object? sender, PaintEventArgs e)
        {
            if (_currentData == null) return;

            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            // Tọa độ vẽ
            int startX = 50;
            int y = 50;
            int stepX = 150; // Khoảng cách giữa các điểm

            // Màu sắc
            Color activeColor = Color.FromArgb(16, 185, 129); // Xanh lá (Đã hoàn thành)
            Color inactiveColor = Color.Gray;                   // Xám (Chưa đến)

            // Xác định trạng thái các mốc
            bool isReceived = true;
            bool isInStorage = true;
            bool isHandover = _currentData.Status.Contains("bàn giao", StringComparison.OrdinalIgnoreCase);

            var milestones = new[]
            {
                ("Tiếp nhận", _currentData.ReceptionTime, isReceived),
                ("Lưu kho", _currentData.ReceptionTime.AddMinutes(30), isInStorage),
                ("Bàn giao", DateTime.Now, isHandover) // Nếu chưa bàn giao, thời gian này chỉ là placeholder
            };

            using (Pen penGray = new Pen(inactiveColor, 2))
            using (Pen penActive = new Pen(activeColor, 2))
            using (Brush brushActive = new SolidBrush(activeColor))
            using (Brush brushGray = new SolidBrush(inactiveColor))
            using (Font fontTitle = new Font("Segoe UI", 9, FontStyle.Bold))
            using (Font fontDate = new Font("Segoe UI", 8))
            {
                for (int i = 0; i < milestones.Length; i++)
                {
                    int x = startX + (i * stepX);
                    bool isActive = milestones[i].Item3;

                    // 1. Vẽ đường nối (Line) đến điểm tiếp theo
                    if (i < milestones.Length - 1)
                    {
                        // Đường nối chỉ active khi điểm tiếp theo cũng active
                        var nextActive = milestones[i + 1].Item3;
                        g.DrawLine(nextActive ? penActive : penGray, x, y, x + stepX, y);
                    }

                    // 2. Vẽ điểm tròn (Dot)
                    int dotSize = 12;
                    g.FillEllipse(isActive ? brushActive : brushGray, x - (dotSize / 2), y - (dotSize / 2), dotSize, dotSize);

                    // 3. Vẽ Tiêu đề (Trên điểm tròn)
                    g.DrawString(milestones[i].Item1, fontTitle, isActive ? Brushes.White : Brushes.Gray, x - 25, y - 25);

                    // 4. Vẽ Ngày tháng (Dưới điểm tròn)
                    if (isActive)
                    {
                        string dateText = milestones[i].Item2.ToString("dd/MM HH:mm");

                        // Nếu là mốc Bàn giao nhưng chưa bàn giao thì hiện placeholder
                        if (i == 2 && !isHandover) dateText = "--/--";

                        g.DrawString(dateText, fontDate, Brushes.Gray, x - 35, y + 10);
                    }
                }
            }
        }

        // --- HÀM LOAD DỮ LIỆU ---
        public async void LoadData(int corpseId)
        {
            _currentCorpseId = corpseId;
            await LoadDetailsAsync();
        }

        private async System.Threading.Tasks.Task LoadDetailsAsync()
        {
            try
            {
                var result = await _corpseService.GetCorpseDetailAsync(_currentCorpseId);
                if (!result.Success || result.Data == null)
                {
                    MessageBox.Show("Không tải được dữ liệu: " + result.Message);
                    this.Close();
                    return;
                }

                _currentData = result.Data;

                // Bind Data to Labels
                lblName.Text = _currentData.FullName.ToUpper();
                lblGender.Text = _currentData.Gender;
                lblIdentity.Text = _currentData.IdentityNumber;
                lblTime.Text = _currentData.ReceptionTime.ToString("HH:mm dd/MM/yyyy");
                lblStorage.Text = _currentData.StorageLocation;
                lblDays.Text = $"{_currentData.DaysInStorage} ngày";
                lblTotalCost.Text = string.Format("{0:N0} VNĐ", _currentData.TotalCost);

                // Status Badge Color
                lblStatus.Text = _currentData.Status;
                if (_currentData.Status.Contains("bàn giao", StringComparison.OrdinalIgnoreCase))
                {
                    lblStatus.FillColor = Color.Gray;
                    btnHandover.Enabled = false;
                    btnHandover.Text = "ĐÃ HOÀN TẤT";
                }
                else
                {
                    lblStatus.FillColor = Color.FromArgb(16, 185, 129); // Green
                    btnHandover.Enabled = true;
                    btnHandover.Text = "BÀN GIAO THI THỂ";
                }

                // Load Image
                if (!string.IsNullOrEmpty(_currentData.ImagePath))
                {
                    string fullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, _currentData.ImagePath);
                    if (File.Exists(fullPath))
                    {
                        picAvatar.Image = Image.FromFile(fullPath);
                    }
                    else picAvatar.Image = null;
                }
                else picAvatar.Image = null;

                // Trigger vẽ lại Timeline
                pnlTimeline?.Invalidate();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hiển thị: " + ex.Message);
            }
        }

        // --- HÀM IN ẤN ---
        private void BtnPrint_Click(object? sender, EventArgs e)
        {
            if (_currentData == null) return;

            try
            {
                var pdfBytes = _pdfService.GenerateHandoverRecord(_currentData);

                using (SaveFileDialog sfd = new SaveFileDialog())
                {
                    sfd.Filter = "PDF Files|*.pdf";
                    sfd.FileName = $"BienBan_{_currentData.FullName}_{DateTime.Now:yyyyMMdd}.pdf";

                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        File.WriteAllBytes(sfd.FileName, pdfBytes);

                        // Mở file PDF ngay sau khi lưu
                        try
                        {
                            var p = new Process();
                            p.StartInfo = new ProcessStartInfo(sfd.FileName) { UseShellExecute = true };
                            p.Start();
                        }
                        catch { MessageBox.Show("Đã lưu file thành công!"); }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi in ấn: " + ex.Message);
            }
        }

        // --- HÀM BÀN GIAO ---
        private async System.Threading.Tasks.Task HandleHandoverAsync()
        {
            var confirm = MessageBox.Show(
                $"Xác nhận bàn giao thi thể và thu phí {lblTotalCost.Text}?\n\nHành động này sẽ giải phóng ngăn lạnh và chuyển trạng thái hồ sơ.",
                "Xác nhận bàn giao",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes) return;

            btnHandover.Enabled = false;
            btnHandover.Text = "Đang xử lý...";

            var result = await _corpseService.HandoverCorpseAsync(_currentCorpseId);

            if (result.Success)
            {
                MessageBox.Show(result.Message, "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK; // Báo OK để form cha refresh list
                this.Close();
            }
            else
            {
                MessageBox.Show(result.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnHandover.Enabled = true;
                btnHandover.Text = "BÀN GIAO THI THỂ";
            }
        }
    }
}