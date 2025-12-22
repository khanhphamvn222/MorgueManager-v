namespace MorgueManager.UI.Views.Common
{
    partial class ToastForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlBorder = new Guna.UI2.WinForms.Guna2Panel();
            this.lblMsg = new System.Windows.Forms.Label();
            this.lblIcon = new System.Windows.Forms.Label();
            this.timerClose = new System.Windows.Forms.Timer(this.components);
            this.pnlBorder.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBorder
            // 
            this.pnlBorder.BorderColor = System.Drawing.Color.White;
            this.pnlBorder.BorderThickness = 1;
            this.pnlBorder.Controls.Add(this.lblMsg);
            this.pnlBorder.Controls.Add(this.lblIcon);
            this.pnlBorder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBorder.Location = new System.Drawing.Point(0, 0);
            this.pnlBorder.Name = "pnlBorder";
            this.pnlBorder.Size = new System.Drawing.Size(300, 60);
            this.pnlBorder.TabIndex = 0;
            // 
            // lblMsg
            // 
            this.lblMsg.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblMsg.ForeColor = System.Drawing.Color.White;
            this.lblMsg.Location = new System.Drawing.Point(50, 10);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(240, 40);
            this.lblMsg.TabIndex = 1;
            this.lblMsg.Text = "Message content goes here";
            this.lblMsg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblIcon
            // 
            this.lblIcon.AutoSize = true;
            this.lblIcon.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.lblIcon.ForeColor = System.Drawing.Color.White;
            this.lblIcon.Location = new System.Drawing.Point(15, 10);
            this.lblIcon.Name = "lblIcon";
            this.lblIcon.Size = new System.Drawing.Size(38, 32);
            this.lblIcon.TabIndex = 0;
            this.lblIcon.Text = "✔";
            // 
            // timerClose
            // 
            this.timerClose.Interval = 100;
            // 
            // ToastForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(95)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(300, 60);
            this.Controls.Add(this.pnlBorder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ToastForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ToastForm";
            this.TopMost = true;
            this.pnlBorder.ResumeLayout(false);
            this.pnlBorder.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlBorder;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.Label lblIcon;
        private System.Windows.Forms.Timer timerClose;
    }
}