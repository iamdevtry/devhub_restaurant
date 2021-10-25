
namespace Dev69Restaurant.GUI.Revenue
{
    partial class RevenueForm
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
            this.gnShadowForm2 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.pnHeader = new Guna.UI.WinForms.GunaPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gunaImageButton1 = new Guna.UI.WinForms.GunaImageButton();
            this.guna2CustomGradientPanel2 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gunaImageButton2 = new Guna.UI.WinForms.GunaImageButton();
            this.guna2CustomGradientPanel3 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.gunaImageButton3 = new Guna.UI.WinForms.GunaImageButton();
            this.gnElipseDgv = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.chartRevenue = new LiveCharts.WinForms.CartesianChart();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.revenueChartBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnHeader.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.guna2CustomGradientPanel1.SuspendLayout();
            this.guna2CustomGradientPanel2.SuspendLayout();
            this.guna2CustomGradientPanel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.revenueChartBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pnHeader
            // 
            this.pnHeader.Controls.Add(this.flowLayoutPanel1);
            this.pnHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnHeader.Location = new System.Drawing.Point(0, 0);
            this.pnHeader.Name = "pnHeader";
            this.pnHeader.Size = new System.Drawing.Size(1280, 147);
            this.pnHeader.TabIndex = 16;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.guna2CustomGradientPanel1);
            this.flowLayoutPanel1.Controls.Add(this.guna2CustomGradientPanel2);
            this.flowLayoutPanel1.Controls.Add(this.guna2CustomGradientPanel3);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(30, 20, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1280, 147);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.BorderRadius = 35;
            this.guna2CustomGradientPanel1.Controls.Add(this.label2);
            this.guna2CustomGradientPanel1.Controls.Add(this.label1);
            this.guna2CustomGradientPanel1.Controls.Add(this.gunaImageButton1);
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(33, 23);
            this.guna2CustomGradientPanel1.Margin = new System.Windows.Forms.Padding(3, 3, 30, 3);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.ShadowDecoration.Parent = this.guna2CustomGradientPanel1;
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(371, 105);
            this.guna2CustomGradientPanel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(97, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "1.000.000 đ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(97, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Doanh thu hôm nay:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gunaImageButton1
            // 
            this.gunaImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaImageButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaImageButton1.Image = global::Dev69Restaurant.Properties.Resources.cash_receipt_48px;
            this.gunaImageButton1.ImageSize = new System.Drawing.Size(64, 64);
            this.gunaImageButton1.Location = new System.Drawing.Point(27, 18);
            this.gunaImageButton1.Name = "gunaImageButton1";
            this.gunaImageButton1.OnHoverImage = null;
            this.gunaImageButton1.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.gunaImageButton1.Size = new System.Drawing.Size(64, 64);
            this.gunaImageButton1.TabIndex = 0;
            // 
            // guna2CustomGradientPanel2
            // 
            this.guna2CustomGradientPanel2.BorderRadius = 35;
            this.guna2CustomGradientPanel2.Controls.Add(this.label3);
            this.guna2CustomGradientPanel2.Controls.Add(this.label4);
            this.guna2CustomGradientPanel2.Controls.Add(this.gunaImageButton2);
            this.guna2CustomGradientPanel2.Location = new System.Drawing.Point(437, 23);
            this.guna2CustomGradientPanel2.Margin = new System.Windows.Forms.Padding(3, 3, 30, 3);
            this.guna2CustomGradientPanel2.Name = "guna2CustomGradientPanel2";
            this.guna2CustomGradientPanel2.ShadowDecoration.Parent = this.guna2CustomGradientPanel2;
            this.guna2CustomGradientPanel2.Size = new System.Drawing.Size(371, 105);
            this.guna2CustomGradientPanel2.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(97, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "1.000.000 đ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(97, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(248, 32);
            this.label4.TabIndex = 1;
            this.label4.Text = "Doanh thu hôm nay:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gunaImageButton2
            // 
            this.gunaImageButton2.BackColor = System.Drawing.Color.Transparent;
            this.gunaImageButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaImageButton2.Image = global::Dev69Restaurant.Properties.Resources.cash_receipt_48px;
            this.gunaImageButton2.ImageSize = new System.Drawing.Size(64, 64);
            this.gunaImageButton2.Location = new System.Drawing.Point(27, 18);
            this.gunaImageButton2.Name = "gunaImageButton2";
            this.gunaImageButton2.OnHoverImage = null;
            this.gunaImageButton2.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.gunaImageButton2.Size = new System.Drawing.Size(64, 64);
            this.gunaImageButton2.TabIndex = 0;
            // 
            // guna2CustomGradientPanel3
            // 
            this.guna2CustomGradientPanel3.BorderRadius = 35;
            this.guna2CustomGradientPanel3.Controls.Add(this.label5);
            this.guna2CustomGradientPanel3.Controls.Add(this.label6);
            this.guna2CustomGradientPanel3.Controls.Add(this.gunaImageButton3);
            this.guna2CustomGradientPanel3.Location = new System.Drawing.Point(841, 23);
            this.guna2CustomGradientPanel3.Name = "guna2CustomGradientPanel3";
            this.guna2CustomGradientPanel3.ShadowDecoration.Parent = this.guna2CustomGradientPanel3;
            this.guna2CustomGradientPanel3.Size = new System.Drawing.Size(371, 105);
            this.guna2CustomGradientPanel3.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(97, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 23);
            this.label5.TabIndex = 2;
            this.label5.Text = "1.000.000 đ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(97, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(248, 32);
            this.label6.TabIndex = 1;
            this.label6.Text = "Doanh thu hôm nay:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gunaImageButton3
            // 
            this.gunaImageButton3.BackColor = System.Drawing.Color.Transparent;
            this.gunaImageButton3.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaImageButton3.Image = global::Dev69Restaurant.Properties.Resources.cash_receipt_48px;
            this.gunaImageButton3.ImageSize = new System.Drawing.Size(64, 64);
            this.gunaImageButton3.Location = new System.Drawing.Point(27, 18);
            this.gunaImageButton3.Name = "gunaImageButton3";
            this.gunaImageButton3.OnHoverImage = null;
            this.gunaImageButton3.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.gunaImageButton3.Size = new System.Drawing.Size(64, 64);
            this.gunaImageButton3.TabIndex = 0;
            // 
            // gnElipseDgv
            // 
            this.gnElipseDgv.BorderRadius = 8;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 147);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1280, 573);
            this.panel1.TabIndex = 17;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.chartRevenue);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.panel3.Size = new System.Drawing.Size(841, 573);
            this.panel3.TabIndex = 1;
            // 
            // chartRevenue
            // 
            this.chartRevenue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartRevenue.Location = new System.Drawing.Point(30, 0);
            this.chartRevenue.Name = "chartRevenue";
            this.chartRevenue.Size = new System.Drawing.Size(811, 573);
            this.chartRevenue.TabIndex = 4;
            this.chartRevenue.Text = "cartesianChart1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gunaLabel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(841, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(439, 573);
            this.panel2.TabIndex = 0;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel1.Location = new System.Drawing.Point(48, 61);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(104, 20);
            this.gunaLabel1.TabIndex = 3;
            this.gunaLabel1.Text = "Thống kê theo";
            // 
            // revenueChartBindingSource
            // 
            this.revenueChartBindingSource.DataSource = typeof(Dev69Restaurant.Common.RevenueChart);
            // 
            // RevenueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RevenueForm";
            this.Text = "RevenueForm";
            this.Load += new System.EventHandler(this.RevenueForm_Load);
            this.pnHeader.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.guna2CustomGradientPanel2.ResumeLayout(false);
            this.guna2CustomGradientPanel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.revenueChartBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowForm gnShadowForm2;
        private Guna.UI.WinForms.GunaPanel pnHeader;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2Elipse gnElipseDgv;
        private Guna.UI.WinForms.GunaImageButton gunaImageButton1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Guna.UI.WinForms.GunaImageButton gunaImageButton3;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Guna.UI.WinForms.GunaImageButton gunaImageButton2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.BindingSource revenueChartBindingSource;
        private LiveCharts.WinForms.CartesianChart chartRevenue;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
    }
}