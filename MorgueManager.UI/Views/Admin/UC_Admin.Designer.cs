namespace MorgueManager.UI.Views.Admin
{
    partial class UC_Admin
    {
        private System.ComponentModel.IContainer components = null;
        private Guna.UI2.WinForms.Guna2TabControl tabAdmin;
        private System.Windows.Forms.TabPage tabUsers;
        private System.Windows.Forms.TabPage tabCleanup;
        private System.Windows.Forms.TabPage tabConfig; // Tab Mới

        // User Controls
        private Guna.UI2.WinForms.Guna2DataGridView gridUsers;
        private Guna.UI2.WinForms.Guna2Button btnAddUser;

        // Cleanup Controls
        private Guna.UI2.WinForms.Guna2Button btnCleanup;
        private System.Windows.Forms.Label lblDanger;

        // Config Controls
        private Guna.UI2.WinForms.Guna2Panel pnlConfigContainer;
        private Guna.UI2.WinForms.Guna2TextBox txtOrgName;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2NumericUpDown numPrice;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btnSaveConfig;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();

            this.tabAdmin = new Guna.UI2.WinForms.Guna2TabControl();
            this.tabUsers = new System.Windows.Forms.TabPage();
            this.gridUsers = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnAddUser = new Guna.UI2.WinForms.Guna2Button();
            this.tabCleanup = new System.Windows.Forms.TabPage();
            this.btnCleanup = new Guna.UI2.WinForms.Guna2Button();
            this.lblDanger = new System.Windows.Forms.Label();

            // Init Config
            this.tabConfig = new System.Windows.Forms.TabPage();
            this.pnlConfigContainer = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOrgName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numPrice = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.btnSaveConfig = new Guna.UI2.WinForms.Guna2Button();

            this.tabAdmin.SuspendLayout();
            this.tabUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridUsers)).BeginInit();
            this.tabCleanup.SuspendLayout();
            this.tabConfig.SuspendLayout();
            this.pnlConfigContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).BeginInit();
            this.SuspendLayout();

            // 
            // tabAdmin
            // 
            this.tabAdmin.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabAdmin.Controls.Add(this.tabUsers);
            this.tabAdmin.Controls.Add(this.tabConfig); // Thêm tab Config
            this.tabAdmin.Controls.Add(this.tabCleanup);
            this.tabAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabAdmin.ItemSize = new System.Drawing.Size(180, 40);
            this.tabAdmin.Location = new System.Drawing.Point(0, 0);
            this.tabAdmin.Name = "tabAdmin";
            this.tabAdmin.SelectedIndex = 0;
            this.tabAdmin.Size = new System.Drawing.Size(1210, 704);
            this.tabAdmin.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.tabAdmin.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tabAdmin.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tabAdmin.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.tabAdmin.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(70)))), ((int)(((byte)(229)))));
            this.tabAdmin.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.tabAdmin.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tabAdmin.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tabAdmin.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.tabAdmin.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tabAdmin.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.tabAdmin.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.tabAdmin.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.tabAdmin.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.tabAdmin.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(70)))), ((int)(((byte)(229)))));
            this.tabAdmin.TabButtonSize = new System.Drawing.Size(180, 40);
            this.tabAdmin.TabIndex = 0;
            this.tabAdmin.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            // 
            // tabUsers
            // 
            this.tabUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.tabUsers.Controls.Add(this.gridUsers);
            this.tabUsers.Controls.Add(this.btnAddUser);
            this.tabUsers.Location = new System.Drawing.Point(184, 4);
            this.tabUsers.Name = "tabUsers";
            this.tabUsers.Padding = new System.Windows.Forms.Padding(20);
            this.tabUsers.Size = new System.Drawing.Size(1022, 696);
            this.tabUsers.TabIndex = 0;
            this.tabUsers.Text = "Danh sách Người dùng";
            // 
            // gridUsers (Giữ nguyên cấu hình cũ)
            // 
            this.gridUsers.AllowUserToAddRows = false;
            this.gridUsers.AllowUserToDeleteRows = false;
            this.gridUsers.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.gridUsers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridUsers.ColumnHeadersHeight = 40;
            this.gridUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridUsers.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridUsers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridUsers.Location = new System.Drawing.Point(20, 70);
            this.gridUsers.Name = "gridUsers";
            this.gridUsers.ReadOnly = true;
            this.gridUsers.RowHeadersVisible = false;
            this.gridUsers.RowTemplate.Height = 40;
            this.gridUsers.Size = new System.Drawing.Size(980, 600);
            this.gridUsers.TabIndex = 0;
            this.gridUsers.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gridUsers.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gridUsers.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gridUsers.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gridUsers.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gridUsers.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gridUsers.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridUsers.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gridUsers.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridUsers.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gridUsers.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gridUsers.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gridUsers.ThemeStyle.HeaderStyle.Height = 40;
            this.gridUsers.ThemeStyle.ReadOnly = true;
            this.gridUsers.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gridUsers.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridUsers.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gridUsers.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gridUsers.ThemeStyle.RowsStyle.Height = 40;
            this.gridUsers.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridUsers.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // btnAddUser
            // 
            this.btnAddUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddUser.BorderRadius = 5;
            this.btnAddUser.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(70)))), ((int)(((byte)(229)))));
            this.btnAddUser.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAddUser.ForeColor = System.Drawing.Color.White;
            this.btnAddUser.Location = new System.Drawing.Point(830, 20);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(170, 40);
            this.btnAddUser.TabIndex = 1;
            this.btnAddUser.Text = "+ Tạo nhân viên mới";
            // 
            // tabConfig (Cấu hình)
            // 
            this.tabConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.tabConfig.Controls.Add(this.pnlConfigContainer);
            this.tabConfig.Location = new System.Drawing.Point(184, 4);
            this.tabConfig.Name = "tabConfig";
            this.tabConfig.Size = new System.Drawing.Size(1022, 696);
            this.tabConfig.TabIndex = 2;
            this.tabConfig.Text = "Cấu hình Giá";
            // 
            // pnlConfigContainer
            // 
            this.pnlConfigContainer.BackColor = System.Drawing.Color.Transparent;
            this.pnlConfigContainer.BorderRadius = 10;
            this.pnlConfigContainer.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.pnlConfigContainer.Controls.Add(this.label1);
            this.pnlConfigContainer.Controls.Add(this.txtOrgName);
            this.pnlConfigContainer.Controls.Add(this.label2);
            this.pnlConfigContainer.Controls.Add(this.numPrice);
            this.pnlConfigContainer.Controls.Add(this.btnSaveConfig);
            this.pnlConfigContainer.Location = new System.Drawing.Point(50, 50);
            this.pnlConfigContainer.Name = "pnlConfigContainer";
            this.pnlConfigContainer.Size = new System.Drawing.Size(600, 350);
            this.pnlConfigContainer.ShadowDecoration.Enabled = true;
            this.pnlConfigContainer.ShadowDecoration.Depth = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.label1.Location = new System.Drawing.Point(30, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 19);
            this.label1.Text = "Tên đơn vị";
            // 
            // txtOrgName
            // 
            this.txtOrgName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.txtOrgName.BorderRadius = 5;
            this.txtOrgName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.txtOrgName.ForeColor = System.Drawing.Color.White;
            this.txtOrgName.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtOrgName.Location = new System.Drawing.Point(30, 65);
            this.txtOrgName.Name = "txtOrgName";
            this.txtOrgName.Size = new System.Drawing.Size(540, 45);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.label2.Location = new System.Drawing.Point(30, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 19);
            this.label2.Text = "Đơn giá lưu trữ (VNĐ)";
            // 
            // numPrice
            // 
            this.numPrice.BackColor = System.Drawing.Color.Transparent;
            this.numPrice.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.numPrice.BorderRadius = 5;
            this.numPrice.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.numPrice.ForeColor = System.Drawing.Color.White;
            this.numPrice.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.numPrice.Location = new System.Drawing.Point(30, 155);
            this.numPrice.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            this.numPrice.Name = "numPrice";
            this.numPrice.Size = new System.Drawing.Size(540, 45);
            this.numPrice.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.numPrice.UpDownButtonForeColor = System.Drawing.Color.White;
            // 
            // btnSaveConfig
            // 
            this.btnSaveConfig.BorderRadius = 5;
            this.btnSaveConfig.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(70)))), ((int)(((byte)(229)))));
            this.btnSaveConfig.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSaveConfig.ForeColor = System.Drawing.Color.White;
            this.btnSaveConfig.Location = new System.Drawing.Point(30, 240);
            this.btnSaveConfig.Name = "btnSaveConfig";
            this.btnSaveConfig.Size = new System.Drawing.Size(160, 45);
            this.btnSaveConfig.Text = "Lưu cấu hình";
            // 
            // tabCleanup
            // 
            this.tabCleanup.BackColor = System.Drawing.Color.White;
            this.tabCleanup.Controls.Add(this.btnCleanup);
            this.tabCleanup.Controls.Add(this.lblDanger);
            this.tabCleanup.Location = new System.Drawing.Point(184, 4);
            this.tabCleanup.Name = "tabCleanup";
            this.tabCleanup.Size = new System.Drawing.Size(1022, 696);
            this.tabCleanup.TabIndex = 1;
            this.tabCleanup.Text = "Dọn dẹp & Hệ thống";
            // 
            // btnCleanup
            // 
            this.btnCleanup.BorderRadius = 5;
            this.btnCleanup.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnCleanup.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnCleanup.ForeColor = System.Drawing.Color.White;
            this.btnCleanup.Location = new System.Drawing.Point(50, 100);
            this.btnCleanup.Name = "btnCleanup";
            this.btnCleanup.Size = new System.Drawing.Size(300, 60);
            this.btnCleanup.TabIndex = 0;
            this.btnCleanup.Text = "🗑 XÓA DỮ LIỆU CŨ (>1 NĂM)";
            // 
            // lblDanger
            // 
            this.lblDanger.AutoSize = true;
            this.lblDanger.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblDanger.ForeColor = System.Drawing.Color.Red;
            this.lblDanger.Location = new System.Drawing.Point(50, 50);
            this.lblDanger.Name = "lblDanger";
            this.lblDanger.Size = new System.Drawing.Size(513, 25);
            this.lblDanger.TabIndex = 1;
            this.lblDanger.Text = "VÙNG NGUY HIỂM: Hành động này không thể hoàn tác!";
            // 
            // UC_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.tabAdmin);
            this.Name = "UC_Admin";
            this.Size = new System.Drawing.Size(1210, 704);
            this.tabAdmin.ResumeLayout(false);
            this.tabUsers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridUsers)).EndInit();
            this.tabCleanup.ResumeLayout(false);
            this.tabCleanup.PerformLayout();
            this.tabConfig.ResumeLayout(false);
            this.pnlConfigContainer.ResumeLayout(false);
            this.pnlConfigContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).EndInit();
            this.ResumeLayout(false);
        }
    }
}