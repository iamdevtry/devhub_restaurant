
namespace Dev69Restaurant.Infrastructure.Components.UserControls
{
    partial class UCTableFood
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
            this.pnStatus = new Guna.UI.WinForms.GunaGradient2Panel();
            this.lblStatus = new Guna.UI.WinForms.GunaLabel();
            this.pnTableName = new Guna.UI.WinForms.GunaShadowPanel();
            this.lblTableName = new Guna.UI.WinForms.GunaLabel();
            this.pnlineTableFood = new Guna.UI.WinForms.GunaLinePanel();
            this.chbSelectTable = new Guna.UI.WinForms.GunaImageCheckBox();
            this.pnStatus.SuspendLayout();
            this.pnTableName.SuspendLayout();
            this.pnlineTableFood.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnStatus
            // 
            this.pnStatus.BackColor = System.Drawing.Color.Transparent;
            this.pnStatus.Controls.Add(this.lblStatus);
            this.pnStatus.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(170)))), ((int)(((byte)(229)))));
            this.pnStatus.GradientColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(165)))));
            this.pnStatus.Location = new System.Drawing.Point(20, 14);
            this.pnStatus.Name = "pnStatus";
            this.pnStatus.Radius = 8;
            this.pnStatus.Size = new System.Drawing.Size(107, 34);
            this.pnStatus.TabIndex = 0;
            // 
            // lblStatus
            // 
            this.lblStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.White;
            this.lblStatus.Location = new System.Drawing.Point(0, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(107, 34);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "Status";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnTableName
            // 
            this.pnTableName.BackColor = System.Drawing.Color.Transparent;
            this.pnTableName.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnTableName.Controls.Add(this.lblTableName);
            this.pnTableName.Location = new System.Drawing.Point(20, 80);
            this.pnTableName.Name = "pnTableName";
            this.pnTableName.ShadowColor = System.Drawing.Color.Black;
            this.pnTableName.Size = new System.Drawing.Size(180, 40);
            this.pnTableName.TabIndex = 1;
            // 
            // lblTableName
            // 
            this.lblTableName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTableName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTableName.ForeColor = System.Drawing.Color.White;
            this.lblTableName.Location = new System.Drawing.Point(0, 0);
            this.lblTableName.Name = "lblTableName";
            this.lblTableName.Size = new System.Drawing.Size(180, 40);
            this.lblTableName.TabIndex = 0;
            this.lblTableName.Text = "Table name";
            this.lblTableName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTableName.Click += new System.EventHandler(this.lblTableName_Click);
            // 
            // pnlineTableFood
            // 
            this.pnlineTableFood.BackColor = System.Drawing.Color.Transparent;
            this.pnlineTableFood.Controls.Add(this.chbSelectTable);
            this.pnlineTableFood.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlineTableFood.LineBottom = 3;
            this.pnlineTableFood.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(170)))), ((int)(((byte)(229)))));
            this.pnlineTableFood.LineLeft = 3;
            this.pnlineTableFood.LineRight = 3;
            this.pnlineTableFood.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.pnlineTableFood.LineTop = 3;
            this.pnlineTableFood.Location = new System.Drawing.Point(0, 0);
            this.pnlineTableFood.Name = "pnlineTableFood";
            this.pnlineTableFood.Size = new System.Drawing.Size(220, 200);
            this.pnlineTableFood.TabIndex = 2;
            this.pnlineTableFood.Visible = false;
            this.pnlineTableFood.Click += new System.EventHandler(this.pnlineTableFood_Click);
            // 
            // chbSelectTable
            // 
            this.chbSelectTable.ImageCheckedOff = global::Dev69Restaurant.Properties.Resources.unchecked_radio_button_48px;
            this.chbSelectTable.ImageCheckedOn = global::Dev69Restaurant.Properties.Resources.checked_radio_button_48px;
            this.chbSelectTable.ImageSize = new System.Drawing.Size(32, 32);
            this.chbSelectTable.Location = new System.Drawing.Point(171, 149);
            this.chbSelectTable.Name = "chbSelectTable";
            this.chbSelectTable.Size = new System.Drawing.Size(40, 40);
            this.chbSelectTable.TabIndex = 0;
            // 
            // UCTableFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Dev69Restaurant.Properties.Resources.no_image;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Controls.Add(this.pnTableName);
            this.Controls.Add(this.pnStatus);
            this.Controls.Add(this.pnlineTableFood);
            this.Margin = new System.Windows.Forms.Padding(15);
            this.Name = "UCTableFood";
            this.Size = new System.Drawing.Size(220, 200);
            this.Click += new System.EventHandler(this.UCTableFood_Click);
            this.pnStatus.ResumeLayout(false);
            this.pnTableName.ResumeLayout(false);
            this.pnlineTableFood.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaGradient2Panel pnStatus;
        private Guna.UI.WinForms.GunaLabel lblStatus;
        private Guna.UI.WinForms.GunaShadowPanel pnTableName;
        private Guna.UI.WinForms.GunaLabel lblTableName;
        private Guna.UI.WinForms.GunaLinePanel pnlineTableFood;
        private Guna.UI.WinForms.GunaImageCheckBox chbSelectTable;
    }
}
