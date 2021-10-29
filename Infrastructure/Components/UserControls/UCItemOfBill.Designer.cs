
namespace Dev69Restaurant.Infrastructure.Components.UserControls
{
    partial class UCItemOfBill
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTotalPrice = new Guna.UI.WinForms.GunaLabel();
            this.btnDelete = new Guna.UI.WinForms.GunaImageButton();
            this.lblPrice = new Guna.UI.WinForms.GunaLabel();
            this.lblFoodName = new Guna.UI.WinForms.GunaLabel();
            this.nmrQuantity = new Guna.UI.WinForms.GunaNumeric();
            this.gunaLinePanel1 = new Guna.UI.WinForms.GunaLinePanel();
            this.panel1.SuspendLayout();
            this.gunaLinePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.lblPrice);
            this.panel1.Controls.Add(this.lblFoodName);
            this.panel1.Controls.Add(this.nmrQuantity);
            this.panel1.Controls.Add(this.gunaLinePanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 57);
            this.panel1.TabIndex = 0;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.Location = new System.Drawing.Point(212, 17);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(75, 20);
            this.lblTotalPrice.TabIndex = 9;
            this.lblTotalPrice.Text = "140.000 Đ";
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImage = global::Dev69Restaurant.Properties.Resources.delete_bin_48px;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDelete.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDelete.Image = null;
            this.btnDelete.ImageSize = new System.Drawing.Size(40, 40);
            this.btnDelete.Location = new System.Drawing.Point(5, 6);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.OnHoverImage = null;
            this.btnDelete.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.btnDelete.Size = new System.Drawing.Size(32, 32);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPrice.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblPrice.Location = new System.Drawing.Point(39, 27);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(67, 20);
            this.lblPrice.TabIndex = 7;
            this.lblPrice.Text = "35.000 Đ";
            // 
            // lblFoodName
            // 
            this.lblFoodName.AutoSize = true;
            this.lblFoodName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFoodName.Location = new System.Drawing.Point(37, 4);
            this.lblFoodName.Name = "lblFoodName";
            this.lblFoodName.Size = new System.Drawing.Size(65, 23);
            this.lblFoodName.TabIndex = 6;
            this.lblFoodName.Text = "Gà Rán";
            // 
            // nmrQuantity
            // 
            this.nmrQuantity.BackColor = System.Drawing.Color.Transparent;
            this.nmrQuantity.BaseColor = System.Drawing.Color.White;
            this.nmrQuantity.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(165)))));
            this.nmrQuantity.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(165)))));
            this.nmrQuantity.ButtonForeColor = System.Drawing.Color.White;
            this.nmrQuantity.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.nmrQuantity.ForeColor = System.Drawing.Color.Black;
            this.nmrQuantity.Location = new System.Drawing.Point(146, 12);
            this.nmrQuantity.Maximum = ((long)(9999999));
            this.nmrQuantity.Minimum = ((long)(0));
            this.nmrQuantity.Name = "nmrQuantity";
            this.nmrQuantity.Radius = 8;
            this.nmrQuantity.Size = new System.Drawing.Size(58, 30);
            this.nmrQuantity.TabIndex = 5;
            this.nmrQuantity.Text = "gunaNumeric1";
            this.nmrQuantity.Value = ((long)(1));
            this.nmrQuantity.ValueChanged += new System.EventHandler(this.nmrQuantity_ValueChanged);
            // 
            // gunaLinePanel1
            // 
            this.gunaLinePanel1.Controls.Add(this.lblTotalPrice);
            this.gunaLinePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaLinePanel1.LineBottom = 1;
            this.gunaLinePanel1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(170)))), ((int)(((byte)(229)))));
            this.gunaLinePanel1.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaLinePanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaLinePanel1.Name = "gunaLinePanel1";
            this.gunaLinePanel1.Size = new System.Drawing.Size(300, 57);
            this.gunaLinePanel1.TabIndex = 10;
            // 
            // UCItemOfBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "UCItemOfBill";
            this.Size = new System.Drawing.Size(300, 57);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gunaLinePanel1.ResumeLayout(false);
            this.gunaLinePanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaLabel lblTotalPrice;
        private Guna.UI.WinForms.GunaImageButton btnDelete;
        private Guna.UI.WinForms.GunaLabel lblPrice;
        private Guna.UI.WinForms.GunaLabel lblFoodName;
        private Guna.UI.WinForms.GunaNumeric nmrQuantity;
        private Guna.UI.WinForms.GunaLinePanel gunaLinePanel1;
    }
}
