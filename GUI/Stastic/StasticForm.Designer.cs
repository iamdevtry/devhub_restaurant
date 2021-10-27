
namespace Dev69Restaurant.GUI.Stastic
{
    partial class StasticForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gnShadowForm2 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.gunaShadowPanel1 = new Guna.UI.WinForms.GunaShadowPanel();
            this.dgvListUser = new Guna.UI2.WinForms.Guna2DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DisplayName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BirthDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnDetail = new Guna.UI2.WinForms.Guna2Button();
            this.pnHeader = new Guna.UI.WinForms.GunaPanel();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.ckbAllInMonth = new System.Windows.Forms.CheckBox();
            this.DateEnd = new Guna.UI.WinForms.GunaDateTimePicker();
            this.DateStart = new Guna.UI.WinForms.GunaDateTimePicker();
            this.gnElipseDgv = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.gunaShadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListUser)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaShadowPanel1
            // 
            this.gunaShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaShadowPanel1.BaseColor = System.Drawing.Color.Transparent;
            this.gunaShadowPanel1.Controls.Add(this.dgvListUser);
            this.gunaShadowPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaShadowPanel1.Location = new System.Drawing.Point(30, 0);
            this.gunaShadowPanel1.Name = "gunaShadowPanel1";
            this.gunaShadowPanel1.Padding = new System.Windows.Forms.Padding(5, 3, 10, 10);
            this.gunaShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.gunaShadowPanel1.ShadowDepth = 50;
            this.gunaShadowPanel1.Size = new System.Drawing.Size(1220, 558);
            this.gunaShadowPanel1.TabIndex = 0;
            // 
            // dgvListUser
            // 
            this.dgvListUser.AllowUserToAddRows = false;
            this.dgvListUser.AllowUserToDeleteRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(223)))), ((int)(((byte)(251)))));
            this.dgvListUser.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvListUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListUser.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvListUser.BackgroundColor = System.Drawing.Color.White;
            this.dgvListUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListUser.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvListUser.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListUser.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvListUser.ColumnHeadersHeight = 35;
            this.dgvListUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.FullName,
            this.DisplayName,
            this.createdDate,
            this.Username,
            this.BirthDay,
            this.Address,
            this.Phone});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListUser.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgvListUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListUser.EnableHeadersVisualStyles = false;
            this.dgvListUser.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.dgvListUser.Location = new System.Drawing.Point(5, 3);
            this.dgvListUser.Name = "dgvListUser";
            this.dgvListUser.ReadOnly = true;
            this.dgvListUser.RowHeadersVisible = false;
            this.dgvListUser.RowHeadersWidth = 50;
            this.dgvListUser.RowTemplate.Height = 24;
            this.dgvListUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListUser.Size = new System.Drawing.Size(1205, 545);
            this.dgvListUser.TabIndex = 0;
            this.dgvListUser.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Blue;
            this.dgvListUser.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(223)))), ((int)(((byte)(251)))));
            this.dgvListUser.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvListUser.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvListUser.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvListUser.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvListUser.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvListUser.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.dgvListUser.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(242)))));
            this.dgvListUser.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvListUser.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvListUser.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvListUser.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvListUser.ThemeStyle.HeaderStyle.Height = 35;
            this.dgvListUser.ThemeStyle.ReadOnly = true;
            this.dgvListUser.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            this.dgvListUser.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvListUser.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvListUser.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvListUser.ThemeStyle.RowsStyle.Height = 24;
            this.dgvListUser.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(246)))));
            this.dgvListUser.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // STT
            // 
            this.STT.FillWeight = 40F;
            this.STT.HeaderText = "#";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            // 
            // FullName
            // 
            this.FullName.HeaderText = "Mã hóa đơn";
            this.FullName.MinimumWidth = 6;
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            // 
            // DisplayName
            // 
            this.DisplayName.FillWeight = 105.8642F;
            this.DisplayName.HeaderText = "Bàn";
            this.DisplayName.MinimumWidth = 6;
            this.DisplayName.Name = "DisplayName";
            this.DisplayName.ReadOnly = true;
            // 
            // createdDate
            // 
            this.createdDate.HeaderText = "Ngày tạo";
            this.createdDate.MinimumWidth = 6;
            this.createdDate.Name = "createdDate";
            this.createdDate.ReadOnly = true;
            // 
            // Username
            // 
            this.Username.FillWeight = 105.8642F;
            this.Username.HeaderText = "Thanh toán";
            this.Username.MinimumWidth = 6;
            this.Username.Name = "Username";
            this.Username.ReadOnly = true;
            // 
            // BirthDay
            // 
            this.BirthDay.FillWeight = 105.8642F;
            this.BirthDay.HeaderText = "Giảm giá";
            this.BirthDay.MinimumWidth = 6;
            this.BirthDay.Name = "BirthDay";
            this.BirthDay.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.FillWeight = 105.8642F;
            this.Address.HeaderText = "Tổng ";
            this.Address.MinimumWidth = 6;
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // Phone
            // 
            this.Phone.FillWeight = 105.8642F;
            this.Phone.HeaderText = "Người thực hiện";
            this.Phone.MinimumWidth = 6;
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gunaShadowPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 132);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(30, 0, 30, 30);
            this.panel1.Size = new System.Drawing.Size(1280, 588);
            this.panel1.TabIndex = 17;
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
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.HoverState.Parent = this.txtSearch;
            this.txtSearch.IconLeft = global::Dev69Restaurant.Properties.Resources.search_24px;
            this.txtSearch.Location = new System.Drawing.Point(38, 65);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "Search everything...";
            this.txtSearch.SelectedText = "";
            this.txtSearch.ShadowDecoration.Parent = this.txtSearch;
            this.txtSearch.Size = new System.Drawing.Size(399, 44);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnDetail
            // 
            this.btnDetail.BorderRadius = 8;
            this.btnDetail.CheckedState.Parent = this.btnDetail;
            this.btnDetail.CustomImages.Parent = this.btnDetail;
            this.btnDetail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDetail.ForeColor = System.Drawing.Color.White;
            this.btnDetail.HoverState.Parent = this.btnDetail;
            this.btnDetail.Location = new System.Drawing.Point(643, 65);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.ShadowDecoration.Parent = this.btnDetail;
            this.btnDetail.Size = new System.Drawing.Size(138, 45);
            this.btnDetail.TabIndex = 0;
            this.btnDetail.Text = "Xem chi tiết";
            this.btnDetail.Click += new System.EventHandler(this.btnDetail_Click);
            // 
            // pnHeader
            // 
            this.pnHeader.Controls.Add(this.btnDetail);
            this.pnHeader.Controls.Add(this.btnSearch);
            this.pnHeader.Controls.Add(this.gunaLabel2);
            this.pnHeader.Controls.Add(this.gunaLabel1);
            this.pnHeader.Controls.Add(this.ckbAllInMonth);
            this.pnHeader.Controls.Add(this.DateEnd);
            this.pnHeader.Controls.Add(this.DateStart);
            this.pnHeader.Controls.Add(this.txtSearch);
            this.pnHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnHeader.Location = new System.Drawing.Point(0, 0);
            this.pnHeader.Name = "pnHeader";
            this.pnHeader.Size = new System.Drawing.Size(1280, 132);
            this.pnHeader.TabIndex = 16;
            // 
            // btnSearch
            // 
            this.btnSearch.BorderRadius = 8;
            this.btnSearch.CheckedState.Parent = this.btnSearch;
            this.btnSearch.CustomImages.Parent = this.btnSearch;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.HoverState.Parent = this.btnSearch;
            this.btnSearch.Location = new System.Drawing.Point(486, 65);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.ShadowDecoration.Parent = this.btnSearch;
            this.btnSearch.Size = new System.Drawing.Size(138, 45);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel2.Location = new System.Drawing.Point(382, 30);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(34, 20);
            this.gunaLabel2.TabIndex = 14;
            this.gunaLabel2.Text = "đến";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel1.Location = new System.Drawing.Point(38, 30);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(62, 20);
            this.gunaLabel1.TabIndex = 14;
            this.gunaLabel1.Text = "Từ ngày";
            // 
            // ckbAllInMonth
            // 
            this.ckbAllInMonth.AutoSize = true;
            this.ckbAllInMonth.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbAllInMonth.Location = new System.Drawing.Point(729, 26);
            this.ckbAllInMonth.Name = "ckbAllInMonth";
            this.ckbAllInMonth.Size = new System.Drawing.Size(184, 24);
            this.ckbAllInMonth.TabIndex = 13;
            this.ckbAllInMonth.Text = "Xem tất cả trong tháng";
            this.ckbAllInMonth.UseVisualStyleBackColor = true;
            this.ckbAllInMonth.CheckedChanged += new System.EventHandler(this.ckbAllInMonth_CheckedChanged);
            // 
            // DateEnd
            // 
            this.DateEnd.BackColor = System.Drawing.Color.Transparent;
            this.DateEnd.BaseColor = System.Drawing.Color.White;
            this.DateEnd.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.DateEnd.BorderSize = 1;
            this.DateEnd.CustomFormat = null;
            this.DateEnd.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.DateEnd.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DateEnd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DateEnd.ForeColor = System.Drawing.Color.Black;
            this.DateEnd.Location = new System.Drawing.Point(434, 22);
            this.DateEnd.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DateEnd.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DateEnd.Name = "DateEnd";
            this.DateEnd.OnHoverBaseColor = System.Drawing.Color.White;
            this.DateEnd.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DateEnd.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DateEnd.OnPressedColor = System.Drawing.Color.Black;
            this.DateEnd.Radius = 8;
            this.DateEnd.Size = new System.Drawing.Size(249, 30);
            this.DateEnd.TabIndex = 12;
            this.DateEnd.Text = "Tuesday, October 26, 2021";
            this.DateEnd.Value = new System.DateTime(2021, 10, 26, 21, 38, 16, 514);
            this.DateEnd.ValueChanged += new System.EventHandler(this.DateEnd_ValueChanged);
            // 
            // DateStart
            // 
            this.DateStart.BackColor = System.Drawing.Color.Transparent;
            this.DateStart.BaseColor = System.Drawing.Color.White;
            this.DateStart.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.DateStart.BorderSize = 1;
            this.DateStart.CustomFormat = null;
            this.DateStart.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.DateStart.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DateStart.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DateStart.ForeColor = System.Drawing.Color.Black;
            this.DateStart.Location = new System.Drawing.Point(119, 22);
            this.DateStart.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DateStart.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DateStart.Name = "DateStart";
            this.DateStart.OnHoverBaseColor = System.Drawing.Color.White;
            this.DateStart.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DateStart.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DateStart.OnPressedColor = System.Drawing.Color.Black;
            this.DateStart.Radius = 8;
            this.DateStart.Size = new System.Drawing.Size(249, 30);
            this.DateStart.TabIndex = 12;
            this.DateStart.Text = "Tuesday, October 26, 2021";
            this.DateStart.Value = new System.DateTime(2021, 10, 26, 21, 38, 16, 514);
            this.DateStart.ValueChanged += new System.EventHandler(this.DateStart_ValueChanged);
            // 
            // gnElipseDgv
            // 
            this.gnElipseDgv.BorderRadius = 8;
            // 
            // StasticForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StasticForm";
            this.Text = "StasticForm";
            this.gunaShadowPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListUser)).EndInit();
            this.panel1.ResumeLayout(false);
            this.pnHeader.ResumeLayout(false);
            this.pnHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowForm gnShadowForm2;
        private Guna.UI.WinForms.GunaShadowPanel gunaShadowPanel1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2Button btnDetail;
        private Guna.UI.WinForms.GunaPanel pnHeader;
        private Guna.UI2.WinForms.Guna2Elipse gnElipseDgv;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private System.Windows.Forms.CheckBox ckbAllInMonth;
        private Guna.UI.WinForms.GunaDateTimePicker DateEnd;
        private Guna.UI.WinForms.GunaDateTimePicker DateStart;
        private Guna.UI2.WinForms.Guna2DataGridView dgvListUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DisplayName;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirthDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
    }
}