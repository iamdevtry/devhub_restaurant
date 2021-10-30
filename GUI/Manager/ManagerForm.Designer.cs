
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
            this.gnDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.btnMaximize = new Guna.UI.WinForms.GunaControlBox();
            this.btnMinimize = new Guna.UI.WinForms.GunaControlBox();
            this.btnClose = new Guna.UI.WinForms.GunaControlBox();
            this.pnLeft = new Guna.UI.WinForms.GunaPanel();
            this.picLogo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnBill = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnRevenue = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnTableFood = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnDiscount = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnManageStaff = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnFood = new Guna.UI2.WinForms.Guna2GradientButton();
            this.pnTop = new System.Windows.Forms.Panel();
            this.pnMain = new System.Windows.Forms.Panel();
            this.dragForm = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.pnLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.pnTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // gnDragControl1
            // 
            this.gnDragControl1.TargetControl = this.pnTop;
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.AnimationHoverSpeed = 0.07F;
            this.btnMaximize.AnimationSpeed = 0.03F;
            this.btnMaximize.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MaximizeBox;
            this.btnMaximize.IconColor = System.Drawing.Color.Black;
            this.btnMaximize.IconSize = 15F;
            this.btnMaximize.Location = new System.Drawing.Point(1160, 5);
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
            this.btnMinimize.Location = new System.Drawing.Point(1109, 5);
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
            this.btnClose.Location = new System.Drawing.Point(1211, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.btnClose.OnHoverIconColor = System.Drawing.Color.White;
            this.btnClose.OnPressedColor = System.Drawing.Color.Black;
            this.btnClose.Size = new System.Drawing.Size(45, 30);
            this.btnClose.TabIndex = 0;
            // 
            // pnLeft
            // 
            this.pnLeft.BackColor = System.Drawing.Color.White;
            this.pnLeft.Controls.Add(this.picLogo);
            this.pnLeft.Controls.Add(this.btnBill);
            this.pnLeft.Controls.Add(this.btnRevenue);
            this.pnLeft.Controls.Add(this.btnTableFood);
            this.pnLeft.Controls.Add(this.btnDiscount);
            this.pnLeft.Controls.Add(this.btnManageStaff);
            this.pnLeft.Controls.Add(this.btnFood);
            this.pnLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnLeft.Location = new System.Drawing.Point(0, 0);
            this.pnLeft.Name = "pnLeft";
            this.pnLeft.Size = new System.Drawing.Size(332, 900);
            this.pnLeft.TabIndex = 14;
            // 
            // picLogo
            // 
            this.picLogo.Image = global::Dev69Restaurant.Properties.Resources.banner_Logo_Dark;
            this.picLogo.Location = new System.Drawing.Point(11, 38);
            this.picLogo.Name = "picLogo";
            this.picLogo.ShadowDecoration.Parent = this.picLogo;
            this.picLogo.Size = new System.Drawing.Size(315, 100);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 9;
            this.picLogo.TabStop = false;
            // 
            // btnBill
            // 
            this.btnBill.BorderRadius = 8;
            this.btnBill.CheckedState.Parent = this.btnBill;
            this.btnBill.CustomImages.CheckedImage = global::Dev69Restaurant.Properties.Resources.revenue_48px;
            this.btnBill.CustomImages.HoveredImage = global::Dev69Restaurant.Properties.Resources.revenue_hover_48px;
            this.btnBill.CustomImages.Image = global::Dev69Restaurant.Properties.Resources.revenue_48px;
            this.btnBill.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnBill.CustomImages.ImageSize = new System.Drawing.Size(32, 32);
            this.btnBill.CustomImages.Parent = this.btnBill;
            this.btnBill.FillColor = System.Drawing.Color.White;
            this.btnBill.FillColor2 = System.Drawing.Color.White;
            this.btnBill.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBill.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBill.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(235)))), ((int)(((byte)(237)))));
            this.btnBill.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(235)))), ((int)(((byte)(237)))));
            this.btnBill.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(165)))));
            this.btnBill.HoverState.Parent = this.btnBill;
            this.btnBill.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnBill.Location = new System.Drawing.Point(11, 232);
            this.btnBill.Name = "btnBill";
            this.btnBill.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(217)))), ((int)(((byte)(220)))));
            this.btnBill.PressedDepth = 100;
            this.btnBill.ShadowDecoration.Parent = this.btnBill;
            this.btnBill.Size = new System.Drawing.Size(275, 50);
            this.btnBill.TabIndex = 6;
            this.btnBill.Text = "Thống kê";
            this.btnBill.Click += new System.EventHandler(this.btnBill_Click);
            // 
            // btnRevenue
            // 
            this.btnRevenue.BorderRadius = 8;
            this.btnRevenue.CheckedState.Parent = this.btnRevenue;
            this.btnRevenue.CustomImages.CheckedImage = global::Dev69Restaurant.Properties.Resources.bar_chart_48px;
            this.btnRevenue.CustomImages.HoveredImage = global::Dev69Restaurant.Properties.Resources.bar_chart_hover_48px;
            this.btnRevenue.CustomImages.Image = global::Dev69Restaurant.Properties.Resources.bar_chart_48px;
            this.btnRevenue.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnRevenue.CustomImages.ImageSize = new System.Drawing.Size(32, 32);
            this.btnRevenue.CustomImages.Parent = this.btnRevenue;
            this.btnRevenue.FillColor = System.Drawing.Color.White;
            this.btnRevenue.FillColor2 = System.Drawing.Color.White;
            this.btnRevenue.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRevenue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRevenue.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(235)))), ((int)(((byte)(237)))));
            this.btnRevenue.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(235)))), ((int)(((byte)(237)))));
            this.btnRevenue.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(165)))));
            this.btnRevenue.HoverState.Parent = this.btnRevenue;
            this.btnRevenue.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnRevenue.Location = new System.Drawing.Point(12, 165);
            this.btnRevenue.Name = "btnRevenue";
            this.btnRevenue.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(217)))), ((int)(((byte)(220)))));
            this.btnRevenue.PressedDepth = 100;
            this.btnRevenue.ShadowDecoration.Parent = this.btnRevenue;
            this.btnRevenue.Size = new System.Drawing.Size(275, 50);
            this.btnRevenue.TabIndex = 6;
            this.btnRevenue.Text = "Tổng quan";
            this.btnRevenue.Click += new System.EventHandler(this.btnRevenue_Click);
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
            this.btnTableFood.Location = new System.Drawing.Point(12, 302);
            this.btnTableFood.Margin = new System.Windows.Forms.Padding(3, 3, 15, 3);
            this.btnTableFood.Name = "btnTableFood";
            this.btnTableFood.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(217)))), ((int)(((byte)(220)))));
            this.btnTableFood.PressedDepth = 100;
            this.btnTableFood.ShadowDecoration.Parent = this.btnTableFood;
            this.btnTableFood.Size = new System.Drawing.Size(275, 50);
            this.btnTableFood.TabIndex = 6;
            this.btnTableFood.Text = "Quản lý bàn ăn";
            this.btnTableFood.Click += new System.EventHandler(this.btnTableFood_Click);
            // 
            // btnDiscount
            // 
            this.btnDiscount.BorderRadius = 8;
            this.btnDiscount.CheckedState.Parent = this.btnDiscount;
            this.btnDiscount.CustomImages.CheckedImage = global::Dev69Restaurant.Properties.Resources.discount_48px;
            this.btnDiscount.CustomImages.HoveredImage = global::Dev69Restaurant.Properties.Resources.discount_hover_48px;
            this.btnDiscount.CustomImages.Image = global::Dev69Restaurant.Properties.Resources.discount_48px;
            this.btnDiscount.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDiscount.CustomImages.ImageSize = new System.Drawing.Size(32, 32);
            this.btnDiscount.CustomImages.Parent = this.btnDiscount;
            this.btnDiscount.FillColor = System.Drawing.Color.White;
            this.btnDiscount.FillColor2 = System.Drawing.Color.White;
            this.btnDiscount.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiscount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDiscount.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(235)))), ((int)(((byte)(237)))));
            this.btnDiscount.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(235)))), ((int)(((byte)(237)))));
            this.btnDiscount.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(165)))));
            this.btnDiscount.HoverState.Parent = this.btnDiscount;
            this.btnDiscount.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDiscount.Location = new System.Drawing.Point(12, 544);
            this.btnDiscount.Name = "btnDiscount";
            this.btnDiscount.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(217)))), ((int)(((byte)(220)))));
            this.btnDiscount.PressedDepth = 100;
            this.btnDiscount.ShadowDecoration.Parent = this.btnDiscount;
            this.btnDiscount.Size = new System.Drawing.Size(275, 50);
            this.btnDiscount.TabIndex = 6;
            this.btnDiscount.Text = "Mã giảm giá";
            this.btnDiscount.Click += new System.EventHandler(this.btnDiscount_Click);
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
            this.btnManageStaff.Location = new System.Drawing.Point(12, 466);
            this.btnManageStaff.Name = "btnManageStaff";
            this.btnManageStaff.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(217)))), ((int)(((byte)(220)))));
            this.btnManageStaff.PressedDepth = 100;
            this.btnManageStaff.ShadowDecoration.Parent = this.btnManageStaff;
            this.btnManageStaff.Size = new System.Drawing.Size(275, 50);
            this.btnManageStaff.TabIndex = 6;
            this.btnManageStaff.Text = "Quản lý nhân viên";
            this.btnManageStaff.Click += new System.EventHandler(this.btnManageStaff_Click);
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
            this.btnFood.Location = new System.Drawing.Point(12, 384);
            this.btnFood.Name = "btnFood";
            this.btnFood.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(217)))), ((int)(((byte)(220)))));
            this.btnFood.PressedDepth = 100;
            this.btnFood.ShadowDecoration.Parent = this.btnFood;
            this.btnFood.Size = new System.Drawing.Size(275, 50);
            this.btnFood.TabIndex = 6;
            this.btnFood.Text = "Quản lý món ";
            this.btnFood.Click += new System.EventHandler(this.btnFood_Click);
            // 
            // pnTop
            // 
            this.pnTop.Controls.Add(this.btnClose);
            this.pnTop.Controls.Add(this.btnMaximize);
            this.pnTop.Controls.Add(this.btnMinimize);
            this.pnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTop.Location = new System.Drawing.Point(332, 0);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(1268, 38);
            this.pnTop.TabIndex = 16;
            // 
            // pnMain
            // 
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMain.Location = new System.Drawing.Point(332, 38);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(1268, 862);
            this.pnMain.TabIndex = 17;
            // 
            // dragForm
            // 
            this.dragForm.TargetControl = this.pnLeft;
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(1600, 900);
            this.Controls.Add(this.pnMain);
            this.Controls.Add(this.pnTop);
            this.Controls.Add(this.pnLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManagerForm";
            this.Text = "Quản trị";
            this.pnLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.pnTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaDragControl gnDragControl1;
        private Guna.UI.WinForms.GunaControlBox btnClose;
        private Guna.UI.WinForms.GunaControlBox btnMinimize;
        private Guna.UI.WinForms.GunaControlBox btnMaximize;
        private Guna.UI.WinForms.GunaPanel pnLeft;
        private Guna.UI2.WinForms.Guna2GradientButton btnRevenue;
        private Guna.UI2.WinForms.Guna2GradientButton btnTableFood;
        private Guna.UI2.WinForms.Guna2GradientButton btnDiscount;
        private Guna.UI2.WinForms.Guna2GradientButton btnManageStaff;
        private Guna.UI2.WinForms.Guna2GradientButton btnFood;
        private System.Windows.Forms.Panel pnMain;
        private System.Windows.Forms.Panel pnTop;
        private Guna.UI2.WinForms.Guna2PictureBox picLogo;
        private Guna.UI2.WinForms.Guna2GradientButton btnBill;
        private Guna.UI.WinForms.GunaDragControl dragForm;
    }
}