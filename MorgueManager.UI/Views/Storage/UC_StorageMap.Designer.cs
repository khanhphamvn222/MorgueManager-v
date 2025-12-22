namespace MorgueManager.UI.Views.Storage
{
    partial class UC_StorageMap
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            this.pnlLegend = new Guna.UI2.WinForms.Guna2Panel();

            // Các control cũ
            this.btnRefresh = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2VSeparator2 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2VSeparator1 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.label1 = new System.Windows.Forms.Label();
            this.iconMaintenance = new Guna.UI2.WinForms.Guna2Button();
            this.iconOccupied = new Guna.UI2.WinForms.Guna2Button();
            this.iconFree = new Guna.UI2.WinForms.Guna2Button();

            // --- CÁC CONTROL MỚI CHO TRẠNG THÁI VỆ SINH ---
            this.guna2VSeparator3 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.iconCleaning = new Guna.UI2.WinForms.Guna2Button();
            this.label4 = new System.Windows.Forms.Label();

            this.flowMap = new System.Windows.Forms.FlowLayoutPanel();
            this.toolTipInfo = new Guna.UI2.WinForms.Guna2HtmlToolTip();
            this.pnlLegend.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLegend
            // 
            this.pnlLegend.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.pnlLegend.BorderRadius = 10;
            this.pnlLegend.BorderThickness = 1;

            // Thêm các control mới vào Panel
            this.pnlLegend.Controls.Add(this.label4);          // Label Chờ vệ sinh
            this.pnlLegend.Controls.Add(this.iconCleaning);    // Icon Tím
            this.pnlLegend.Controls.Add(this.guna2VSeparator3);// Gạch dọc phân cách
            this.pnlLegend.Controls.Add(this.label3);
            this.pnlLegend.Controls.Add(this.guna2VSeparator2);
            this.pnlLegend.Controls.Add(this.label2);
            this.pnlLegend.Controls.Add(this.guna2VSeparator1);
            this.pnlLegend.Controls.Add(this.label1);
            this.pnlLegend.Controls.Add(this.iconMaintenance);
            this.pnlLegend.Controls.Add(this.iconOccupied);
            this.pnlLegend.Controls.Add(this.iconFree);
            this.pnlLegend.Controls.Add(this.btnRefresh);
            this.pnlLegend.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLegend.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.pnlLegend.Location = new System.Drawing.Point(20, 20);
            this.pnlLegend.Name = "pnlLegend";
            this.pnlLegend.Size = new System.Drawing.Size(980, 60);
            this.pnlLegend.TabIndex = 0;
            // 
            // label3 (Bảo trì)
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(368, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Đang bảo trì (Cam)";
            // 
            // guna2VSeparator2
            // 
            this.guna2VSeparator2.FillColor = System.Drawing.Color.Gray;
            this.guna2VSeparator2.Location = new System.Drawing.Point(321, 15);
            this.guna2VSeparator2.Name = "guna2VSeparator2";
            this.guna2VSeparator2.Size = new System.Drawing.Size(10, 30);
            this.guna2VSeparator2.TabIndex = 7;
            // 
            // label2 (Có người)
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(208, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Có người (Đỏ)";
            // 
            // guna2VSeparator1
            // 
            this.guna2VSeparator1.FillColor = System.Drawing.Color.Gray;
            this.guna2VSeparator1.Location = new System.Drawing.Point(157, 15);
            this.guna2VSeparator1.Name = "guna2VSeparator1";
            this.guna2VSeparator1.Size = new System.Drawing.Size(10, 30);
            this.guna2VSeparator1.TabIndex = 5;
            // 
            // label1 (Trống)
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(54, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Còn trống (Xanh)";
            // 
            // iconMaintenance (Cam)
            // 
            this.iconMaintenance.BorderRadius = 5;
            this.iconMaintenance.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.iconMaintenance.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.iconMaintenance.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.iconMaintenance.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.iconMaintenance.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(158)))), ((int)(((byte)(11)))));
            this.iconMaintenance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.iconMaintenance.ForeColor = System.Drawing.Color.White;
            this.iconMaintenance.Location = new System.Drawing.Point(341, 19);
            this.iconMaintenance.Name = "iconMaintenance";
            this.iconMaintenance.Size = new System.Drawing.Size(20, 20);
            this.iconMaintenance.TabIndex = 3;
            // 
            // iconOccupied (Đỏ)
            // 
            this.iconOccupied.BorderRadius = 5;
            this.iconOccupied.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.iconOccupied.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.iconOccupied.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.iconOccupied.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.iconOccupied.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.iconOccupied.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.iconOccupied.ForeColor = System.Drawing.Color.White;
            this.iconOccupied.Location = new System.Drawing.Point(182, 19);
            this.iconOccupied.Name = "iconOccupied";
            this.iconOccupied.Size = new System.Drawing.Size(20, 20);
            this.iconOccupied.TabIndex = 2;
            // 
            // iconFree (Xanh)
            // 
            this.iconFree.BorderRadius = 5;
            this.iconFree.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.iconFree.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.iconFree.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.iconFree.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.iconFree.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.iconFree.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.iconFree.ForeColor = System.Drawing.Color.White;
            this.iconFree.Location = new System.Drawing.Point(28, 19);
            this.iconFree.Name = "iconFree";
            this.iconFree.Size = new System.Drawing.Size(20, 20);
            this.iconFree.TabIndex = 1;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.BorderRadius = 8;
            this.btnRefresh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRefresh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRefresh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRefresh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRefresh.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(70)))), ((int)(((byte)(229)))));
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(866, 12);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(100, 36);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "Làm mới";
            // 
            // --- CÁC CONTROL MỚI ---
            // 
            // guna2VSeparator3
            // 
            this.guna2VSeparator3.FillColor = System.Drawing.Color.Gray;
            this.guna2VSeparator3.Location = new System.Drawing.Point(490, 15);
            this.guna2VSeparator3.Name = "guna2VSeparator3";
            this.guna2VSeparator3.Size = new System.Drawing.Size(10, 30);
            this.guna2VSeparator3.TabIndex = 9;
            // 
            // iconCleaning (Tím)
            // 
            this.iconCleaning.BorderRadius = 5;
            this.iconCleaning.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.iconCleaning.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.iconCleaning.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.iconCleaning.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.iconCleaning.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(51)))), ((int)(((byte)(234))))); // Purple
            this.iconCleaning.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.iconCleaning.ForeColor = System.Drawing.Color.White;
            this.iconCleaning.Location = new System.Drawing.Point(510, 19);
            this.iconCleaning.Name = "iconCleaning";
            this.iconCleaning.Size = new System.Drawing.Size(20, 20);
            this.iconCleaning.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(536, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Chờ vệ sinh (Tím)";
            // 
            // flowMap
            // 
            this.flowMap.AutoScroll = true;
            this.flowMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowMap.Location = new System.Drawing.Point(20, 80);
            this.flowMap.Name = "flowMap";
            this.flowMap.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.flowMap.Size = new System.Drawing.Size(980, 620);
            this.flowMap.TabIndex = 1;
            // 
            // toolTipInfo
            // 
            this.toolTipInfo.AllowLinksHandling = true;
            this.toolTipInfo.MaximumSize = new System.Drawing.Size(0, 0);
            // 
            // UC_StorageMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(6)))), ((int)(((byte)(23)))));
            this.Controls.Add(this.flowMap);
            this.Controls.Add(this.pnlLegend);
            this.Name = "UC_StorageMap";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Size = new System.Drawing.Size(1020, 720);
            this.pnlLegend.ResumeLayout(false);
            this.pnlLegend.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlLegend;
        private Guna.UI2.WinForms.Guna2Button btnRefresh;
        private System.Windows.Forms.FlowLayoutPanel flowMap;
        private Guna.UI2.WinForms.Guna2Button iconFree;
        private Guna.UI2.WinForms.Guna2Button iconMaintenance;
        private Guna.UI2.WinForms.Guna2Button iconOccupied;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator2;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2HtmlToolTip toolTipInfo;

        // Mới thêm
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator3;
        private Guna.UI2.WinForms.Guna2Button iconCleaning;
        private System.Windows.Forms.Label label4;
    }
}