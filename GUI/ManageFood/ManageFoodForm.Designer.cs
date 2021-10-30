
namespace Dev69Restaurant.GUI.ManageFood
{
    partial class ManageFoodForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lblManageCate = new System.Windows.Forms.LinkLabel();
            this.picAvatar = new Guna.UI.WinForms.GunaPictureBox();
            this.btnChangeAvatar = new Guna.UI.WinForms.GunaPictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.optHidden = new System.Windows.Forms.RadioButton();
            this.optDisplay = new System.Windows.Forms.RadioButton();
            this.txtPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtName = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmbFoodCategory = new Guna.UI.WinForms.GunaComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.gunaShadowPanel1 = new Guna.UI.WinForms.GunaShadowPanel();
            this.dgvListFood = new Guna.UI2.WinForms.Guna2DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FoodName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FoodId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnChangeAvatar)).BeginInit();
            this.gunaShadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListFood)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1280, 87);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnSearch);
            this.panel3.Controls.Add(this.txtSearch);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(745, 87);
            this.panel3.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.BorderRadius = 8;
            this.btnSearch.CheckedState.Parent = this.btnSearch;
            this.btnSearch.CustomImages.Parent = this.btnSearch;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.HoverState.Parent = this.btnSearch;
            this.btnSearch.Location = new System.Drawing.Point(519, 17);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.ShadowDecoration.Parent = this.btnSearch;
            this.btnSearch.Size = new System.Drawing.Size(138, 45);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BorderRadius = 8;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.Parent = this.txtSearch;
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.FocusedState.Parent = this.txtSearch;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.HoverState.Parent = this.txtSearch;
            this.txtSearch.IconLeft = global::Dev69Restaurant.Properties.Resources.search_24px;
            this.txtSearch.Location = new System.Drawing.Point(30, 18);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "Nhập để tìm kiếm...";
            this.txtSearch.SelectedText = "";
            this.txtSearch.ShadowDecoration.Parent = this.txtSearch;
            this.txtSearch.Size = new System.Drawing.Size(481, 44);
            this.txtSearch.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnAdd);
            this.panel4.Controls.Add(this.btnUpdate);
            this.panel4.Controls.Add(this.btnDelete);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(745, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(535, 87);
            this.panel4.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.BorderRadius = 8;
            this.btnAdd.CheckedState.Parent = this.btnAdd;
            this.btnAdd.CustomImages.Parent = this.btnAdd;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.HoverState.Parent = this.btnAdd;
            this.btnAdd.Location = new System.Drawing.Point(35, 18);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.ShadowDecoration.Parent = this.btnAdd;
            this.btnAdd.Size = new System.Drawing.Size(138, 45);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BorderRadius = 8;
            this.btnUpdate.CheckedState.Parent = this.btnUpdate;
            this.btnUpdate.CustomImages.Parent = this.btnUpdate;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.HoverState.Parent = this.btnUpdate;
            this.btnUpdate.Location = new System.Drawing.Point(196, 18);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.ShadowDecoration.Parent = this.btnUpdate;
            this.btnUpdate.Size = new System.Drawing.Size(138, 45);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Chỉnh sửa";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BorderRadius = 8;
            this.btnDelete.CheckedState.Parent = this.btnDelete;
            this.btnDelete.CustomImages.Parent = this.btnDelete;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.HoverState.Parent = this.btnDelete;
            this.btnDelete.Location = new System.Drawing.Point(357, 18);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ShadowDecoration.Parent = this.btnDelete;
            this.btnDelete.Size = new System.Drawing.Size(138, 45);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 87);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1280, 633);
            this.panel5.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.gunaShadowPanel1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(30, 0, 0, 30);
            this.panel6.Size = new System.Drawing.Size(879, 633);
            this.panel6.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.lblManageCate);
            this.panel7.Controls.Add(this.picAvatar);
            this.panel7.Controls.Add(this.btnChangeAvatar);
            this.panel7.Controls.Add(this.label7);
            this.panel7.Controls.Add(this.optHidden);
            this.panel7.Controls.Add(this.optDisplay);
            this.panel7.Controls.Add(this.txtPrice);
            this.panel7.Controls.Add(this.txtName);
            this.panel7.Controls.Add(this.cmbFoodCategory);
            this.panel7.Controls.Add(this.label4);
            this.panel7.Controls.Add(this.label5);
            this.panel7.Controls.Add(this.label2);
            this.panel7.Controls.Add(this.label1);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel7.Location = new System.Drawing.Point(879, 0);
            this.panel7.Margin = new System.Windows.Forms.Padding(4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(401, 633);
            this.panel7.TabIndex = 1;
            // 
            // lblManageCate
            // 
            this.lblManageCate.AutoSize = true;
            this.lblManageCate.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageCate.LinkColor = System.Drawing.Color.Red;
            this.lblManageCate.Location = new System.Drawing.Point(201, 301);
            this.lblManageCate.Name = "lblManageCate";
            this.lblManageCate.Size = new System.Drawing.Size(151, 23);
            this.lblManageCate.TabIndex = 24;
            this.lblManageCate.TabStop = true;
            this.lblManageCate.Text = "Quản lý danh mục";
            this.lblManageCate.Click += new System.EventHandler(this.lblManageCate_Click);
            // 
            // picAvatar
            // 
            this.picAvatar.BaseColor = System.Drawing.Color.White;
            this.picAvatar.Location = new System.Drawing.Point(103, 46);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.Size = new System.Drawing.Size(145, 145);
            this.picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAvatar.TabIndex = 23;
            this.picAvatar.TabStop = false;
            // 
            // btnChangeAvatar
            // 
            this.btnChangeAvatar.BaseColor = System.Drawing.Color.White;
            this.btnChangeAvatar.Image = global::Dev69Restaurant.Properties.Resources.slr_back_side_48px;
            this.btnChangeAvatar.Location = new System.Drawing.Point(274, 52);
            this.btnChangeAvatar.Name = "btnChangeAvatar";
            this.btnChangeAvatar.Size = new System.Drawing.Size(32, 32);
            this.btnChangeAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnChangeAvatar.TabIndex = 22;
            this.btnChangeAvatar.TabStop = false;
            this.btnChangeAvatar.Click += new System.EventHandler(this.btnChangeAvatar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(31, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 23);
            this.label7.TabIndex = 20;
            this.label7.Text = "Ảnh món ăn";
            // 
            // optHidden
            // 
            this.optHidden.AutoSize = true;
            this.optHidden.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optHidden.Location = new System.Drawing.Point(264, 517);
            this.optHidden.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.optHidden.Name = "optHidden";
            this.optHidden.Size = new System.Drawing.Size(77, 29);
            this.optHidden.TabIndex = 18;
            this.optHidden.TabStop = true;
            this.optHidden.Text = "Ẩn đi";
            this.optHidden.UseVisualStyleBackColor = true;
            // 
            // optDisplay
            // 
            this.optDisplay.AutoSize = true;
            this.optDisplay.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optDisplay.Location = new System.Drawing.Point(129, 517);
            this.optDisplay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.optDisplay.Name = "optDisplay";
            this.optDisplay.Size = new System.Drawing.Size(99, 29);
            this.optDisplay.TabIndex = 19;
            this.optDisplay.TabStop = true;
            this.optDisplay.Text = "Hiển thị";
            this.optDisplay.UseVisualStyleBackColor = true;
            // 
            // txtPrice
            // 
            this.txtPrice.BorderRadius = 8;
            this.txtPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrice.DefaultText = "";
            this.txtPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrice.DisabledState.Parent = this.txtPrice;
            this.txtPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrice.FocusedState.Parent = this.txtPrice;
            this.txtPrice.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.ForeColor = System.Drawing.Color.Black;
            this.txtPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrice.HoverState.Parent = this.txtPrice;
            this.txtPrice.Location = new System.Drawing.Point(25, 421);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(5);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.PasswordChar = '\0';
            this.txtPrice.PlaceholderText = "Nhập giá gốc...";
            this.txtPrice.SelectedText = "";
            this.txtPrice.ShadowDecoration.Parent = this.txtPrice;
            this.txtPrice.Size = new System.Drawing.Size(327, 37);
            this.txtPrice.TabIndex = 14;
            // 
            // txtName
            // 
            this.txtName.BorderRadius = 8;
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.DefaultText = "";
            this.txtName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtName.DisabledState.Parent = this.txtName;
            this.txtName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtName.FocusedState.Parent = this.txtName;
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.Black;
            this.txtName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtName.HoverState.Parent = this.txtName;
            this.txtName.Location = new System.Drawing.Point(25, 241);
            this.txtName.Margin = new System.Windows.Forms.Padding(5);
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.PlaceholderText = "Nhập tên món ăn...";
            this.txtName.SelectedText = "";
            this.txtName.ShadowDecoration.Parent = this.txtName;
            this.txtName.Size = new System.Drawing.Size(327, 37);
            this.txtName.TabIndex = 16;
            // 
            // cmbFoodCategory
            // 
            this.cmbFoodCategory.BackColor = System.Drawing.Color.Transparent;
            this.cmbFoodCategory.BaseColor = System.Drawing.Color.White;
            this.cmbFoodCategory.BorderColor = System.Drawing.Color.Silver;
            this.cmbFoodCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbFoodCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFoodCategory.FocusedColor = System.Drawing.Color.Empty;
            this.cmbFoodCategory.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbFoodCategory.ForeColor = System.Drawing.Color.Black;
            this.cmbFoodCategory.FormattingEnabled = true;
            this.cmbFoodCategory.Location = new System.Drawing.Point(25, 339);
            this.cmbFoodCategory.Margin = new System.Windows.Forms.Padding(4);
            this.cmbFoodCategory.Name = "cmbFoodCategory";
            this.cmbFoodCategory.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbFoodCategory.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbFoodCategory.Radius = 8;
            this.cmbFoodCategory.Size = new System.Drawing.Size(327, 31);
            this.cmbFoodCategory.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 520);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Trạng thái:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 299);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Danh mục thức ăn:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 388);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Giá gốc:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Tên món ăn: ";
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = null;
            // 
            // gunaShadowPanel1
            // 
            this.gunaShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaShadowPanel1.BaseColor = System.Drawing.Color.Transparent;
            this.gunaShadowPanel1.Controls.Add(this.dgvListFood);
            this.gunaShadowPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaShadowPanel1.Location = new System.Drawing.Point(30, 0);
            this.gunaShadowPanel1.Name = "gunaShadowPanel1";
            this.gunaShadowPanel1.Padding = new System.Windows.Forms.Padding(5, 3, 10, 10);
            this.gunaShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.gunaShadowPanel1.ShadowDepth = 50;
            this.gunaShadowPanel1.Size = new System.Drawing.Size(849, 603);
            this.gunaShadowPanel1.TabIndex = 0;
            // 
            // dgvListFood
            // 
            this.dgvListFood.AllowUserToAddRows = false;
            this.dgvListFood.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(223)))), ((int)(((byte)(251)))));
            this.dgvListFood.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListFood.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListFood.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvListFood.BackgroundColor = System.Drawing.Color.White;
            this.dgvListFood.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListFood.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvListFood.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListFood.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListFood.ColumnHeadersHeight = 35;
            this.dgvListFood.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.FoodName,
            this.FoodId,
            this.Category,
            this.Price,
            this.Status});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListFood.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvListFood.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListFood.EnableHeadersVisualStyles = false;
            this.dgvListFood.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.dgvListFood.Location = new System.Drawing.Point(5, 3);
            this.dgvListFood.Name = "dgvListFood";
            this.dgvListFood.ReadOnly = true;
            this.dgvListFood.RowHeadersVisible = false;
            this.dgvListFood.RowHeadersWidth = 50;
            this.dgvListFood.RowTemplate.Height = 24;
            this.dgvListFood.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListFood.Size = new System.Drawing.Size(834, 590);
            this.dgvListFood.TabIndex = 2;
            this.dgvListFood.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Blue;
            this.dgvListFood.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(223)))), ((int)(((byte)(251)))));
            this.dgvListFood.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvListFood.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvListFood.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvListFood.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvListFood.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvListFood.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.dgvListFood.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(242)))));
            this.dgvListFood.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvListFood.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvListFood.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvListFood.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvListFood.ThemeStyle.HeaderStyle.Height = 35;
            this.dgvListFood.ThemeStyle.ReadOnly = true;
            this.dgvListFood.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            this.dgvListFood.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvListFood.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvListFood.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvListFood.ThemeStyle.RowsStyle.Height = 24;
            this.dgvListFood.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(246)))));
            this.dgvListFood.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvListFood.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListFood_CellClick);
            // 
            // STT
            // 
            this.STT.FillWeight = 20F;
            this.STT.HeaderText = "#";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            // 
            // FoodName
            // 
            this.FoodName.HeaderText = "Tên món ăn";
            this.FoodName.MinimumWidth = 6;
            this.FoodName.Name = "FoodName";
            this.FoodName.ReadOnly = true;
            // 
            // FoodId
            // 
            this.FoodId.FillWeight = 105.8642F;
            this.FoodId.HeaderText = "Mã món ăn";
            this.FoodId.MinimumWidth = 6;
            this.FoodId.Name = "FoodId";
            this.FoodId.ReadOnly = true;
            // 
            // Category
            // 
            this.Category.FillWeight = 105.8642F;
            this.Category.HeaderText = "Danh mục";
            this.Category.MinimumWidth = 6;
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.FillWeight = 105.8642F;
            this.Price.HeaderText = "Giá gốc";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.FillWeight = 105.8642F;
            this.Status.HeaderText = "Trạng thái";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // ManageFoodForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ManageFoodForm";
            this.Text = "Quản lý món ăn";
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnChangeAvatar)).EndInit();
            this.gunaShadowPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListFood)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.RadioButton optHidden;
        private System.Windows.Forms.RadioButton optDisplay;
        private Guna.UI2.WinForms.Guna2TextBox txtPrice;
        private Guna.UI2.WinForms.Guna2TextBox txtName;
        private Guna.UI.WinForms.GunaComboBox cmbFoodCategory;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI.WinForms.GunaPictureBox picAvatar;
        private Guna.UI.WinForms.GunaPictureBox btnChangeAvatar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.LinkLabel lblManageCate;
        private Guna.UI.WinForms.GunaShadowPanel gunaShadowPanel1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvListFood;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn FoodName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FoodId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
    }
}