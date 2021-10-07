
namespace Dev69Restaurant.GUI.Manager
{
    partial class ManagerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerForm));
            this.gnDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.btnMaximize = new Guna.UI.WinForms.GunaControlBox();
            this.btnMinimize = new Guna.UI.WinForms.GunaControlBox();
            this.btnClose = new Guna.UI.WinForms.GunaControlBox();
            this.pnTop = new Guna.UI2.WinForms.Guna2Panel();
            this.pnLeft = new Guna.UI.WinForms.GunaPanel();
            this.btnHome = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnFood = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnManageStaff = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnStatistic = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnAbout = new Guna.UI2.WinForms.Guna2GradientButton();
            this.gnSeparate = new Guna.UI.WinForms.GunaSeparator();
            this.btnTableFood = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnSetting = new Guna.UI2.WinForms.Guna2GradientButton();
            this.pnMain = new System.Windows.Forms.Panel();
            this.picLogo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pnTop.SuspendLayout();
            this.pnLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // gnDragControl1
            // 
            this.gnDragControl1.TargetControl = this;
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.AnimationHoverSpeed = 0.07F;
            this.btnMaximize.AnimationSpeed = 0.03F;
            this.btnMaximize.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MaximizeBox;
            this.btnMaximize.IconColor = System.Drawing.Color.Black;
            this.btnMaximize.IconSize = 15F;
            this.btnMaximize.Location = new System.Drawing.Point(1167, 4);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.btnMaximize.OnHoverIconColor = System.Drawing.Color.White;
            this.btnMaximize.OnPressedColor = System.Drawing.Color.Black;
            this.btnMaximize.Size = new System.Drawing.Size(45, 30);
            this.btnMaximize.TabIndex = 0;
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.AnimationHoverSpeed = 0.07F;
            this.btnMinimize.AnimationSpeed = 0.03F;
            this.btnMinimize.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MinimizeBox;
            this.btnMinimize.IconColor = System.Drawing.Color.Black;
            this.btnMinimize.IconSize = 15F;
            this.btnMinimize.Location = new System.Drawing.Point(1116, 4);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.btnMinimize.OnHoverIconColor = System.Drawing.Color.White;
            this.btnMinimize.OnPressedColor = System.Drawing.Color.Black;
            this.btnMinimize.Size = new System.Drawing.Size(45, 30);
            this.btnMinimize.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.AnimationHoverSpeed = 0.07F;
            this.btnClose.AnimationSpeed = 0.03F;
            this.btnClose.IconColor = System.Drawing.Color.Black;
            this.btnClose.IconSize = 15F;
            this.btnClose.Location = new System.Drawing.Point(1218, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.btnClose.OnHoverIconColor = System.Drawing.Color.White;
            this.btnClose.OnPressedColor = System.Drawing.Color.Black;
            this.btnClose.Size = new System.Drawing.Size(45, 30);
            this.btnClose.TabIndex = 0;
            // 
            // pnTop
            // 
            this.pnTop.Controls.Add(this.picLogo);
            this.pnTop.Controls.Add(this.btnClose);
            this.pnTop.Controls.Add(this.btnMinimize);
            this.pnTop.Controls.Add(this.btnMaximize);
            this.pnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTop.Location = new System.Drawing.Point(0, 0);
            this.pnTop.Name = "pnTop";
            this.pnTop.ShadowDecoration.Parent = this.pnTop;
            this.pnTop.Size = new System.Drawing.Size(1280, 38);
            this.pnTop.TabIndex = 13;
            // 
            // pnLeft
            // 
            this.pnLeft.BackColor = System.Drawing.Color.White;
            this.pnLeft.Controls.Add(this.gnSeparate);
            this.pnLeft.Controls.Add(this.btnHome);
            this.pnLeft.Controls.Add(this.btnTableFood);
            this.pnLeft.Controls.Add(this.btnAbout);
            this.pnLeft.Controls.Add(this.btnManageStaff);
            this.pnLeft.Controls.Add(this.btnSetting);
            this.pnLeft.Controls.Add(this.btnStatistic);
            this.pnLeft.Controls.Add(this.btnFood);
            this.pnLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnLeft.Location = new System.Drawing.Point(0, 38);
            this.pnLeft.Name = "pnLeft";
            this.pnLeft.Size = new System.Drawing.Size(332, 682);
            this.pnLeft.TabIndex = 14;
            // 
            // btnHome
            // 
            this.btnHome.BorderRadius = 8;
            this.btnHome.CheckedState.Parent = this.btnHome;
            this.btnHome.CustomImages.CheckedImage = global::Dev69Restaurant.Properties.Resources.home_48px;
            this.btnHome.CustomImages.HoveredImage = global::Dev69Restaurant.Properties.Resources.home_hover_48px;
            this.btnHome.CustomImages.Image = global::Dev69Restaurant.Properties.Resources.home_48px;
            this.btnHome.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnHome.CustomImages.ImageSize = new System.Drawing.Size(32, 32);
            this.btnHome.CustomImages.Parent = this.btnHome;
            this.btnHome.FillColor = System.Drawing.Color.White;
            this.btnHome.FillColor2 = System.Drawing.Color.White;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnHome.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(235)))), ((int)(((byte)(237)))));
            this.btnHome.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(235)))), ((int)(((byte)(237)))));
            this.btnHome.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(165)))));
            this.btnHome.HoverState.Parent = this.btnHome;
            this.btnHome.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnHome.Location = new System.Drawing.Point(12, 39);
            this.btnHome.Name = "btnHome";
            this.btnHome.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(217)))), ((int)(((byte)(220)))));
            this.btnHome.PressedDepth = 100;
            this.btnHome.ShadowDecoration.Parent = this.btnHome;
            this.btnHome.Size = new System.Drawing.Size(275, 50);
            this.btnHome.TabIndex = 6;
            this.btnHome.Text = "Doanh Thu";
            // 
            // btnFood
            // 
            this.btnFood.BorderRadius = 8;
            this.btnFood.CheckedState.Parent = this.btnFood;
            this.btnFood.CustomImages.CheckedImage = global::Dev69Restaurant.Properties.Resources.food_bar_48px;
            this.btnFood.CustomImages.HoveredImage = global::Dev69Restaurant.Properties.Resources.food_bar_hover_48px;
            this.btnFood.CustomImages.Image = global::Dev69Restaurant.Properties.Resources.food_bar_48px;
            this.btnFood.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnFood.CustomImages.ImageSize = new System.Drawing.Size(32, 32);
            this.btnFood.CustomImages.Parent = this.btnFood;
            this.btnFood.FillColor = System.Drawing.Color.White;
            this.btnFood.FillColor2 = System.Drawing.Color.White;
            this.btnFood.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFood.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFood.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(235)))), ((int)(((byte)(237)))));
            this.btnFood.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(235)))), ((int)(((byte)(237)))));
            this.btnFood.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(165)))));
            this.btnFood.HoverState.Parent = this.btnFood;
            this.btnFood.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnFood.Location = new System.Drawing.Point(12, 197);
            this.btnFood.Name = "btnFood";
            this.btnFood.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(217)))), ((int)(((byte)(220)))));
            this.btnFood.PressedDepth = 100;
            this.btnFood.ShadowDecoration.Parent = this.btnFood;
            this.btnFood.Size = new System.Drawing.Size(275, 50);
            this.btnFood.TabIndex = 6;
            this.btnFood.Text = "Food";
            // 
            // btnManageStaff
            // 
            this.btnManageStaff.BorderRadius = 8;
            this.btnManageStaff.CheckedState.Parent = this.btnManageStaff;
            this.btnManageStaff.CustomImages.CheckedImage = global::Dev69Restaurant.Properties.Resources.user_group_48px;
            this.btnManageStaff.CustomImages.HoveredImage = global::Dev69Restaurant.Properties.Resources.user_group_hover_48px;
            this.btnManageStaff.CustomImages.Image = global::Dev69Restaurant.Properties.Resources.user_group_48px;
            this.btnManageStaff.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnManageStaff.CustomImages.ImageSize = new System.Drawing.Size(32, 32);
            this.btnManageStaff.CustomImages.Parent = this.btnManageStaff;
            this.btnManageStaff.FillColor = System.Drawing.Color.White;
            this.btnManageStaff.FillColor2 = System.Drawing.Color.White;
            this.btnManageStaff.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageStaff.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnManageStaff.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(235)))), ((int)(((byte)(237)))));
            this.btnManageStaff.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(235)))), ((int)(((byte)(237)))));
            this.btnManageStaff.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(165)))));
            this.btnManageStaff.HoverState.Parent = this.btnManageStaff;
            this.btnManageStaff.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnManageStaff.Location = new System.Drawing.Point(12, 355);
            this.btnManageStaff.Name = "btnManageStaff";
            this.btnManageStaff.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(217)))), ((int)(((byte)(220)))));
            this.btnManageStaff.PressedDepth = 100;
            this.btnManageStaff.ShadowDecoration.Parent = this.btnManageStaff;
            this.btnManageStaff.Size = new System.Drawing.Size(275, 50);
            this.btnManageStaff.TabIndex = 6;
            this.btnManageStaff.Text = "Quản lý nhân viên";
            this.btnManageStaff.Click += new System.EventHandler(this.btnManageStaff_Click);
            // 
            // btnStatistic
            // 
            this.btnStatistic.BorderRadius = 8;
            this.btnStatistic.CheckedState.Parent = this.btnStatistic;
            this.btnStatistic.CustomImages.CheckedImage = global::Dev69Restaurant.Properties.Resources.statistics_48px;
            this.btnStatistic.CustomImages.HoveredImage = ((System.Drawing.Image)(resources.GetObject("btnStatistic.CustomImages.HoveredImage")));
            this.btnStatistic.CustomImages.Image = global::Dev69Restaurant.Properties.Resources.statistics_48px;
            this.btnStatistic.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnStatistic.CustomImages.ImageSize = new System.Drawing.Size(32, 32);
            this.btnStatistic.CustomImages.Parent = this.btnStatistic;
            this.btnStatistic.FillColor = System.Drawing.Color.White;
            this.btnStatistic.FillColor2 = System.Drawing.Color.White;
            this.btnStatistic.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatistic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnStatistic.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(235)))), ((int)(((byte)(237)))));
            this.btnStatistic.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(235)))), ((int)(((byte)(237)))));
            this.btnStatistic.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(165)))));
            this.btnStatistic.HoverState.Parent = this.btnStatistic;
            this.btnStatistic.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnStatistic.Location = new System.Drawing.Point(12, 276);
            this.btnStatistic.Name = "btnStatistic";
            this.btnStatistic.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(217)))), ((int)(((byte)(220)))));
            this.btnStatistic.PressedDepth = 100;
            this.btnStatistic.ShadowDecoration.Parent = this.btnStatistic;
            this.btnStatistic.Size = new System.Drawing.Size(275, 50);
            this.btnStatistic.TabIndex = 6;
            this.btnStatistic.Text = "Statistic";
            // 
            // btnAbout
            // 
            this.btnAbout.BorderRadius = 8;
            this.btnAbout.CheckedState.Parent = this.btnAbout;
            this.btnAbout.CustomImages.CheckedImage = global::Dev69Restaurant.Properties.Resources.info_48px;
            this.btnAbout.CustomImages.HoveredImage = global::Dev69Restaurant.Properties.Resources.info_hover_48px;
            this.btnAbout.CustomImages.Image = global::Dev69Restaurant.Properties.Resources.info_48px;
            this.btnAbout.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAbout.CustomImages.ImageSize = new System.Drawing.Size(32, 32);
            this.btnAbout.CustomImages.Parent = this.btnAbout;
            this.btnAbout.FillColor = System.Drawing.Color.White;
            this.btnAbout.FillColor2 = System.Drawing.Color.White;
            this.btnAbout.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAbout.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(235)))), ((int)(((byte)(237)))));
            this.btnAbout.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(235)))), ((int)(((byte)(237)))));
            this.btnAbout.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(165)))));
            this.btnAbout.HoverState.Parent = this.btnAbout;
            this.btnAbout.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAbout.Location = new System.Drawing.Point(12, 434);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(217)))), ((int)(((byte)(220)))));
            this.btnAbout.PressedDepth = 100;
            this.btnAbout.ShadowDecoration.Parent = this.btnAbout;
            this.btnAbout.Size = new System.Drawing.Size(275, 50);
            this.btnAbout.TabIndex = 6;
            this.btnAbout.Text = "About";
            // 
            // gnSeparate
            // 
            this.gnSeparate.LineColor = System.Drawing.Color.Silver;
            this.gnSeparate.Location = new System.Drawing.Point(12, 411);
            this.gnSeparate.Name = "gnSeparate";
            this.gnSeparate.Size = new System.Drawing.Size(315, 10);
            this.gnSeparate.TabIndex = 8;
            // 
            // btnTableFood
            // 
            this.btnTableFood.BorderRadius = 8;
            this.btnTableFood.CheckedState.Parent = this.btnTableFood;
            this.btnTableFood.CustomImages.CheckedImage = global::Dev69Restaurant.Properties.Resources.table_top_view_48px;
            this.btnTableFood.CustomImages.HoveredImage = global::Dev69Restaurant.Properties.Resources.table_top_view_hover_48px;
            this.btnTableFood.CustomImages.Image = global::Dev69Restaurant.Properties.Resources.table_top_view_48px;
            this.btnTableFood.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTableFood.CustomImages.ImageSize = new System.Drawing.Size(32, 32);
            this.btnTableFood.CustomImages.Parent = this.btnTableFood;
            this.btnTableFood.FillColor = System.Drawing.Color.White;
            this.btnTableFood.FillColor2 = System.Drawing.Color.White;
            this.btnTableFood.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTableFood.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnTableFood.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(235)))), ((int)(((byte)(237)))));
            this.btnTableFood.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(235)))), ((int)(((byte)(237)))));
            this.btnTableFood.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(165)))));
            this.btnTableFood.HoverState.Parent = this.btnTableFood;
            this.btnTableFood.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTableFood.Location = new System.Drawing.Point(12, 118);
            this.btnTableFood.Margin = new System.Windows.Forms.Padding(3, 3, 15, 3);
            this.btnTableFood.Name = "btnTableFood";
            this.btnTableFood.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(217)))), ((int)(((byte)(220)))));
            this.btnTableFood.PressedDepth = 100;
            this.btnTableFood.ShadowDecoration.Parent = this.btnTableFood;
            this.btnTableFood.Size = new System.Drawing.Size(275, 50);
            this.btnTableFood.TabIndex = 6;
            this.btnTableFood.Text = "Table Food";
            // 
            // btnSetting
            // 
            this.btnSetting.BorderRadius = 8;
            this.btnSetting.CheckedState.Parent = this.btnSetting;
            this.btnSetting.CustomImages.CheckedImage = global::Dev69Restaurant.Properties.Resources.settings_48px;
            this.btnSetting.CustomImages.HoveredImage = global::Dev69Restaurant.Properties.Resources.settings_hover_48px;
            this.btnSetting.CustomImages.Image = global::Dev69Restaurant.Properties.Resources.settings_48px;
            this.btnSetting.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSetting.CustomImages.ImageSize = new System.Drawing.Size(32, 32);
            this.btnSetting.CustomImages.Parent = this.btnSetting;
            this.btnSetting.FillColor = System.Drawing.Color.White;
            this.btnSetting.FillColor2 = System.Drawing.Color.White;
            this.btnSetting.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetting.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSetting.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(235)))), ((int)(((byte)(237)))));
            this.btnSetting.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(235)))), ((int)(((byte)(237)))));
            this.btnSetting.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(165)))));
            this.btnSetting.HoverState.Parent = this.btnSetting;
            this.btnSetting.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSetting.Location = new System.Drawing.Point(12, 513);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(217)))), ((int)(((byte)(220)))));
            this.btnSetting.PressedDepth = 100;
            this.btnSetting.ShadowDecoration.Parent = this.btnSetting;
            this.btnSetting.Size = new System.Drawing.Size(275, 50);
            this.btnSetting.TabIndex = 6;
            this.btnSetting.Text = "Setting";
            // 
            // pnMain
            // 
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMain.Location = new System.Drawing.Point(332, 38);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(948, 682);
            this.pnMain.TabIndex = 15;
            // 
            // picLogo
            // 
            this.picLogo.Image = global::Dev69Restaurant.Properties.Resources.banner_Logo_Dark;
            this.picLogo.Location = new System.Drawing.Point(12, 3);
            this.picLogo.Name = "picLogo";
            this.picLogo.ShadowDecoration.Parent = this.picLogo;
            this.picLogo.Size = new System.Drawing.Size(118, 32);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 7;
            this.picLogo.TabStop = false;
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.pnMain);
            this.Controls.Add(this.pnLeft);
            this.Controls.Add(this.pnTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManagerForm";
            this.Text = "ManagerForm";
            this.pnTop.ResumeLayout(false);
            this.pnLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaDragControl gnDragControl1;
        private Guna.UI2.WinForms.Guna2Panel pnTop;
        private Guna.UI.WinForms.GunaControlBox btnClose;
        private Guna.UI.WinForms.GunaControlBox btnMinimize;
        private Guna.UI.WinForms.GunaControlBox btnMaximize;
        private Guna.UI.WinForms.GunaPanel pnLeft;
        private Guna.UI.WinForms.GunaSeparator gnSeparate;
        private Guna.UI2.WinForms.Guna2GradientButton btnHome;
        private Guna.UI2.WinForms.Guna2GradientButton btnTableFood;
        private Guna.UI2.WinForms.Guna2GradientButton btnAbout;
        private Guna.UI2.WinForms.Guna2GradientButton btnManageStaff;
        private Guna.UI2.WinForms.Guna2GradientButton btnSetting;
        private Guna.UI2.WinForms.Guna2GradientButton btnStatistic;
        private Guna.UI2.WinForms.Guna2GradientButton btnFood;
        private Guna.UI2.WinForms.Guna2PictureBox picLogo;
        private System.Windows.Forms.Panel pnMain;
    }
}