namespace MorgueManager.UI.Views.Admin
{
    partial class PasswordResultDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlBorder = new Guna.UI2.WinForms.Guna2Panel();
            this.btnSuccessIcon = new Guna.UI2.WinForms.Guna2Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.pnlPasswordBox = new Guna.UI2.WinForms.Guna2Panel();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnCopy = new Guna.UI2.WinForms.Guna2Button();
            this.lblWarning = new System.Windows.Forms.Label();
            this.btnClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.timerResetIcon = new System.Windows.Forms.Timer(this.components);
            this.pnlBorder.SuspendLayout();
            this.pnlPasswordBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBorder
            // 
            this.pnlBorder.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.pnlBorder.BorderThickness = 2;
            this.pnlBorder.Controls.Add(this.btnSuccessIcon);
            this.pnlBorder.Controls.Add(this.lblTitle);
            this.pnlBorder.Controls.Add(this.lblUsername);
            this.pnlBorder.Controls.Add(this.pnlPasswordBox);
            this.pnlBorder.Controls.Add(this.lblWarning);
            this.pnlBorder.Controls.Add(this.btnClose);
            this.pnlBorder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBorder.Location = new System.Drawing.Point(0, 0);
            this.pnlBorder.Name = "pnlBorder";
            this.pnlBorder.Size = new System.Drawing.Size(450, 280);
            this.pnlBorder.TabIndex = 0;
            // 
            // btnSuccessIcon
            // 
            this.btnSuccessIcon.BorderRadius = 25;
            this.btnSuccessIcon.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSuccessIcon.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSuccessIcon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSuccessIcon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSuccessIcon.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.btnSuccessIcon.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnSuccessIcon.ForeColor = System.Drawing.Color.White;
            this.btnSuccessIcon.Location = new System.Drawing.Point(200, 20);
            this.btnSuccessIcon.Name = "btnSuccessIcon";
            this.btnSuccessIcon.Size = new System.Drawing.Size(50, 50);
            this.btnSuccessIcon.TabIndex = 0;
            this.btnSuccessIcon.Text = "✔";
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 80);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(450, 30);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "THÀNH CÔNG";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUsername
            // 
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblUsername.ForeColor = System.Drawing.Color.Gray;
            this.lblUsername.Location = new System.Drawing.Point(0, 110);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(450, 20);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "Tài khoản: admin";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlPasswordBox
            // 
            this.pnlPasswordBox.BackColor = System.Drawing.Color.Transparent;
            this.pnlPasswordBox.BorderRadius = 10;
            this.pnlPasswordBox.Controls.Add(this.lblPassword);
            this.pnlPasswordBox.Controls.Add(this.btnCopy);
            this.pnlPasswordBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.pnlPasswordBox.Location = new System.Drawing.Point(50, 140);
            this.pnlPasswordBox.Name = "pnlPasswordBox";
            this.pnlPasswordBox.Size = new System.Drawing.Size(350, 60);
            this.pnlPasswordBox.TabIndex = 3;
            // 
            // lblPassword
            // 
            this.lblPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPassword.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold);
            this.lblPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(211)))), ((int)(((byte)(153)))));
            this.lblPassword.Location = new System.Drawing.Point(0, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(290, 60);
            this.lblPassword.TabIndex = 0;
            this.lblPassword.Text = "Pass1234";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCopy
            // 
            this.btnCopy.BorderRadius = 8;
            this.btnCopy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCopy.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCopy.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCopy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCopy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCopy.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCopy.FillColor = System.Drawing.Color.Transparent;
            this.btnCopy.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnCopy.ForeColor = System.Drawing.Color.White;
            this.btnCopy.Location = new System.Drawing.Point(290, 0);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(60, 60);
            this.btnCopy.TabIndex = 1;
            this.btnCopy.Text = "📋";
            // 
            // lblWarning
            // 
            this.lblWarning.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblWarning.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.lblWarning.Location = new System.Drawing.Point(0, 210);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(450, 20);
            this.lblWarning.TabIndex = 4;
            this.lblWarning.Text = "⚠️ Mật khẩu này chỉ hiển thị 1 lần. Hãy lưu lại ngay!";
            this.lblWarning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FillColor = System.Drawing.Color.Transparent;
            this.btnClose.IconColor = System.Drawing.Color.Gray;
            this.btnClose.Location = new System.Drawing.Point(405, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(45, 29);
            this.btnClose.TabIndex = 5;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.pnlBorder;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // timerResetIcon
            // 
            this.timerResetIcon.Interval = 2000;
            // 
            // PasswordResultDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(450, 280);
            this.Controls.Add(this.pnlBorder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PasswordResultDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Password Result";
            this.pnlBorder.ResumeLayout(false);
            this.pnlPasswordBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlBorder;
        private Guna.UI2.WinForms.Guna2Button btnSuccessIcon;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblUsername;
        private Guna.UI2.WinForms.Guna2Panel pnlPasswordBox;
        private System.Windows.Forms.Label lblPassword;
        private Guna.UI2.WinForms.Guna2Button btnCopy;
        private System.Windows.Forms.Label lblWarning;
        private Guna.UI2.WinForms.Guna2ControlBox btnClose;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private System.Windows.Forms.Timer timerResetIcon;
    }
}