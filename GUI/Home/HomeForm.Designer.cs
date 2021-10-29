
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
            Guna.UI2.AnimatorNS.Animation animation2 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.btnHome = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnAbout = new Guna.UI2.WinForms.Guna2GradientButton();
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
            this.panel10 = new System.Windows.Forms.Panel();
            this.btnManage = new Guna.UI2.WinForms.Guna2GradientButton();
            this.picLogo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pnHeader = new Guna.UI.WinForms.GunaPanel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btnUser = new Guna.UI.WinForms.GunaImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDisplayName = new System.Windows.Forms.Label();
            this.picAvatarUser = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.btnToogleMenu = new Guna.UI2.WinForms.Guna2ImageButton();
            this.pnDetail = new System.Windows.Forms.Panel();
            this.grbDetail = new Guna.UI.WinForms.GunaGroupBox();
            this.pnRight = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.ckbExportBill = new System.Windows.Forms.CheckBox();
            this.txtDiscount = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTotalPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gnSeparator2 = new Guna.UI.WinForms.GunaSeparator();
            this.btnCheckout = new Guna.UI2.WinForms.Guna2GradientButton();
            this.pnDetailHeader = new Guna.UI.WinForms.GunaGradient2Panel();
            this.lblDetailTableName = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.pnBillDetail = new System.Windows.Forms.FlowLayoutPanel();
            this.panel8 = new Guna.UI.WinForms.GunaPanel();
            this.pnFeature = new Guna.UI2.WinForms.Guna2Panel();
            this.cbCategoryFood = new Guna.UI.WinForms.GunaComboBox();
            this.lblFoodCategory = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel7 = new Guna.UI.WinForms.GunaPanel();
            this.pnMain = new Guna.UI2.WinForms.Guna2Panel();
            this.gnElipsePnFeature = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.gnElipsePnMain = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pnTop.SuspendLayout();
            this.pnLeft.SuspendLayout();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.pnHeader.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatarUser)).BeginInit();
            this.pnDetail.SuspendLayout();
            this.grbDetail.SuspendLayout();
            this.pnRight.SuspendLayout();
            this.panel11.SuspendLayout();
            this.pnDetailHeader.SuspendLayout();
            this.panel8.SuspendLayout();
            this.pnFeature.SuspendLayout();
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
            this.btnHome.Text = "Trang chính";
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
            this.btnAbout.Location = new System.Drawing.Point(14, 87);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(217)))), ((int)(((byte)(220)))));
            this.btnAbout.PressedDepth = 100;
            this.btnAbout.ShadowDecoration.Parent = this.btnAbout;
            this.btnAbout.Size = new System.Drawing.Size(275, 50);
            this.btnAbout.TabIndex = 6;
            this.btnAbout.Text = "About";
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnFood
            // 
            this.btnFood.BackColor = System.Drawing.Color.White;
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
            this.btnFood.Location = new System.Drawing.Point(14, 414);
            this.btnFood.Name = "btnFood";
            this.btnFood.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(217)))), ((int)(((byte)(220)))));
            this.btnFood.PressedDepth = 100;
            this.btnFood.ShadowDecoration.Parent = this.btnFood;
            this.btnFood.Size = new System.Drawing.Size(275, 50);
            this.btnFood.TabIndex = 6;
            this.btnFood.Text = "Món ăn";
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
            this.btnTableFood.Location = new System.Drawing.Point(14, 340);
            this.btnTableFood.Margin = new System.Windows.Forms.Padding(3, 3, 15, 3);
            this.btnTableFood.Name = "btnTableFood";
            this.btnTableFood.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(217)))), ((int)(((byte)(220)))));
            this.btnTableFood.PressedDepth = 100;
            this.btnTableFood.ShadowDecoration.Parent = this.btnTableFood;
            this.btnTableFood.Size = new System.Drawing.Size(275, 50);
            this.btnTableFood.TabIndex = 6;
            this.btnTableFood.Text = "Bàn ăn";
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
            this.btnMinimize.Location = new System.Drawing.Point(1122, 4);
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
            this.btnMaximize.Location = new System.Drawing.Point(1173, 4);
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
            this.btnClose.Location = new System.Drawing.Point(1224, 4);
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
            this.pnTop.Location = new System.Drawing.Point(314, 0);
            this.pnTop.Name = "pnTop";
            this.pnTop.ShadowDecoration.Parent = this.pnTop;
            this.pnTop.Size = new System.Drawing.Size(1286, 38);
            this.pnTop.TabIndex = 12;
            // 
            // gnSeparate
            // 
            this.gnTransition.SetDecoration(this.gnSeparate, Guna.UI2.AnimatorNS.DecorationType.None);
            this.gnSeparate.LineColor = System.Drawing.Color.Silver;
            this.gnSeparate.Location = new System.Drawing.Point(3, 3);
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
            this.btnSetting.Location = new System.Drawing.Point(14, 19);
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
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.gnTransition.DefaultAnimation = animation2;
            // 
            // pnLeft
            // 
            this.pnLeft.BackColor = System.Drawing.Color.White;
            this.pnLeft.Controls.Add(this.panel10);
            this.pnLeft.Controls.Add(this.btnHome);
            this.pnLeft.Controls.Add(this.btnFood);
            this.pnLeft.Controls.Add(this.btnManage);
            this.pnLeft.Controls.Add(this.picLogo);
            this.pnLeft.Controls.Add(this.btnTableFood);
            this.gnTransition.SetDecoration(this.pnLeft, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pnLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnLeft.Location = new System.Drawing.Point(0, 0);
            this.pnLeft.Name = "pnLeft";
            this.pnLeft.Size = new System.Drawing.Size(314, 900);
            this.pnLeft.TabIndex = 11;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.btnSetting);
            this.panel10.Controls.Add(this.btnAbout);
            this.panel10.Controls.Add(this.gnSeparate);
            this.gnTransition.SetDecoration(this.panel10, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel10.Location = new System.Drawing.Point(0, 742);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(314, 158);
            this.panel10.TabIndex = 9;
            // 
            // btnManage
            // 
            this.btnManage.BorderRadius = 8;
            this.btnManage.CheckedState.Parent = this.btnManage;
            this.btnManage.CustomImages.CheckedImage = global::Dev69Restaurant.Properties.Resources.user_group_48px;
            this.btnManage.CustomImages.HoveredImage = global::Dev69Restaurant.Properties.Resources.user_group_hover_48px;
            this.btnManage.CustomImages.Image = global::Dev69Restaurant.Properties.Resources.user_group_48px;
            this.btnManage.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnManage.CustomImages.ImageSize = new System.Drawing.Size(32, 32);
            this.btnManage.CustomImages.Parent = this.btnManage;
            this.gnTransition.SetDecoration(this.btnManage, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnManage.FillColor = System.Drawing.Color.White;
            this.btnManage.FillColor2 = System.Drawing.Color.White;
            this.btnManage.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnManage.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(235)))), ((int)(((byte)(237)))));
            this.btnManage.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(235)))), ((int)(((byte)(237)))));
            this.btnManage.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(165)))));
            this.btnManage.HoverState.Parent = this.btnManage;
            this.btnManage.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnManage.Location = new System.Drawing.Point(14, 488);
            this.btnManage.Name = "btnManage";
            this.btnManage.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(217)))), ((int)(((byte)(220)))));
            this.btnManage.PressedDepth = 100;
            this.btnManage.ShadowDecoration.Parent = this.btnManage;
            this.btnManage.Size = new System.Drawing.Size(275, 50);
            this.btnManage.TabIndex = 6;
            this.btnManage.Text = "Quản lý ";
            this.btnManage.Click += new System.EventHandler(this.btnManageUser_Click);
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
            this.pnHeader.Controls.Add(this.btnToogleMenu);
            this.gnTransition.SetDecoration(this.pnHeader, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pnHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnHeader.Location = new System.Drawing.Point(314, 38);
            this.pnHeader.Name = "pnHeader";
            this.pnHeader.Size = new System.Drawing.Size(1286, 100);
            this.pnHeader.TabIndex = 13;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.btnUser);
            this.panel9.Controls.Add(this.label1);
            this.panel9.Controls.Add(this.lblDisplayName);
            this.panel9.Controls.Add(this.picAvatarUser);
            this.gnTransition.SetDecoration(this.panel9, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel9.Location = new System.Drawing.Point(886, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(400, 100);
            this.panel9.TabIndex = 11;
            // 
            // btnUser
            // 
            this.btnUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.gnTransition.SetDecoration(this.btnUser, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnUser.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnUser.Image = global::Dev69Restaurant.Properties.Resources.expand_arrow_defaut_48px;
            this.btnUser.ImageSize = new System.Drawing.Size(24, 24);
            this.btnUser.Location = new System.Drawing.Point(323, 41);
            this.btnUser.Name = "btnUser";
            this.btnUser.OnHoverImage = global::Dev69Restaurant.Properties.Resources.expand_arrow_48px;
            this.btnUser.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.btnUser.Size = new System.Drawing.Size(24, 24);
            this.btnUser.TabIndex = 12;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.gnTransition.SetDecoration(this.label1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Xin chào:";
            // 
            // lblDisplayName
            // 
            this.lblDisplayName.AutoSize = true;
            this.gnTransition.SetDecoration(this.lblDisplayName, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblDisplayName.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayName.Location = new System.Drawing.Point(89, 50);
            this.lblDisplayName.Name = "lblDisplayName";
            this.lblDisplayName.Size = new System.Drawing.Size(80, 23);
            this.lblDisplayName.TabIndex = 0;
            this.lblDisplayName.Text = "Dev69... !";
            // 
            // picAvatarUser
            // 
            this.picAvatarUser.BaseColor = System.Drawing.Color.White;
            this.gnTransition.SetDecoration(this.picAvatarUser, Guna.UI2.AnimatorNS.DecorationType.None);
            this.picAvatarUser.Image = global::Dev69Restaurant.Properties.Resources.user_50px;
            this.picAvatarUser.Location = new System.Drawing.Point(233, 20);
            this.picAvatarUser.Name = "picAvatarUser";
            this.picAvatarUser.Size = new System.Drawing.Size(64, 64);
            this.picAvatarUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAvatarUser.TabIndex = 11;
            this.picAvatarUser.TabStop = false;
            this.picAvatarUser.UseTransfarantBackground = false;
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
            this.btnToogleMenu.Location = new System.Drawing.Point(30, 29);
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
            this.pnDetail.Location = new System.Drawing.Point(1200, 138);
            this.pnDetail.Name = "pnDetail";
            this.pnDetail.Size = new System.Drawing.Size(400, 762);
            this.pnDetail.TabIndex = 14;
            // 
            // grbDetail
            // 
            this.grbDetail.BackColor = System.Drawing.Color.Transparent;
            this.grbDetail.BaseColor = System.Drawing.Color.White;
            this.grbDetail.BorderColor = System.Drawing.Color.Gainsboro;
            this.grbDetail.Controls.Add(this.pnRight);
            this.gnTransition.SetDecoration(this.grbDetail, Guna.UI2.AnimatorNS.DecorationType.None);
            this.grbDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbDetail.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDetail.LineColor = System.Drawing.Color.Transparent;
            this.grbDetail.Location = new System.Drawing.Point(0, 0);
            this.grbDetail.Name = "grbDetail";
            this.grbDetail.Size = new System.Drawing.Size(400, 762);
            this.grbDetail.TabIndex = 0;
            this.grbDetail.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // pnRight
            // 
            this.pnRight.Controls.Add(this.panel11);
            this.pnRight.Controls.Add(this.pnDetailHeader);
            this.pnRight.Controls.Add(this.pnBillDetail);
            this.gnTransition.SetDecoration(this.pnRight, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pnRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnRight.Location = new System.Drawing.Point(0, 0);
            this.pnRight.Name = "pnRight";
            this.pnRight.Size = new System.Drawing.Size(400, 762);
            this.pnRight.TabIndex = 1;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.ckbExportBill);
            this.panel11.Controls.Add(this.txtDiscount);
            this.panel11.Controls.Add(this.txtTotalPrice);
            this.panel11.Controls.Add(this.gunaLabel3);
            this.panel11.Controls.Add(this.gunaLabel1);
            this.panel11.Controls.Add(this.gnSeparator2);
            this.panel11.Controls.Add(this.btnCheckout);
            this.gnTransition.SetDecoration(this.panel11, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel11.Location = new System.Drawing.Point(0, 453);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(400, 309);
            this.panel11.TabIndex = 1;
            // 
            // ckbExportBill
            // 
            this.ckbExportBill.AutoSize = true;
            this.ckbExportBill.Checked = true;
            this.ckbExportBill.CheckState = System.Windows.Forms.CheckState.Checked;
            this.gnTransition.SetDecoration(this.ckbExportBill, Guna.UI2.AnimatorNS.DecorationType.None);
            this.ckbExportBill.Location = new System.Drawing.Point(196, 197);
            this.ckbExportBill.Name = "ckbExportBill";
            this.ckbExportBill.Size = new System.Drawing.Size(136, 27);
            this.ckbExportBill.TabIndex = 4;
            this.ckbExportBill.Text = "Xuất hóa đơn";
            this.ckbExportBill.UseVisualStyleBackColor = true;
            // 
            // txtDiscount
            // 
            this.txtDiscount.BorderRadius = 8;
            this.txtDiscount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gnTransition.SetDecoration(this.txtDiscount, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txtDiscount.DefaultText = "";
            this.txtDiscount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDiscount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDiscount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiscount.DisabledState.Parent = this.txtDiscount;
            this.txtDiscount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiscount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiscount.FocusedState.Parent = this.txtDiscount;
            this.txtDiscount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiscount.HoverState.Parent = this.txtDiscount;
            this.txtDiscount.Location = new System.Drawing.Point(69, 57);
            this.txtDiscount.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.PasswordChar = '\0';
            this.txtDiscount.PlaceholderText = "Nhập mã giảm giá";
            this.txtDiscount.SelectedText = "";
            this.txtDiscount.ShadowDecoration.Parent = this.txtDiscount;
            this.txtDiscount.Size = new System.Drawing.Size(263, 44);
            this.txtDiscount.TabIndex = 3;
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.BorderRadius = 8;
            this.txtTotalPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gnTransition.SetDecoration(this.txtTotalPrice, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txtTotalPrice.DefaultText = "";
            this.txtTotalPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTotalPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTotalPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotalPrice.DisabledState.Parent = this.txtTotalPrice;
            this.txtTotalPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotalPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotalPrice.FocusedState.Parent = this.txtTotalPrice;
            this.txtTotalPrice.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPrice.ForeColor = System.Drawing.Color.Black;
            this.txtTotalPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotalPrice.HoverState.Parent = this.txtTotalPrice;
            this.txtTotalPrice.Location = new System.Drawing.Point(69, 144);
            this.txtTotalPrice.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.PasswordChar = '\0';
            this.txtTotalPrice.PlaceholderText = "";
            this.txtTotalPrice.ReadOnly = true;
            this.txtTotalPrice.SelectedText = "";
            this.txtTotalPrice.ShadowDecoration.Parent = this.txtTotalPrice;
            this.txtTotalPrice.Size = new System.Drawing.Size(263, 44);
            this.txtTotalPrice.TabIndex = 2;
            this.txtTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gnTransition.SetDecoration(this.gunaLabel3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel3.Location = new System.Drawing.Point(20, 24);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(93, 20);
            this.gunaLabel3.TabIndex = 1;
            this.gunaLabel3.Text = "Mã giảm giá";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gnTransition.SetDecoration(this.gunaLabel1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel1.Location = new System.Drawing.Point(20, 118);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(78, 20);
            this.gunaLabel1.TabIndex = 1;
            this.gunaLabel1.Text = "Thành tiền";
            // 
            // gnSeparator2
            // 
            this.gnTransition.SetDecoration(this.gnSeparator2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.gnSeparator2.LineColor = System.Drawing.Color.Silver;
            this.gnSeparator2.Location = new System.Drawing.Point(3, 11);
            this.gnSeparator2.Name = "gnSeparator2";
            this.gnSeparator2.Size = new System.Drawing.Size(394, 10);
            this.gnSeparator2.TabIndex = 0;
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
            this.btnCheckout.Location = new System.Drawing.Point(117, 234);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.ShadowDecoration.Parent = this.btnCheckout;
            this.btnCheckout.Size = new System.Drawing.Size(180, 45);
            this.btnCheckout.TabIndex = 0;
            this.btnCheckout.Text = "Thanh Toán";
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // pnDetailHeader
            // 
            this.pnDetailHeader.BackColor = System.Drawing.Color.Transparent;
            this.pnDetailHeader.Controls.Add(this.lblDetailTableName);
            this.pnDetailHeader.Controls.Add(this.gunaLabel2);
            this.gnTransition.SetDecoration(this.pnDetailHeader, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pnDetailHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnDetailHeader.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(170)))), ((int)(((byte)(229)))));
            this.pnDetailHeader.GradientColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(165)))));
            this.pnDetailHeader.Location = new System.Drawing.Point(0, 0);
            this.pnDetailHeader.Name = "pnDetailHeader";
            this.pnDetailHeader.Radius = 8;
            this.pnDetailHeader.Size = new System.Drawing.Size(400, 58);
            this.pnDetailHeader.TabIndex = 4;
            // 
            // lblDetailTableName
            // 
            this.lblDetailTableName.AutoSize = true;
            this.gnTransition.SetDecoration(this.lblDetailTableName, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblDetailTableName.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetailTableName.Location = new System.Drawing.Point(163, 15);
            this.lblDetailTableName.Name = "lblDetailTableName";
            this.lblDetailTableName.Size = new System.Drawing.Size(88, 25);
            this.lblDetailTableName.TabIndex = 0;
            this.lblDetailTableName.Text = "Bàn số ...";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gnTransition.SetDecoration(this.gunaLabel2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel2.Location = new System.Drawing.Point(20, 20);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(118, 20);
            this.gunaLabel2.TabIndex = 0;
            this.gunaLabel2.Text = "Chi tiết hóa đơn:";
            // 
            // pnBillDetail
            // 
            this.pnBillDetail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnBillDetail.AutoScroll = true;
            this.gnTransition.SetDecoration(this.pnBillDetail, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pnBillDetail.Location = new System.Drawing.Point(0, 58);
            this.pnBillDetail.Name = "pnBillDetail";
            this.pnBillDetail.Size = new System.Drawing.Size(400, 389);
            this.pnBillDetail.TabIndex = 5;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.pnFeature);
            this.panel8.Controls.Add(this.panel3);
            this.panel8.Controls.Add(this.panel2);
            this.gnTransition.SetDecoration(this.panel8, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(314, 138);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(886, 58);
            this.panel8.TabIndex = 15;
            // 
            // pnFeature
            // 
            this.pnFeature.BackColor = System.Drawing.Color.White;
            this.pnFeature.BorderRadius = 8;
            this.pnFeature.Controls.Add(this.cbCategoryFood);
            this.pnFeature.Controls.Add(this.lblFoodCategory);
            this.gnTransition.SetDecoration(this.pnFeature, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pnFeature.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnFeature.Location = new System.Drawing.Point(30, 0);
            this.pnFeature.Name = "pnFeature";
            this.pnFeature.ShadowDecoration.Parent = this.pnFeature;
            this.pnFeature.Size = new System.Drawing.Size(826, 58);
            this.pnFeature.TabIndex = 3;
            // 
            // cbCategoryFood
            // 
            this.cbCategoryFood.BackColor = System.Drawing.Color.Transparent;
            this.cbCategoryFood.BaseColor = System.Drawing.Color.White;
            this.cbCategoryFood.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.cbCategoryFood.BorderSize = 1;
            this.gnTransition.SetDecoration(this.cbCategoryFood, Guna.UI2.AnimatorNS.DecorationType.None);
            this.cbCategoryFood.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbCategoryFood.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoryFood.FocusedColor = System.Drawing.Color.Empty;
            this.cbCategoryFood.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbCategoryFood.ForeColor = System.Drawing.Color.Black;
            this.cbCategoryFood.FormattingEnabled = true;
            this.cbCategoryFood.Items.AddRange(new object[] {
            "Tất cả"});
            this.cbCategoryFood.Location = new System.Drawing.Point(190, 15);
            this.cbCategoryFood.Name = "cbCategoryFood";
            this.cbCategoryFood.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbCategoryFood.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbCategoryFood.Radius = 8;
            this.cbCategoryFood.Size = new System.Drawing.Size(259, 31);
            this.cbCategoryFood.TabIndex = 0;
            this.cbCategoryFood.Visible = false;
            this.cbCategoryFood.SelectedValueChanged += new System.EventHandler(this.cbCategoryFood_SelectedValueChanged);
            // 
            // lblFoodCategory
            // 
            this.lblFoodCategory.AutoSize = true;
            this.gnTransition.SetDecoration(this.lblFoodCategory, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblFoodCategory.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFoodCategory.Location = new System.Drawing.Point(6, 19);
            this.lblFoodCategory.Name = "lblFoodCategory";
            this.lblFoodCategory.Size = new System.Drawing.Size(157, 23);
            this.lblFoodCategory.TabIndex = 0;
            this.lblFoodCategory.Text = "Danh mục thức ăn:";
            this.lblFoodCategory.Visible = false;
            // 
            // panel3
            // 
            this.gnTransition.SetDecoration(this.panel3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(856, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(30, 58);
            this.panel3.TabIndex = 2;
            // 
            // panel2
            // 
            this.gnTransition.SetDecoration(this.panel2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(30, 58);
            this.panel2.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.pnMain);
            this.gnTransition.SetDecoration(this.panel7, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(314, 196);
            this.panel7.Name = "panel7";
            this.panel7.Padding = new System.Windows.Forms.Padding(30);
            this.panel7.Size = new System.Drawing.Size(886, 704);
            this.panel7.TabIndex = 16;
            // 
            // pnMain
            // 
            this.pnMain.BackColor = System.Drawing.Color.White;
            this.pnMain.BorderRadius = 8;
            this.pnMain.BorderThickness = 1;
            this.gnTransition.SetDecoration(this.pnMain, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMain.Location = new System.Drawing.Point(30, 30);
            this.pnMain.Name = "pnMain";
            this.pnMain.ShadowDecoration.Parent = this.pnMain;
            this.pnMain.Size = new System.Drawing.Size(826, 644);
            this.pnMain.TabIndex = 4;
            // 
            // gnElipsePnFeature
            // 
            this.gnElipsePnFeature.BorderRadius = 8;
            this.gnElipsePnFeature.TargetControl = this.pnFeature;
            // 
            // gnElipsePnMain
            // 
            this.gnElipsePnMain.BorderRadius = 8;
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
            this.Load += new System.EventHandler(this.HomeForm_Load);
            this.pnTop.ResumeLayout(false);
            this.pnLeft.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.pnHeader.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatarUser)).EndInit();
            this.pnDetail.ResumeLayout(false);
            this.grbDetail.ResumeLayout(false);
            this.pnRight.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.pnDetailHeader.ResumeLayout(false);
            this.pnDetailHeader.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.pnFeature.ResumeLayout(false);
            this.pnFeature.PerformLayout();
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
        private Guna.UI2.WinForms.Guna2GradientButton btnTableFood;
        private Guna.UI2.WinForms.Guna2GradientButton btnFood;
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
        private System.Windows.Forms.Label lblDisplayName;
        private Guna.UI.WinForms.GunaCirclePictureBox picAvatarUser;
        private Guna.UI.WinForms.GunaGroupBox grbDetail;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Panel pnFeature;
        private System.Windows.Forms.Panel panel9;
        private Guna.UI2.WinForms.Guna2GradientButton btnManage;
        private Guna.UI2.WinForms.Guna2Elipse gnElipsePnFeature;
        private Guna.UI2.WinForms.Guna2Elipse gnElipsePnMain;
        private System.Windows.Forms.Panel pnRight;
        private Guna.UI2.WinForms.Guna2GradientButton btnCheckout;
        private Guna.UI.WinForms.GunaSeparator gnSeparator2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel11;
        private Guna.UI.WinForms.GunaGradient2Panel pnDetailHeader;
        private System.Windows.Forms.FlowLayoutPanel pnBillDetail;
        private Guna.UI2.WinForms.Guna2Panel pnMain;
        private Guna.UI2.WinForms.Guna2TextBox txtTotalPrice;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel lblDetailTableName;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaImageButton btnUser;
        private Guna.UI.WinForms.GunaComboBox cbCategoryFood;
        private System.Windows.Forms.Label lblFoodCategory;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI2.WinForms.Guna2TextBox txtDiscount;
        private System.Windows.Forms.CheckBox ckbExportBill;
    }
}