
namespace Dev69Restaurant.GUI.TableFood
{
    partial class TableFoodForm
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
            this.pnTableFood = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // pnTableFood
            // 
            this.pnTableFood.AutoScroll = true;
            this.pnTableFood.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnTableFood.Location = new System.Drawing.Point(0, 0);
            this.pnTableFood.Name = "pnTableFood";
            this.pnTableFood.Size = new System.Drawing.Size(800, 450);
            this.pnTableFood.TabIndex = 0;
            // 
            // TableFoodForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnTableFood);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TableFoodForm";
            this.Text = "Bàn ăn";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pnTableFood;
    }
}