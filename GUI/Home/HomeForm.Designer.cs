
namespace Dev69Restaurant.GUI.Home
{
    partial class HomeForm
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
            Guna.UI2.AnimatorNS.Animation animation1 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.btnHome = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnAbout = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnStatistic = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnFood = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnTableFood = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnMinimize = new Guna.UI.WinForms.GunaControlBox();
            this.btnMaximize = new Guna.UI.WinForms.GunaControlBox();
            this.btnClose = new Guna.UI.WinForms.GunaControlBox();
            this.gnDragControl = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.pnTop = new Guna.UI2.WinForms.Guna2Panel();
            this.gnSeparate = new Guna.UI.WinForms.GunaSeparator();
            this.btnSetting = new Guna.UI2.WinForms.Guna2GradientButton();
            this.gnTransition = new Guna.UI2.WinForms.Guna2Transition();
            this.pnLeft = new Guna.UI.WinForms.GunaPanel();
            this.picLogo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pnHeader = new Guna.UI.WinForms.GunaPanel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.picAvatarUser = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnToogleMenu = new Guna.UI2.WinForms.Guna2ImageButton();
            this.pnDetail = new System.Windows.Forms.Panel();
            this.grbDetail = new Guna.UI.WinForms.GunaGroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCheckout = new Guna.UI2.WinForms.Guna2GradientButton();
            this.gnSeparator2 = new Guna.UI.WinForms.GunaSeparator();
            this.gnSeparator1 = new Guna.UI.WinForms.GunaSeparator();
            this.panel8 = new Guna.UI.WinForms.GunaPanel();
            this.pnFeature = new Guna.UI2.WinForms.Guna2Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel7 = new Guna.UI.WinForms.GunaPanel();
            this.pnMain = new Guna.UI2.WinForms.Guna2Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pnTop.SuspendLayout();
            this.pnLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.pnHeader.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatarUser)).BeginInit();
            this.pnDetail.SuspendLayout();
            this.grbDetail.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
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
            this.gnTransition.SetDecoration(this.btnHome, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnHome.FillColor = System.Drawing.Color.White;
            this.btnHome.FillColor2 = System.Drawing.Color.White;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnHome.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(235)))), ((int)(((byte)(237)))));
            this.btnHome.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(235)))), ((int)(((byte)(237)))));
            this.btnHome.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(165)))));
            this.btnHome.HoverState.Parent = this.btnHome;
            this.btnHome.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnHome.Location = new System.Drawing.Point(14, 266);
            this.btnHome.Name = "btnHome";
            this.btnHome.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(217)))), ((int)(((byte)(220)))));
            this.btnHome.PressedDepth = 100;
            this.btnHome.ShadowDecoration.Parent = this.btnHome;
            this.btnHome.Size = new System.Drawing.Size(275, 50);
            this.btnHome.TabIndex = 6;
            this.btnHome.Text = "Home";
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
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
            this.gnTransition.SetDecoration(this.btnAbout, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnAbout.FillColor = System.Drawing.Color.White;
            this.btnAbout.FillColor2 = System.Drawing.Color.White;
            this.btnAbout.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAbout.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(235)))), ((int)(((byte)(237)))));
            this.btnAbout.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(235)))), ((int)(((byte)(237)))));
            this.btnAbout.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(165)))));
            this.btnAbout.HoverState.Parent = this.btnAbout;
            this.btnAbout.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAbout.Location = new System.Drawing.Point(14, 819);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(217)))), ((int)(((byte)(220)))));
            this.btnAbout.PressedDepth = 100;
            this.btnAbout.ShadowDecoration.Parent = this.btnAbout;
            this.btnAbout.Size = new System.Drawing.Size(275, 50);
            this.btnAbout.TabIndex = 6;
            this.btnAbout.Text = "About";
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
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
            this.gnTransition.SetDecoration(this.btnStatistic, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnStatistic.FillColor = System.Drawing.Color.White;
            this.btnStatistic.FillColor2 = System.Drawing.Color.White;
            this.btnStatistic.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatistic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnStatistic.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(235)))), ((int)(((byte)(237)))));
            this.btnStatistic.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(235)))), ((int)(((byte)(237)))));
            this.btnStatistic.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(165)))));
            this.btnStatistic.HoverState.Parent = this.btnStatistic;
            this.btnStatistic.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnStatistic.Location = new System.Drawing.Point(14, 471);
            this.btnStatistic.Name = "btnStatistic";
            this.btnStatistic.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(217)))), ((int)(((byte)(220)))));
            this.btnStatistic.PressedDepth = 100;
            this.btnStatistic.ShadowDecoration.Parent = this.btnStatistic;
            this.btnStatistic.Size = new System.Drawing.Size(275, 50);
            this.btnStatistic.TabIndex = 6;
            this.btnStatistic.Text = "Statistic";
            this.btnStatistic.Click += new System.EventHandler(this.btnStatistic_Click);
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
            this.gnTransition.SetDecoration(this.btnFood, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnFood.FillColor = System.Drawing.Color.White;
            this.btnFood.FillColor2 = System.Drawing.Color.White;
            this.btnFood.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFood.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFood.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(235)))), ((int)(((byte)(237)))));
            this.btnFood.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(235)))), ((int)(((byte)(237)))));
            this.btnFood.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(165)))));
            this.btnFood.HoverState.Parent = this.btnFood;
            this.btnFood.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnFood.Location = new System.Drawing.Point(14, 403);
            this.btnFood.Name = "btnFood";
            this.btnFood.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(217)))), ((int)(((byte)(220)))));
            this.btnFood.PressedDepth = 100;
            this.btnFood.ShadowDecoration.Parent = this.btnFood;
            this.btnFood.Size = new System.Drawing.Size(275, 50);
            this.btnFood.TabIndex = 6;
            this.btnFood.Text = "Food";
            this.btnFood.Click += new System.EventHandler(this.btnFood_Click);
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
            this.gnTransition.SetDecoration(this.btnTableFood, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnTableFood.FillColor = System.Drawing.Color.White;
            this.btnTableFood.FillColor2 = System.Drawing.Color.White;
            this.btnTableFood.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTableFood.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnTableFood.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(235)))), ((int)(((byte)(237)))));
            this.btnTableFood.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(235)))), ((int)(((byte)(237)))));
            this.btnTableFood.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(165)))));
            this.btnTableFood.HoverState.Parent = this.btnTableFood;
            this.btnTableFood.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTableFood.Location = new System.Drawing.Point(14, 334);
            this.btnTableFood.Margin = new System.Windows.Forms.Padding(3, 3, 15, 3);
            this.btnTableFood.Name = "btnTableFood";
            this.btnTableFood.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(217)))), ((int)(((byte)(220)))));
            this.btnTableFood.PressedDepth = 100;
            this.btnTableFood.ShadowDecoration.Parent = this.btnTableFood;
            this.btnTableFood.Size = new System.Drawing.Size(275, 50);
            this.btnTableFood.TabIndex = 6;
            this.btnTableFood.Text = "Table Food";
            this.btnTableFood.Click += new System.EventHandler(this.btnTableFood_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.AnimationHoverSpeed = 0.07F;
            this.btnMinimize.AnimationSpeed = 0.03F;
            this.btnMinimize.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MinimizeBox;
            this.gnTransition.SetDecoration(this.btnMinimize, Guna.UI2.AnimatorNS.DecorationType.None);
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
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.AnimationHoverSpeed = 0.07F;
            this.btnMaximize.AnimationSpeed = 0.03F;
            this.btnMaximize.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MaximizeBox;
            this.gnTransition.SetDecoration(this.btnMaximize, Guna.UI2.AnimatorNS.DecorationType.None);
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
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.AnimationHoverSpeed = 0.07F;
            this.btnClose.AnimationSpeed = 0.03F;
            this.gnTransition.SetDecoration(this.btnClose, Guna.UI2.AnimatorNS.DecorationType.None);
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
            // gnDragControl
            // 
            this.gnDragControl.TargetControl = this.pnTop;
            // 
            // pnTop
            // 
            this.pnTop.Controls.Add(this.btnClose);
            this.pnTop.Controls.Add(this.btnMinimize);
            this.pnTop.Controls.Add(this.btnMaximize);
            this.gnTransition.SetDecoration(this.pnTop, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTop.Location = new System.Drawing.Point(320, 0);
            this.pnTop.Name = "pnTop";
            this.pnTop.ShadowDecoration.Parent = this.pnTop;
            this.pnTop.Size = new System.Drawing.Size(1280, 38);
            this.pnTop.TabIndex = 12;
            // 
            // gnSeparate
            // 
            this.gnTransition.SetDecoration(this.gnSeparate, Guna.UI2.AnimatorNS.DecorationType.None);
            this.gnSeparate.LineColor = System.Drawing.Color.Silver;
            this.gnSeparate.Location = new System.Drawing.Point(3, 726);
            this.gnSeparate.Name = "gnSeparate";
            this.gnSeparate.Size = new System.Drawing.Size(315, 10);
            this.gnSeparate.TabIndex = 8;
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
            this.gnTransition.SetDecoration(this.btnSetting, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnSetting.FillColor = System.Drawing.Color.White;
            this.btnSetting.FillColor2 = System.Drawing.Color.White;
            this.btnSetting.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetting.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSetting.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(235)))), ((int)(((byte)(237)))));
            this.btnSetting.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(235)))), ((int)(((byte)(237)))));
            this.btnSetting.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(165)))));
            this.btnSetting.HoverState.Parent = this.btnSetting;
            this.btnSetting.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSetting.Location = new System.Drawing.Point(14, 751);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(217)))), ((int)(((byte)(220)))));
            this.btnSetting.PressedDepth = 100;
            this.btnSetting.ShadowDecoration.Parent = this.btnSetting;
            this.btnSetting.Size = new System.Drawing.Size(275, 50);
            this.btnSetting.TabIndex = 6;
            this.btnSetting.Text = "Setting";
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // gnTransition
            // 
            this.gnTransition.AnimationType = Guna.UI2.AnimatorNS.AnimationType.HorizSlide;
            this.gnTransition.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.gnTransition.DefaultAnimation = animation1;
            // 
            // pnLeft
            // 
            this.pnLeft.BackColor = System.Drawing.Color.White;
            this.pnLeft.Controls.Add(this.btnHome);
            this.pnLeft.Controls.Add(this.btnFood);
            this.pnLeft.Controls.Add(this.btnStatistic);
            this.pnLeft.Controls.Add(this.picLogo);
            this.pnLeft.Controls.Add(this.btnAbout);
            this.pnLeft.Controls.Add(this.gnSeparate);
            this.pnLeft.Controls.Add(this.btnTableFood);
            this.pnLeft.Controls.Add(this.btnSetting);
            this.gnTransition.SetDecoration(this.pnLeft, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pnLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnLeft.Location = new System.Drawing.Point(0, 0);
            this.pnLeft.Name = "pnLeft";
            this.pnLeft.Size = new System.Drawing.Size(320, 900);
            this.pnLeft.TabIndex = 11;
            // 
            // picLogo
            // 
            this.gnTransition.SetDecoration(this.picLogo, Guna.UI2.AnimatorNS.DecorationType.None);
            this.picLogo.Image = global::Dev69Restaurant.Properties.Resources.banner_Logo_Dark;
            this.picLogo.Location = new System.Drawing.Point(0, 38);
            this.picLogo.Name = "picLogo";
            this.picLogo.ShadowDecoration.Parent = this.picLogo;
            this.picLogo.Size = new System.Drawing.Size(315, 100);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 7;
            this.picLogo.TabStop = false;
            // 
            // pnHeader
            // 
            this.pnHeader.Controls.Add(this.panel9);
            this.pnHeader.Controls.Add(this.txtSearch);
            this.pnHeader.Controls.Add(this.btnToogleMenu);
            this.gnTransition.SetDecoration(this.pnHeader, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pnHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnHeader.Location = new System.Drawing.Point(320, 38);
            this.pnHeader.Name = "pnHeader";
            this.pnHeader.Size = new System.Drawing.Size(1280, 100);
            this.pnHeader.TabIndex = 13;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.lblWelcome);
            this.panel9.Controls.Add(this.picAvatarUser);
            this.gnTransition.SetDecoration(this.panel9, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel9.Location = new System.Drawing.Point(929, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(351, 100);
            this.panel9.TabIndex = 11;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.gnTransition.SetDecoration(this.lblWelcome, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(13, 50);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(154, 23);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Xin chào, Dev69... !";
            // 
            // picAvatarUser
            // 
            this.picAvatarUser.BaseColor = System.Drawing.Color.White;
            this.gnTransition.SetDecoration(this.picAvatarUser, Guna.UI2.AnimatorNS.DecorationType.None);
            this.picAvatarUser.Image = global::Dev69Restaurant.Properties.Resources.user_50px;
            this.picAvatarUser.Location = new System.Drawing.Point(213, 25);
            this.picAvatarUser.Name = "picAvatarUser";
            this.picAvatarUser.Size = new System.Drawing.Size(48, 48);
            this.picAvatarUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAvatarUser.TabIndex = 11;
            this.picAvatarUser.TabStop = false;
            this.picAvatarUser.UseTransfarantBackground = false;
            // 
            // txtSearch
            // 
            this.txtSearch.BorderRadius = 8;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gnTransition.SetDecoration(this.txtSearch, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.Parent = this.txtSearch;
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.FocusedState.Parent = this.txtSearch;
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.HoverState.Parent = this.txtSearch;
            this.txtSearch.IconLeft = global::Dev69Restaurant.Properties.Resources.search_24px;
            this.txtSearch.Location = new System.Drawing.Point(147, 29);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "Search everything...";
            this.txtSearch.SelectedText = "";
            this.txtSearch.ShadowDecoration.Parent = this.txtSearch;
            this.txtSearch.Size = new System.Drawing.Size(623, 44);
            this.txtSearch.TabIndex = 0;
            // 
            // btnToogleMenu
            // 
            this.btnToogleMenu.CheckedState.Parent = this.btnToogleMenu;
            this.gnTransition.SetDecoration(this.btnToogleMenu, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnToogleMenu.HoverState.Image = global::Dev69Restaurant.Properties.Resources.menu_hover_48px;
            this.btnToogleMenu.HoverState.ImageSize = new System.Drawing.Size(32, 32);
            this.btnToogleMenu.HoverState.Parent = this.btnToogleMenu;
            this.btnToogleMenu.Image = global::Dev69Restaurant.Properties.Resources.menu_48px;
            this.btnToogleMenu.ImageSize = new System.Drawing.Size(32, 32);
            this.btnToogleMenu.Location = new System.Drawing.Point(49, 29);
            this.btnToogleMenu.Name = "btnToogleMenu";
            this.btnToogleMenu.PressedState.Parent = this.btnToogleMenu;
            this.btnToogleMenu.Size = new System.Drawing.Size(40, 44);
            this.btnToogleMenu.TabIndex = 10;
            this.btnToogleMenu.Click += new System.EventHandler(this.btnToogleMenu_Click);
            // 
            // pnDetail
            // 
            this.pnDetail.Controls.Add(this.grbDetail);
            this.gnTransition.SetDecoration(this.pnDetail, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pnDetail.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnDetail.Location = new System.Drawing.Point(1250, 138);
            this.pnDetail.Name = "pnDetail";
            this.pnDetail.Size = new System.Drawing.Size(350, 762);
            this.pnDetail.TabIndex = 14;
            // 
            // grbDetail
            // 
            this.grbDetail.BackColor = System.Drawing.Color.Transparent;
            this.grbDetail.BaseColor = System.Drawing.Color.White;
            this.grbDetail.BorderColor = System.Drawing.Color.Gainsboro;
            this.grbDetail.Controls.Add(this.panel1);
            this.gnTransition.SetDecoration(this.grbDetail, Guna.UI2.AnimatorNS.DecorationType.None);
            this.grbDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbDetail.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDetail.LineColor = System.Drawing.Color.Transparent;
            this.grbDetail.Location = new System.Drawing.Point(0, 0);
            this.grbDetail.Name = "grbDetail";
            this.grbDetail.Size = new System.Drawing.Size(350, 762);
            this.grbDetail.TabIndex = 0;
            this.grbDetail.Text = "Thông tin chi tiết";
            this.grbDetail.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCheckout);
            this.panel1.Controls.Add(this.gnSeparator2);
            this.panel1.Controls.Add(this.gnSeparator1);
            this.gnTransition.SetDecoration(this.panel1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 762);
            this.panel1.TabIndex = 1;
            // 
            // btnCheckout
            // 
            this.btnCheckout.BorderRadius = 8;
            this.btnCheckout.CheckedState.Parent = this.btnCheckout;
            this.btnCheckout.CustomImages.Parent = this.btnCheckout;
            this.gnTransition.SetDecoration(this.btnCheckout, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnCheckout.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCheckout.ForeColor = System.Drawing.Color.White;
            this.btnCheckout.HoverState.Parent = this.btnCheckout;
            this.btnCheckout.Location = new System.Drawing.Point(102, 654);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.ShadowDecoration.Parent = this.btnCheckout;
            this.btnCheckout.Size = new System.Drawing.Size(180, 45);
            this.btnCheckout.TabIndex = 0;
            this.btnCheckout.Text = "Thanh Toán";
            // 
            // gnSeparator2
            // 
            this.gnTransition.SetDecoration(this.gnSeparator2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.gnSeparator2.LineColor = System.Drawing.Color.Silver;
            this.gnSeparator2.Location = new System.Drawing.Point(3, 588);
            this.gnSeparator2.Name = "gnSeparator2";
            this.gnSeparator2.Size = new System.Drawing.Size(351, 10);
            this.gnSeparator2.TabIndex = 0;
            // 
            // gnSeparator1
            // 
            this.gnTransition.SetDecoration(this.gnSeparator1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.gnSeparator1.LineColor = System.Drawing.Color.Silver;
            this.gnSeparator1.Location = new System.Drawing.Point(-1, 48);
            this.gnSeparator1.Name = "gnSeparator1";
            this.gnSeparator1.Size = new System.Drawing.Size(351, 10);
            this.gnSeparator1.TabIndex = 0;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.pnFeature);
            this.panel8.Controls.Add(this.panel3);
            this.panel8.Controls.Add(this.panel2);
            this.gnTransition.SetDecoration(this.panel8, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(320, 138);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(930, 58);
            this.panel8.TabIndex = 15;
            // 
            // pnFeature
            // 
            this.pnFeature.BackColor = System.Drawing.Color.White;
            this.pnFeature.BorderRadius = 8;
            this.gnTransition.SetDecoration(this.pnFeature, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pnFeature.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnFeature.Location = new System.Drawing.Point(56, 0);
            this.pnFeature.Name = "pnFeature";
            this.pnFeature.ShadowDecoration.Parent = this.pnFeature;
            this.pnFeature.Size = new System.Drawing.Size(818, 58);
            this.pnFeature.TabIndex = 3;
            // 
            // panel3
            // 
            this.gnTransition.SetDecoration(this.panel3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(874, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(56, 58);
            this.panel3.TabIndex = 2;
            // 
            // panel2
            // 
            this.gnTransition.SetDecoration(this.panel2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(56, 58);
            this.panel2.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.pnMain);
            this.panel7.Controls.Add(this.panel6);
            this.panel7.Controls.Add(this.panel5);
            this.panel7.Controls.Add(this.panel4);
            this.gnTransition.SetDecoration(this.panel7, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(320, 196);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(930, 704);
            this.panel7.TabIndex = 16;
            // 
            // pnMain
            // 
            this.pnMain.BackColor = System.Drawing.Color.White;
            this.pnMain.BorderRadius = 8;
            this.pnMain.BorderThickness = 1;
            this.gnTransition.SetDecoration(this.pnMain, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMain.Location = new System.Drawing.Point(56, 49);
            this.pnMain.Name = "pnMain";
            this.pnMain.ShadowDecoration.Parent = this.pnMain;
            this.pnMain.Size = new System.Drawing.Size(818, 655);
            this.pnMain.TabIndex = 3;
            // 
            // panel6
            // 
            this.gnTransition.SetDecoration(this.panel6, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(56, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(818, 49);
            this.panel6.TabIndex = 2;
            // 
            // panel5
            // 
            this.gnTransition.SetDecoration(this.panel5, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(874, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(56, 704);
            this.panel5.TabIndex = 1;
            // 
            // panel4
            // 
            this.gnTransition.SetDecoration(this.panel4, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(56, 704);
            this.panel4.TabIndex = 0;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(1600, 900);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.pnDetail);
            this.Controls.Add(this.pnHeader);
            this.Controls.Add(this.pnTop);
            this.Controls.Add(this.pnLeft);
            this.gnTransition.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomeForm";
            this.pnTop.ResumeLayout(false);
            this.pnLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.pnHeader.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatarUser)).EndInit();
            this.pnDetail.ResumeLayout(false);
            this.grbDetail.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaControlBox btnMinimize;
        private Guna.UI.WinForms.GunaControlBox btnMaximize;
        private Guna.UI.WinForms.GunaControlBox btnClose;
        private Guna.UI.WinForms.GunaDragControl gnDragControl;
        private Guna.UI2.WinForms.Guna2GradientButton btnHome;
        private Guna.UI2.WinForms.Guna2GradientButton btnAbout;
        private Guna.UI2.WinForms.Guna2GradientButton btnStatistic;
        private Guna.UI2.WinForms.Guna2GradientButton btnTableFood;
        private Guna.UI2.WinForms.Guna2GradientButton btnFood;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2ImageButton btnToogleMenu;
        private Guna.UI2.WinForms.Guna2PictureBox picLogo;
        private Guna.UI.WinForms.GunaSeparator gnSeparate;
        private Guna.UI2.WinForms.Guna2GradientButton btnSetting;
        private Guna.UI2.WinForms.Guna2Transition gnTransition;
        private Guna.UI.WinForms.GunaPanel pnLeft;
        private Guna.UI2.WinForms.Guna2Panel pnTop;
        private Guna.UI.WinForms.GunaPanel pnHeader;
        private System.Windows.Forms.Panel pnDetail;
        private Guna.UI.WinForms.GunaPanel panel8;
        private Guna.UI.WinForms.GunaPanel panel7;
        private System.Windows.Forms.Label lblWelcome;
        private Guna.UI.WinForms.GunaCirclePictureBox picAvatarUser;
        private Guna.UI.WinForms.GunaGroupBox grbDetail;
        private Guna.UI.WinForms.GunaSeparator gnSeparator1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2GradientButton btnCheckout;
        private Guna.UI.WinForms.GunaSeparator gnSeparator2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Panel pnFeature;
        private Guna.UI2.WinForms.Guna2Panel pnMain;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel9;
    }
}