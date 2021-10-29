
namespace Dev69Restaurant.GUI.Food
{
    partial class FoodForm
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
            this.pnFood = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // pnFood
            // 
            this.pnFood.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnFood.Location = new System.Drawing.Point(0, 0);
            this.pnFood.Name = "pnFood";
            this.pnFood.Size = new System.Drawing.Size(800, 450);
            this.pnFood.TabIndex = 1;
            // 
            // FoodForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnFood);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FoodForm";
            this.Text = "Món ăn";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pnFood;

    }
}