namespace MorgueManager.UI.Views.Auth
{
    partial class LoginSplitForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);

            // Fix CS1061: Đổi sang Guna2GradientPanel để dùng Gradient
            this.pnlBranding = new Guna.UI2.WinForms.Guna2GradientPanel();

            this.lblCopyright = new System.Windows.Forms.Label();
            this.pnlFeature2 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblFeature2Sub = new System.Windows.Forms.Label();
            this.lblFeature2Title = new System.Windows.Forms.Label();
            this.iconFeature2 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.pnlFeature1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblFeature1Sub = new System.Windows.Forms.Label();
            this.lblFeature1Title = new System.Windows.Forms.Label();
            this.iconFeature1 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblHeadline = new System.Windows.Forms.Label();
            this.pnlLogo = new Guna.UI2.WinForms.Guna2Panel();
            this.lblBrandName = new System.Windows.Forms.Label();
            this.picBrandLogo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pnlLogin = new Guna.UI2.WinForms.Guna2Panel();
            this.btnClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.lblSupport = new System.Windows.Forms.Label();
            this.lnkSupport = new System.Windows.Forms.LinkLabel();
            this.btnLogin = new Guna.UI2.WinForms.Guna2Button();
            this.lnkForgot = new System.Windows.Forms.LinkLabel();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblWelcomeSub = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.pnlBranding.SuspendLayout();
            this.pnlFeature2.SuspendLayout();
            this.pnlFeature1.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBrandLogo)).BeginInit();
            this.pnlLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 0;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.pnlBranding;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // pnlBranding
            // 
            this.pnlBranding.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(27)))), ((int)(((byte)(75)))));
            this.pnlBranding.Controls.Add(this.lblCopyright);
            this.pnlBranding.Controls.Add(this.pnlFeature2);
            this.pnlBranding.Controls.Add(this.pnlFeature1);
            this.pnlBranding.Controls.Add(this.lblDescription);
            this.pnlBranding.Controls.Add(this.lblHeadline);
            this.pnlBranding.Controls.Add(this.pnlLogo);
            this.pnlBranding.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlBranding.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(6)))), ((int)(((byte)(23)))));
            this.pnlBranding.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(46)))), ((int)(((byte)(129)))));
            this.pnlBranding.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.pnlBranding.Location = new System.Drawing.Point(0, 0);
            this.pnlBranding.Name = "pnlBranding";
            this.pnlBranding.Size = new System.Drawing.Size(600, 720);
            this.pnlBranding.TabIndex = 0;
            // 
            // lblCopyright
            // 
            this.lblCopyright.BackColor = System.Drawing.Color.Transparent;
            this.lblCopyright.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblCopyright.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblCopyright.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblCopyright.Location = new System.Drawing.Point(0, 680);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Padding = new System.Windows.Forms.Padding(60, 0, 0, 40);
            this.lblCopyright.Size = new System.Drawing.Size(600, 40);
            this.lblCopyright.TabIndex = 5;
            this.lblCopyright.Text = "© 2024 Morgue Management System. Developed by Senior Team.";
            // 
            // pnlFeature2
            // 
            this.pnlFeature2.BackColor = System.Drawing.Color.Transparent;
            this.pnlFeature2.Controls.Add(this.lblFeature2Sub);
            this.pnlFeature2.Controls.Add(this.lblFeature2Title);
            this.pnlFeature2.Controls.Add(this.iconFeature2);
            this.pnlFeature2.Location = new System.Drawing.Point(60, 490);
            this.pnlFeature2.Name = "pnlFeature2";
            this.pnlFeature2.Size = new System.Drawing.Size(400, 50);
            this.pnlFeature2.TabIndex = 4;
            // 
            // lblFeature2Sub
            // 
            this.lblFeature2Sub.AutoSize = true;
            this.lblFeature2Sub.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblFeature2Sub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblFeature2Sub.Location = new System.Drawing.Point(50, 25);
            this.lblFeature2Sub.Name = "lblFeature2Sub";
            this.lblFeature2Sub.Size = new System.Drawing.Size(188, 15);
            this.lblFeature2Sub.TabIndex = 2;
            this.lblFeature2Sub.Text = "Cập nhật trạng thái thời gian thực";
            // 
            // lblFeature2Title
            // 
            this.lblFeature2Title.AutoSize = true;
            this.lblFeature2Title.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblFeature2Title.ForeColor = System.Drawing.Color.White;
            this.lblFeature2Title.Location = new System.Drawing.Point(50, 5);
            this.lblFeature2Title.Name = "lblFeature2Title";
            this.lblFeature2Title.Size = new System.Drawing.Size(99, 19);
            this.lblFeature2Title.TabIndex = 1;
            this.lblFeature2Title.Text = "Giám sát 24/7";
            // 
            // iconFeature2
            // 
            this.iconFeature2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.iconFeature2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.iconFeature2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.iconFeature2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.iconFeature2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(20)))));
            this.iconFeature2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.iconFeature2.ForeColor = System.Drawing.Color.White;
            this.iconFeature2.Location = new System.Drawing.Point(0, 5);
            this.iconFeature2.Name = "iconFeature2";
            this.iconFeature2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.iconFeature2.Size = new System.Drawing.Size(40, 40);
            this.iconFeature2.TabIndex = 0;
            // 
            // pnlFeature1
            // 
            this.pnlFeature1.BackColor = System.Drawing.Color.Transparent;
            this.pnlFeature1.Controls.Add(this.lblFeature1Sub);
            this.pnlFeature1.Controls.Add(this.lblFeature1Title);
            this.pnlFeature1.Controls.Add(this.iconFeature1);
            this.pnlFeature1.Location = new System.Drawing.Point(60, 430);
            this.pnlFeature1.Name = "pnlFeature1";
            this.pnlFeature1.Size = new System.Drawing.Size(400, 50);
            this.pnlFeature1.TabIndex = 3;
            // 
            // lblFeature1Sub
            // 
            this.lblFeature1Sub.AutoSize = true;
            this.lblFeature1Sub.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblFeature1Sub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblFeature1Sub.Location = new System.Drawing.Point(50, 25);
            this.lblFeature1Sub.Name = "lblFeature1Sub";
            this.lblFeature1Sub.Size = new System.Drawing.Size(170, 15);
            this.lblFeature1Sub.TabIndex = 2;
            this.lblFeature1Sub.Text = "Mã hóa dữ liệu chuẩn AES-256";
            // 
            // lblFeature1Title
            // 
            this.lblFeature1Title.AutoSize = true;
            this.lblFeature1Title.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblFeature1Title.ForeColor = System.Drawing.Color.White;
            this.lblFeature1Title.Location = new System.Drawing.Point(50, 5);
            this.lblFeature1Title.Name = "lblFeature1Title";
            this.lblFeature1Title.Size = new System.Drawing.Size(127, 19);
            this.lblFeature1Title.TabIndex = 1;
            this.lblFeature1Title.Text = "Bảo mật tuyệt đối";
            // 
            // iconFeature1
            // 
            this.iconFeature1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.iconFeature1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.iconFeature1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.iconFeature1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.iconFeature1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(20)))));
            this.iconFeature1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.iconFeature1.ForeColor = System.Drawing.Color.White;
            this.iconFeature1.Location = new System.Drawing.Point(0, 5);
            this.iconFeature1.Name = "iconFeature1";
            this.iconFeature1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.iconFeature1.Size = new System.Drawing.Size(40, 40);
            this.iconFeature1.TabIndex = 0;
            // 
            // lblDescription
            // 
            this.lblDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblDescription.Location = new System.Drawing.Point(60, 330);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(450, 60);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "Giải pháp toàn diện giúp tối ưu hóa quy trình tiếp nhận, lưu trữ và bàn giao. Đảm" +
    " bảo tính chính xác, bảo mật và nhân văn.";
            // 
            // lblHeadline
            // 
            this.lblHeadline.BackColor = System.Drawing.Color.Transparent;
            this.lblHeadline.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Bold);
            this.lblHeadline.ForeColor = System.Drawing.Color.White;
            this.lblHeadline.Location = new System.Drawing.Point(55, 180);
            this.lblHeadline.Name = "lblHeadline";
            this.lblHeadline.Size = new System.Drawing.Size(500, 130);
            this.lblHeadline.TabIndex = 1;
            this.lblHeadline.Text = "Quản lý Pháp y\r\n& Lưu trữ An toàn";
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackColor = System.Drawing.Color.Transparent;
            this.pnlLogo.Controls.Add(this.lblBrandName);
            this.pnlLogo.Controls.Add(this.picBrandLogo);
            this.pnlLogo.Location = new System.Drawing.Point(60, 60);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(300, 60);
            this.pnlLogo.TabIndex = 0;
            // 
            // lblBrandName
            // 
            this.lblBrandName.AutoSize = true;
            this.lblBrandName.BackColor = System.Drawing.Color.Transparent;
            this.lblBrandName.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblBrandName.ForeColor = System.Drawing.Color.White;
            this.lblBrandName.Location = new System.Drawing.Point(50, 8);
            this.lblBrandName.Name = "lblBrandName";
            this.lblBrandName.Size = new System.Drawing.Size(155, 32);
            this.lblBrandName.TabIndex = 1;
            this.lblBrandName.Text = "MORGUESYS";
            // 
            // picBrandLogo
            // 
            this.picBrandLogo.BackColor = System.Drawing.Color.Transparent;
            this.picBrandLogo.BorderRadius = 10;
            this.picBrandLogo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(70)))), ((int)(((byte)(229)))));
            this.picBrandLogo.ImageRotate = 0F;
            this.picBrandLogo.Location = new System.Drawing.Point(0, 5);
            this.picBrandLogo.Name = "picBrandLogo";
            this.picBrandLogo.Size = new System.Drawing.Size(40, 40);
            this.picBrandLogo.TabIndex = 0;
            this.picBrandLogo.TabStop = false;
            // 
            // pnlLogin
            // 
            this.pnlLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(6)))), ((int)(((byte)(23)))));
            this.pnlLogin.Controls.Add(this.btnClose);
            this.pnlLogin.Controls.Add(this.lblSupport);
            this.pnlLogin.Controls.Add(this.lnkSupport);
            this.pnlLogin.Controls.Add(this.btnLogin);
            this.pnlLogin.Controls.Add(this.lnkForgot);
            this.pnlLogin.Controls.Add(this.lblPassword);
            this.pnlLogin.Controls.Add(this.txtPassword);
            this.pnlLogin.Controls.Add(this.lblUsername);
            this.pnlLogin.Controls.Add(this.txtUsername);
            this.pnlLogin.Controls.Add(this.lblWelcomeSub);
            this.pnlLogin.Controls.Add(this.lblWelcome);
            this.pnlLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLogin.Location = new System.Drawing.Point(600, 0);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(600, 720);
            this.pnlLogin.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FillColor = System.Drawing.Color.Transparent;
            this.btnClose.IconColor = System.Drawing.Color.Gray;
            this.btnClose.Location = new System.Drawing.Point(550, 10);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(40, 40);
            this.btnClose.TabIndex = 0;
            // 
            // lblSupport
            // 
            this.lblSupport.AutoSize = true;
            this.lblSupport.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSupport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblSupport.Location = new System.Drawing.Point(200, 600);
            this.lblSupport.Name = "lblSupport";
            this.lblSupport.Size = new System.Drawing.Size(117, 15);
            this.lblSupport.TabIndex = 9;
            this.lblSupport.Text = "Cần hỗ trợ kỹ thuật?";
            // 
            // lnkSupport
            // 
            this.lnkSupport.AutoSize = true;
            this.lnkSupport.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lnkSupport.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lnkSupport.Location = new System.Drawing.Point(330, 600);
            this.lnkSupport.Name = "lnkSupport";
            this.lnkSupport.Size = new System.Drawing.Size(110, 15);
            this.lnkSupport.TabIndex = 10;
            this.lnkSupport.TabStop = true;
            this.lnkSupport.Text = "Liên hệ IT Support";
            // 
            // btnLogin
            // 
            this.btnLogin.Animated = true;
            this.btnLogin.BorderRadius = 10;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(70)))), ((int)(((byte)(229)))));
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(56)))), ((int)(((byte)(202)))));
            this.btnLogin.Location = new System.Drawing.Point(105, 440);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(400, 55);
            this.btnLogin.TabIndex = 8;
            this.btnLogin.Text = "Đăng nhập";
            // 
            // lnkForgot
            // 
            this.lnkForgot.AutoSize = true;
            this.lnkForgot.ActiveLinkColor = System.Drawing.Color.White;
            this.lnkForgot.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lnkForgot.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(140)))), ((int)(((byte)(248)))));
            this.lnkForgot.Location = new System.Drawing.Point(400, 330);
            this.lnkForgot.Name = "lnkForgot";
            this.lnkForgot.Size = new System.Drawing.Size(94, 15);
            this.lnkForgot.TabIndex = 7;
            this.lnkForgot.TabStop = true;
            this.lnkForgot.Text = "Quên mật khẩu?";
            this.lnkForgot.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.lblPassword.Location = new System.Drawing.Point(105, 330);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(59, 15);
            this.lblPassword.TabIndex = 5;
            this.lblPassword.Text = "Mật khẩu";
            // 
            // txtPassword
            // 
            this.txtPassword.Animated = true;
            this.txtPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.txtPassword.BorderRadius = 10;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DefaultText = "";
            this.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(70)))), ((int)(((byte)(229)))));
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPassword.ForeColor = System.Drawing.Color.White;
            this.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.Location = new System.Drawing.Point(105, 355);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.txtPassword.PlaceholderText = "••••••••";
            this.txtPassword.SelectedText = "";
            this.txtPassword.Size = new System.Drawing.Size(400, 50);
            this.txtPassword.TabIndex = 6;
            this.txtPassword.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.lblUsername.Location = new System.Drawing.Point(105, 230);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(88, 15);
            this.lblUsername.TabIndex = 3;
            this.lblUsername.Text = "Tên đăng nhập";
            // 
            // txtUsername
            // 
            this.txtUsername.Animated = true;
            this.txtUsername.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.txtUsername.BorderRadius = 10;
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.DefaultText = "";
            this.txtUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.txtUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(70)))), ((int)(((byte)(229)))));
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtUsername.ForeColor = System.Drawing.Color.White;
            this.txtUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsername.Location = new System.Drawing.Point(105, 255);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.txtUsername.PlaceholderText = "VD: admin@hospital.com";
            this.txtUsername.SelectedText = "";
            this.txtUsername.Size = new System.Drawing.Size(400, 50);
            this.txtUsername.TabIndex = 4;
            this.txtUsername.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // lblWelcomeSub
            // 
            this.lblWelcomeSub.AutoSize = true;
            this.lblWelcomeSub.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblWelcomeSub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblWelcomeSub.Location = new System.Drawing.Point(105, 170);
            this.lblWelcomeSub.Name = "lblWelcomeSub";
            this.lblWelcomeSub.Size = new System.Drawing.Size(262, 19);
            this.lblWelcomeSub.TabIndex = 2;
            this.lblWelcomeSub.Text = "Vui lòng nhập thông tin để truy cập hệ thống.";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.ForeColor = System.Drawing.Color.White;
            this.lblWelcome.Location = new System.Drawing.Point(100, 120);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(305, 45);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "Chào mừng trở lại!";
            // 
            // LoginSplitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1200, 720);
            this.Controls.Add(this.pnlLogin);
            this.Controls.Add(this.pnlBranding);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginSplitForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginSplitForm";
            this.pnlBranding.ResumeLayout(false);
            this.pnlBranding.PerformLayout();
            this.pnlFeature2.ResumeLayout(false);
            this.pnlFeature2.PerformLayout();
            this.pnlFeature1.ResumeLayout(false);
            this.pnlFeature1.PerformLayout();
            this.pnlLogo.ResumeLayout(false);
            this.pnlLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBrandLogo)).EndInit();
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;

        // FIX: Change Type to Guna2GradientPanel
        private Guna.UI2.WinForms.Guna2GradientPanel pnlBranding;

        private Guna.UI2.WinForms.Guna2Panel pnlLogo;
        private System.Windows.Forms.Label lblBrandName;
        private Guna.UI2.WinForms.Guna2PictureBox picBrandLogo;
        private System.Windows.Forms.Label lblHeadline;
        private System.Windows.Forms.Label lblDescription;
        private Guna.UI2.WinForms.Guna2Panel pnlFeature1;
        private Guna.UI2.WinForms.Guna2CircleButton iconFeature1;
        private System.Windows.Forms.Label lblFeature1Title;
        private System.Windows.Forms.Label lblFeature1Sub;
        private Guna.UI2.WinForms.Guna2Panel pnlFeature2;
        private Guna.UI2.WinForms.Guna2CircleButton iconFeature2;
        private System.Windows.Forms.Label lblFeature2Title;
        private System.Windows.Forms.Label lblFeature2Sub;
        private System.Windows.Forms.Label lblCopyright;
        private Guna.UI2.WinForms.Guna2Panel pnlLogin;
        private Guna.UI2.WinForms.Guna2ControlBox btnClose;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblWelcomeSub;
        private System.Windows.Forms.Label lblUsername;
        private Guna.UI2.WinForms.Guna2TextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private System.Windows.Forms.LinkLabel lnkForgot;
        private Guna.UI2.WinForms.Guna2Button btnLogin;
        private System.Windows.Forms.Label lblSupport;
        private System.Windows.Forms.LinkLabel lnkSupport;
    }
}