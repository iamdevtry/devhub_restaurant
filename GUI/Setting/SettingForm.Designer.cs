
namespace Dev69Restaurant.GUI.Setting
{
    partial class SettingForm
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
            this.tgbtnSwitchTheme = new Dev69Restaurant.Infrastructure.Components.UserControls.UCToggleButton();
            this.SuspendLayout();
            // 
            // tgbtnSwitchTheme
            // 
            this.tgbtnSwitchTheme.Location = new System.Drawing.Point(505, 101);
            this.tgbtnSwitchTheme.MinimumSize = new System.Drawing.Size(45, 22);
            this.tgbtnSwitchTheme.Name = "tgbtnSwitchTheme";
            this.tgbtnSwitchTheme.OffBackColor = System.Drawing.Color.Gray;
            this.tgbtnSwitchTheme.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.tgbtnSwitchTheme.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.tgbtnSwitchTheme.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.tgbtnSwitchTheme.Size = new System.Drawing.Size(46, 22);
            this.tgbtnSwitchTheme.TabIndex = 1;
            this.tgbtnSwitchTheme.Text = "ucToggleButton1";
            this.tgbtnSwitchTheme.UseVisualStyleBackColor = true;
            this.tgbtnSwitchTheme.CheckedChanged += new System.EventHandler(this.tgbtnSwitchTheme_CheckedChanged);
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tgbtnSwitchTheme);
            this.Name = "SettingForm";
            this.Text = "SettingForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Infrastructure.Components.UserControls.UCToggleButton tgbtnSwitchTheme;
    }
}