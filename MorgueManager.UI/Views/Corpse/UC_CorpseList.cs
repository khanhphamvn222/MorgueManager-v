using Microsoft.Extensions.DependencyInjection;
using MorgueManager.Core.Interfaces.Services;
using System;
using System.Windows.Forms;
using MorgueManager.UI;

namespace MorgueManager.UI.Views.Corpse
{
    public partial class UC_CorpseList : UserControl
    {
        private readonly ICorpseService _corpseService = null!;

        public UC_CorpseList() { InitializeComponent(); }

        [ActivatorUtilitiesConstructor]
        public UC_CorpseList(ICorpseService corpseService)
        {
            InitializeComponent();
            _corpseService = corpseService;

            SetupGridColumns();

            this.Load += async (s, e) => await LoadDataAsync();
            txtSearch.TextChanged += async (s, e) => await LoadDataAsync(txtSearch.Text);

            btnAddNew.Click += (s, e) =>
            {
                using (var scope = Program.ServiceProvider.CreateScope())
                {
                    var dialog = scope.ServiceProvider.GetRequiredService<AddCorpseDialog>();
                    if (dialog.ShowDialog() == DialogResult.OK) _ = LoadDataAsync();
                }
            };

            // Sự kiện Grid
            dgvCorpses.CellDoubleClick += (s, e) =>
            {
                if (e.RowIndex >= 0) OpenDetails(GetIdFromRow(e.RowIndex));
            };

            dgvCorpses.CellContentClick += async (s, e) =>
            {
                // Xử lý nút Xóa (Cột cuối cùng)
                if (e.RowIndex >= 0 && dgvCorpses.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
                {
                    await DeleteCorpse(GetIdFromRow(e.RowIndex));
                }
            };
        }

        private int GetIdFromRow(int rowIndex)
        {
            if (rowIndex < 0 || rowIndex >= dgvCorpses.Rows.Count) return 0;
            var val = dgvCorpses.Rows[rowIndex].Cells[0].Value;
            if (val == null) return 0;
            return int.TryParse(val.ToString(), out int id) ? id : 0;
        }

        private void SetupGridColumns()
        {
            dgvCorpses.AutoGenerateColumns = false;
            dgvCorpses.Columns.Clear();

            // Thông tin
            dgvCorpses.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "Mã HS", Width = 60 });
            dgvCorpses.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "FullName", HeaderText = "Họ và Tên", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });
            dgvCorpses.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Gender", HeaderText = "Giới tính", Width = 80 });
            dgvCorpses.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "IdentityNumber", HeaderText = "CCCD", Width = 120 });
            dgvCorpses.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "StorageLocation", HeaderText = "Vị trí", Width = 80 });
            dgvCorpses.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Status", HeaderText = "Trạng thái", Width = 120 });
            dgvCorpses.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "ReceptionTime", HeaderText = "Ngày nhận", Width = 150, DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM HH:mm" } });

            // Nút Xóa
            var btnDelete = new DataGridViewButtonColumn
            {
                HeaderText = "Xóa",
                Text = "🗑",
                UseColumnTextForButtonValue = true,
                Width = 50,
                FlatStyle = FlatStyle.Flat
            };
            dgvCorpses.Columns.Add(btnDelete);
        }

        private async System.Threading.Tasks.Task LoadDataAsync(string? keyword = null)
        {
            try
            {
                var result = await _corpseService.GetAllCorpsesAsync(keyword);
                if (result.Success) dgvCorpses.DataSource = result.Data;
            }
            catch (Exception ex) { MessageBox.Show($"Lỗi tải dữ liệu: {ex.Message}"); }
        }

        private async System.Threading.Tasks.Task DeleteCorpse(int id)
        {
            if (id == 0) return;
            if (MessageBox.Show("Bạn chắc chắn muốn xóa hồ sơ này? (Kho sẽ được giải phóng nếu đang lưu)", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    var res = await _corpseService.DeleteCorpseAsync(id);
                    if (res.Success)
                    {
                        MessageBox.Show("Đã xóa thành công.");
                        await LoadDataAsync();
                    }
                    else MessageBox.Show(res.Message);
                }
                catch (Exception ex) { MessageBox.Show($"Lỗi khi xóa: {ex.Message}"); }
            }
        }

        private void OpenDetails(int corpseId)
        {
            if (corpseId == 0) return;
            using (var scope = Program.ServiceProvider.CreateScope())
            {
                var detailForm = scope.ServiceProvider.GetRequiredService<CorpseDetailsDialog>();
                detailForm.LoadData(corpseId);
                if (detailForm.ShowDialog() == DialogResult.OK) _ = LoadDataAsync();
            }
        }
    }
}