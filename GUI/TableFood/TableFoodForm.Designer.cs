
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TableFoodForm));
            this.pnTableFood = new System.Windows.Forms.FlowLayoutPanel();
            this.ucTableFood1 = new Dev69Restaurant.Infrastructure.Components.UserControls.UCTableFood();
            this.ucTableFood2 = new Dev69Restaurant.Infrastructure.Components.UserControls.UCTableFood();
            this.pnTableFood.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnTableFood
            // 
            this.pnTableFood.Controls.Add(this.ucTableFood1);
            this.pnTableFood.Controls.Add(this.ucTableFood2);
            this.pnTableFood.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnTableFood.Location = new System.Drawing.Point(0, 0);
            this.pnTableFood.Name = "pnTableFood";
            this.pnTableFood.Size = new System.Drawing.Size(800, 450);
            this.pnTableFood.TabIndex = 0;
            // 
            // ucTableFood1
            // 
            this.ucTableFood1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ucTableFood1.BackgroundImage")));
            this.ucTableFood1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ucTableFood1.Location = new System.Drawing.Point(15, 15);
            this.ucTableFood1.Margin = new System.Windows.Forms.Padding(15);
            this.ucTableFood1.Name = "ucTableFood1";
            this.ucTableFood1.Size = new System.Drawing.Size(220, 200);
            this.ucTableFood1.TabIndex = 0;
            // 
            // ucTableFood2
            // 
            this.ucTableFood2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ucTableFood2.BackgroundImage")));
            this.ucTableFood2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ucTableFood2.Location = new System.Drawing.Point(265, 15);
            this.ucTableFood2.Margin = new System.Windows.Forms.Padding(15);
            this.ucTableFood2.Name = "ucTableFood2";
            this.ucTableFood2.Size = new System.Drawing.Size(220, 200);
            this.ucTableFood2.TabIndex = 1;
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
            this.Text = "TableFoodForm";
            this.pnTableFood.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pnTableFood;
        private Infrastructure.Components.UserControls.UCTableFood ucTableFood1;
        private Infrastructure.Components.UserControls.UCTableFood ucTableFood2;
    }
}