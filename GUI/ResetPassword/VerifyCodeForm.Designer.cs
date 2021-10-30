
namespace Dev69Restaurant.GUI.ResetPassword
{
    partial class VerifyCodeForm
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
            this.pnTop = new System.Windows.Forms.Panel();
            this.gunaControlBox2 = new Guna.UI.WinForms.GunaControlBox();
            this.gunaControlBox1 = new Guna.UI.WinForms.GunaControlBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dragForm = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSendCode = new Guna.UI.WinForms.GunaGradientButton();
            this.btnVerify = new Guna.UI.WinForms.GunaGradientButton();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblblllb = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtVerifyCode = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.shadowForm = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.pnTop.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnTop
            // 
            this.pnTop.Controls.Add(this.gunaControlBox2);
            this.pnTop.Controls.Add(this.gunaControlBox1);
            this.pnTop.Controls.Add(this.label1);
            this.pnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTop.Location = new System.Drawing.Point(0, 0);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(440, 48);
            this.pnTop.TabIndex = 0;
            // 
            // gunaControlBox2
            // 
            this.gunaControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox2.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox2.AnimationSpeed = 0.03F;
            this.gunaControlBox2.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MinimizeBox;
            this.gunaControlBox2.IconColor = System.Drawing.Color.Black;
            this.gunaControlBox2.IconSize = 15F;
            this.gunaControlBox2.Location = new System.Drawing.Point(332, 12);
            this.gunaControlBox2.Name = "gunaControlBox2";
            this.gunaControlBox2.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.gunaControlBox2.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox2.Size = new System.Drawing.Size(45, 29);
            this.gunaControlBox2.TabIndex = 0;
            // 
            // gunaControlBox1
            // 
            this.gunaControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox1.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox1.AnimationSpeed = 0.03F;
            this.gunaControlBox1.IconColor = System.Drawing.Color.Black;
            this.gunaControlBox1.IconSize = 15F;
            this.gunaControlBox1.Location = new System.Drawing.Point(383, 12);
            this.gunaControlBox1.Name = "gunaControlBox1";
            this.gunaControlBox1.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.gunaControlBox1.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox1.Size = new System.Drawing.Size(45, 29);
            this.gunaControlBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "Xác nhận Email";
            // 
            // dragForm
            // 
            this.dragForm.TargetControl = this.pnTop;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSendCode);
            this.panel1.Controls.Add(this.btnVerify);
            this.panel1.Controls.Add(this.lblPassword);
            this.panel1.Controls.Add(this.lblblllb);
            this.panel1.Controls.Add(this.lblUsername);
            this.panel1.Controls.Add(this.txtUsername);
            this.panel1.Controls.Add(this.txtVerifyCode);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(440, 492);
            this.panel1.TabIndex = 1;
            // 
            // btnSendCode
            // 
            this.btnSendCode.AnimationHoverSpeed = 0.07F;
            this.btnSendCode.AnimationSpeed = 0.03F;
            this.btnSendCode.BackColor = System.Drawing.Color.Transparent;
            this.btnSendCode.BaseColor1 = System.Drawing.Color.SlateBlue;
            this.btnSendCode.BaseColor2 = System.Drawing.Color.Fuchsia;
            this.btnSendCode.BorderColor = System.Drawing.Color.Black;
            this.btnSendCode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSendCode.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSendCode.FocusedColor = System.Drawing.Color.Empty;
            this.btnSendCode.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendCode.ForeColor = System.Drawing.Color.White;
            this.btnSendCode.Image = null;
            this.btnSendCode.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSendCode.Location = new System.Drawing.Point(294, 238);
            this.btnSendCode.Name = "btnSendCode";
            this.btnSendCode.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btnSendCode.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnSendCode.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSendCode.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSendCode.OnHoverImage = null;
            this.btnSendCode.OnPressedColor = System.Drawing.Color.Black;
            this.btnSendCode.Radius = 8;
            this.btnSendCode.Size = new System.Drawing.Size(118, 45);
            this.btnSendCode.TabIndex = 13;
            this.btnSendCode.Text = "Gửi mã";
            this.btnSendCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSendCode.Click += new System.EventHandler(this.btnSendCode_Click);
            // 
            // btnVerify
            // 
            this.btnVerify.AnimationHoverSpeed = 0.07F;
            this.btnVerify.AnimationSpeed = 0.03F;
            this.btnVerify.BackColor = System.Drawing.Color.Transparent;
            this.btnVerify.BaseColor1 = System.Drawing.Color.SlateBlue;
            this.btnVerify.BaseColor2 = System.Drawing.Color.Fuchsia;
            this.btnVerify.BorderColor = System.Drawing.Color.Black;
            this.btnVerify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerify.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnVerify.FocusedColor = System.Drawing.Color.Empty;
            this.btnVerify.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerify.ForeColor = System.Drawing.Color.White;
            this.btnVerify.Image = null;
            this.btnVerify.ImageSize = new System.Drawing.Size(20, 20);
            this.btnVerify.Location = new System.Drawing.Point(18, 415);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btnVerify.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnVerify.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnVerify.OnHoverForeColor = System.Drawing.Color.White;
            this.btnVerify.OnHoverImage = null;
            this.btnVerify.OnPressedColor = System.Drawing.Color.Black;
            this.btnVerify.Radius = 8;
            this.btnVerify.Size = new System.Drawing.Size(394, 45);
            this.btnVerify.TabIndex = 13;
            this.btnVerify.Text = "Xác nhận";
            this.btnVerify.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnVerify.Click += new System.EventHandler(this.btnVerify_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(15, 313);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(110, 23);
            this.lblPassword.TabIndex = 8;
            this.lblPassword.Text = "Mã xác nhận";
            // 
            // lblblllb
            // 
            this.lblblllb.AutoSize = true;
            this.lblblllb.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblblllb.Location = new System.Drawing.Point(15, 45);
            this.lblblllb.Name = "lblblllb";
            this.lblblllb.Size = new System.Drawing.Size(124, 23);
            this.lblblllb.TabIndex = 9;
            this.lblblllb.Text = "Tên đăng nhập";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(15, 144);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(51, 23);
            this.lblUsername.TabIndex = 9;
            this.lblUsername.Text = "Email";
            // 
            // txtUsername
            // 
            this.txtUsername.BorderRadius = 8;
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.DefaultText = "";
            this.txtUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername.DisabledState.Parent = this.txtUsername;
            this.txtUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsername.FocusedState.Parent = this.txtUsername;
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.Black;
            this.txtUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsername.HoverState.Parent = this.txtUsername;
            this.txtUsername.Location = new System.Drawing.Point(17, 72);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PasswordChar = '\0';
            this.txtUsername.PlaceholderText = "Nhập tên đăng nhập";
            this.txtUsername.SelectedText = "";
            this.txtUsername.ShadowDecoration.Parent = this.txtUsername;
            this.txtUsername.Size = new System.Drawing.Size(394, 42);
            this.txtUsername.TabIndex = 7;
            // 
            // txtVerifyCode
            // 
            this.txtVerifyCode.BorderRadius = 8;
            this.txtVerifyCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtVerifyCode.DefaultText = "";
            this.txtVerifyCode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtVerifyCode.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtVerifyCode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtVerifyCode.DisabledState.Parent = this.txtVerifyCode;
            this.txtVerifyCode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtVerifyCode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtVerifyCode.FocusedState.Parent = this.txtVerifyCode;
            this.txtVerifyCode.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVerifyCode.ForeColor = System.Drawing.Color.Black;
            this.txtVerifyCode.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtVerifyCode.HoverState.Parent = this.txtVerifyCode;
            this.txtVerifyCode.Location = new System.Drawing.Point(18, 340);
            this.txtVerifyCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtVerifyCode.Name = "txtVerifyCode";
            this.txtVerifyCode.PasswordChar = '\0';
            this.txtVerifyCode.PlaceholderText = "Nhập mã xác nhận";
            this.txtVerifyCode.SelectedText = "";
            this.txtVerifyCode.ShadowDecoration.Parent = this.txtVerifyCode;
            this.txtVerifyCode.Size = new System.Drawing.Size(394, 42);
            this.txtVerifyCode.TabIndex = 6;
            // 
            // txtEmail
            // 
            this.txtEmail.BorderRadius = 8;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.DefaultText = "";
            this.txtEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.DisabledState.Parent = this.txtEmail;
            this.txtEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.FocusedState.Parent = this.txtEmail;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.Black;
            this.txtEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.HoverState.Parent = this.txtEmail;
            this.txtEmail.Location = new System.Drawing.Point(18, 171);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.PlaceholderText = "Nhập email";
            this.txtEmail.SelectedText = "";
            this.txtEmail.ShadowDecoration.Parent = this.txtEmail;
            this.txtEmail.Size = new System.Drawing.Size(394, 42);
            this.txtEmail.TabIndex = 7;
            // 
            // VerifyCodeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(440, 540);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VerifyCodeForm";
            this.Text = "Xác nhận Email";
            this.Load += new System.EventHandler(this.VerifyCodeForm_Load);
            this.pnTop.ResumeLayout(false);
            this.pnTop.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnTop;
        private Guna.UI.WinForms.GunaDragControl dragForm;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox2;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaGradientButton btnSendCode;
        private Guna.UI.WinForms.GunaGradientButton btnVerify;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
        private Guna.UI2.WinForms.Guna2TextBox txtVerifyCode;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private System.Windows.Forms.Label lblblllb;
        private Guna.UI2.WinForms.Guna2TextBox txtUsername;
        private Guna.UI2.WinForms.Guna2ShadowForm shadowForm;
    }
}