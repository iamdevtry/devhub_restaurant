
namespace Dev69Restaurant.GUI.Stastic
{
    partial class BillDetailForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.rptBillDetail = new Microsoft.Reporting.WinForms.ReportViewer();
            this.drag = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.shadowForm = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.pnTop.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnTop
            // 
            this.pnTop.Controls.Add(this.gunaLabel1);
            this.pnTop.Controls.Add(this.gunaControlBox2);
            this.pnTop.Controls.Add(this.gunaControlBox1);
            this.pnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTop.Location = new System.Drawing.Point(0, 0);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(979, 47);
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
            this.gunaControlBox2.Location = new System.Drawing.Point(871, 12);
            this.gunaControlBox2.Name = "gunaControlBox2";
            this.gunaControlBox2.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.gunaControlBox2.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox2.Size = new System.Drawing.Size(45, 29);
            this.gunaControlBox2.TabIndex = 1;
            // 
            // gunaControlBox1
            // 
            this.gunaControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox1.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox1.AnimationSpeed = 0.03F;
            this.gunaControlBox1.IconColor = System.Drawing.Color.Black;
            this.gunaControlBox1.IconSize = 15F;
            this.gunaControlBox1.Location = new System.Drawing.Point(922, 12);
            this.gunaControlBox1.Name = "gunaControlBox1";
            this.gunaControlBox1.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.gunaControlBox1.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox1.Size = new System.Drawing.Size(45, 29);
            this.gunaControlBox1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rptBillDetail);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 47);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(979, 673);
            this.panel2.TabIndex = 1;
            // 
            // rptBillDetail
            // 
            this.rptBillDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptBillDetail.Location = new System.Drawing.Point(0, 0);
            this.rptBillDetail.Name = "rptBillDetail";
            this.rptBillDetail.ServerReport.BearerToken = null;
            this.rptBillDetail.Size = new System.Drawing.Size(979, 673);
            this.rptBillDetail.TabIndex = 0;
            // 
            // drag
            // 
            this.drag.TargetControl = this.pnTop;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(13, 12);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(134, 23);
            this.gunaLabel1.TabIndex = 2;
            this.gunaLabel1.Text = "Chi tiết hóa đơn";
            // 
            // BillDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 720);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BillDetailForm";
            this.Text = "Chi tiết hóa đơn";
            this.Load += new System.EventHandler(this.BillDetailForm_Load);
            this.pnTop.ResumeLayout(false);
            this.pnTop.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnTop;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox2;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox1;
        private System.Windows.Forms.Panel panel2;
        private Microsoft.Reporting.WinForms.ReportViewer rptBillDetail;
        private Guna.UI.WinForms.GunaDragControl drag;
        private Guna.UI2.WinForms.Guna2ShadowForm shadowForm;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
    }
}