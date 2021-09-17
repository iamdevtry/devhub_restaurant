using Dev69Restaurant.GUI.TableFood;
using Dev69Restaurant.Settings;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dev69Restaurant.GUI.Home
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        #region Fields
        private bool isCollapse = false;
        private Guna2GradientButton _currentButton;
        #endregion

        #region Events
        private void btnToogleMenu_Click(object sender, EventArgs e)
        {
            ShowHideLeftBar();
        }

        private Form activeForm = null;
        private void btnHome_Click(object sender, EventArgs e)
        {
            ActivateButton(sender,BaseIcon.HOME_ACTIVE);
            TableFoodForm tableFood = new TableFoodForm();
            activeForm = tableFood;
            tableFood.TopLevel = false;
            tableFood.AutoScroll = true;
            //childForm.FormBorderStyle = FormBorderStyle.None;
            tableFood.Dock = DockStyle.Fill;
            pnMain.Controls.Add(tableFood);
            tableFood.Show();
        }

        private void btnTableFood_Click(object sender, EventArgs e)
        {
            ActivateButton(sender,BaseIcon.TABLE_FOOD_ACTIVE);
        }

        private void btnFood_Click(object sender, EventArgs e)
        {
            ActivateButton(sender,BaseIcon.FOOD_ACTIVE);
        }

        private void btnStatistic_Click(object sender, EventArgs e)
        {
            ActivateButton(sender,BaseIcon.STATISTIC_ACTIVE);
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            ActivateButton(sender,BaseIcon.SETTING_ACTIVE);
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            ActivateButton(sender,BaseIcon.ABOUT_ACTIVE);
        }

        #endregion

        #region methods
        private void ShowHideLeftBar()
        {
            if (!isCollapse)
            {
                pnLeft.Visible = false;
                pnLeft.Width = 80;
                gnTransition.ShowSync(pnLeft);
                isCollapse = true;
            }
            else
            {
                pnLeft.Visible = false;
                pnLeft.Width = 320 - 80;
                gnTransition.ShowSync(pnLeft);
                isCollapse = false;
            }
        }

        private void ActivateButton(object sender, string iconActive)
        {
            if (sender != null)
            {
                DisableButton();

                _currentButton = (Guna2GradientButton)sender;

                _currentButton.CustomImages.CheckedImage = _currentButton.CustomImages.Image;

                _currentButton.FillColor = BaseColor.PRESS_COLOR_PRIMARY_ACTIVE;
                _currentButton.FillColor2 = BaseColor.PRESS_COLOR_PRIMARY_ACTIVE;
                _currentButton.ForeColor = BaseColor.FORE_COLOR_PRIMARY_ACTIVE;
                _currentButton.CustomImages.Image = Image.FromFile(iconActive);

            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in pnLeft.Controls)
            {
                if (previousBtn.GetType() == typeof(Guna2GradientButton))
                {
                    _currentButton = (Guna2GradientButton)previousBtn;

                    _currentButton.FillColor = BaseColor.BUTTON_LIGHT;
                    _currentButton.FillColor2 = BaseColor.BUTTON_LIGHT;
                    _currentButton.ForeColor = BaseColor.FORE_COLOR_PRIMARY;
                    _currentButton.CustomImages.Image = _currentButton.CustomImages.CheckedImage;
                }
            }
        }
        #endregion

    }
}
