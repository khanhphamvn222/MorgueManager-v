using Guna.UI2.WinForms;
using Microsoft.Extensions.DependencyInjection;
using MorgueManager.Core.DTOs;
using MorgueManager.Core.Enums;
using MorgueManager.Core.Interfaces.Services;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace MorgueManager.UI.Views.Corpse
{
    public partial class AddCorpseDialog : Form
    {
        private readonly ICorpseService _corpseService = null!;
        private readonly IStorageService _storageService = null!;
        private string? _selectedImagePath = null;

        public AddCorpseDialog()
        {
            InitializeComponent();
        }

        [ActivatorUtilitiesConstructor]
        public AddCorpseDialog(ICorpseService corpseService, IStorageService storageService)
        {
            InitializeComponent();
            _corpseService = corpseService;
            _storageService = storageService;

            this.Load += async (s, e) => await LoadStoragesAsync();
            btnSave.Click += async (s, e) => await SaveDataAsync();
            btnCancel.Click += (s, e) => this.Close();
            btnUpload.Click += BtnUpload_Click;

            dtpReception.Value = DateTime.Now;
        }

        private async System.Threading.Tasks.Task LoadStoragesAsync()
        {
            var result = await _storageService.GetAvailableStoragesAsync();
            if (result.Success && result.Data != null)
            {
                cboStorage.DataSource = result.Data;
                cboStorage.DisplayMember = "LocationCode";
                cboStorage.ValueMember = "Id";
                cboStorage.SelectedIndex = -1;
            }
        }

        private void BtnUpload_Click(object? sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    picAvatar.Image = Image.FromFile(ofd.FileName);
                    string uploadsFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Uploads", "Corpses");
                    if (!Directory.Exists(uploadsFolder)) Directory.CreateDirectory(uploadsFolder);

                    string fileName = $"{Guid.NewGuid()}{Path.GetExtension(ofd.FileName)}";
                    string destPath = Path.Combine(uploadsFolder, fileName);
                    File.Copy(ofd.FileName, destPath, true);
                    _selectedImagePath = Path.Combine("Uploads", "Corpses", fileName);
                }
            }
        }

        private async System.Threading.Tasks.Task SaveDataAsync()
        {
            if (string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                MessageBox.Show("Vui lòng nhập Họ và Tên!");
                return;
            }

            btnSave.Enabled = false;
            btnSave.Text = "Đang lưu...";

            try
            {
                var request = new CreateCorpseRequest
                {
                    FullName = txtFullName.Text.Trim(),
                    IdentityNumber = txtIdentity.Text.Trim(),
                    Gender = cboGender.SelectedIndex == 0 ? Gender.Male : (cboGender.SelectedIndex == 1 ? Gender.Female : Gender.Unknown),
                    ReceptionTime = dtpReception.Value,
                    Notes = txtNotes.Text,
                    ImagePath = _selectedImagePath,
                    StorageId = cboStorage.SelectedValue != null ? (int)cboStorage.SelectedValue : null,

                    // --- MỚI: THÊM THÔNG TIN THÂN NHÂN (Nếu bạn đã vẽ TextBox tương ứng trong Designer) ---
                    // RelativeName = txtRelativeName.Text,
                    // RelativePhone = txtPhone.Text,
                    // PersonalBelongings = txtBelongings.Text 
                };

                var result = await _corpseService.CreateCorpseAsync(request);

                if (result.Success)
                {
                    MessageBox.Show(result.Message, "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show(result.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
            }
            finally
            {
                btnSave.Enabled = true;
                btnSave.Text = "LƯU HỒ SƠ";
            }
        }
    }
}