using Dev69Restaurant.GUI.Manager;
using Dev69Restaurant.GUI.TableFood;
using Dev69Restaurant.Infrastructure.Settings;
using Guna.UI.WinForms;
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
            ActivateButton(sender, BaseIcon.HOME_ACTIVE);
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
            ActivateButton(sender, BaseIcon.TABLE_FOOD_ACTIVE);
        }

        private void btnFood_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, BaseIcon.FOOD_ACTIVE);
        }

        private void btnStatistic_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, BaseIcon.STATISTIC_ACTIVE);
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, BaseIcon.SETTING_ACTIVE);
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, BaseIcon.ABOUT_ACTIVE);
        }

        private void btnManageUser_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, BaseIcon.USER_GROUP_ACTIVE);
            ManagerForm managerForm = new ManagerForm();
            managerForm.StartPosition = FormStartPosition.CenterScreen;
            managerForm.Show();
        }

        private void tgbtnSwitchTheme_CheckedChanged(object sender, EventArgs e)
        {
            if (tgbtnSwitchTheme.Checked)
            {
                this.BackColor = BaseColor.BACK_COLOR_DARK;
                pnLeft.BackColor = BaseColor.PANNEL_DARK;
                pnFeature.BackColor = BaseColor.PANNEL_DARK;
                pnRight.BackColor = BaseColor.PANNEL_DARK;
                pnMain.BackColor = BaseColor.PANNEL_DARK;

                foreach (Control button in pnLeft.Controls)
                {
                    if (button is Guna2GradientButton)
                    {
                        (button as Guna2GradientButton).BackColor = BaseColor.BUTTON_DARK;
                        (button as Guna2GradientButton).ForeColor = BaseColor.FORE_COLOR_DARK;
                        (button as Guna2GradientButton).FillColor = BaseColor.BUTTON_DARK;
                        (button as Guna2GradientButton).FillColor2 = BaseColor.BUTTON_DARK;
                    }
                }

                foreach (Control button in pnTop.Controls)
                {
                    if (button is GunaControlBox)
                    {
                        (button as GunaControlBox).BackColor = BaseColor.BUTTON_DARK;
                        (button as GunaControlBox).IconColor = BaseColor.FORE_COLOR_DARK;
                    }
                }

                btnHome.CustomImages.Image = Image.FromFile(BaseIcon.HOME_DARK);
                btnTableFood.CustomImages.Image = Image.FromFile(BaseIcon.TABLE_FOOD_DARK);
                btnFood.CustomImages.Image = Image.FromFile(BaseIcon.FOOD_DARK);
                btnStatistic.CustomImages.Image = Image.FromFile(BaseIcon.STATISTIC_DARK);
                btnManage.CustomImages.Image = Image.FromFile(BaseIcon.USER_GROUP_DARK);
                btnSetting.CustomImages.Image = Image.FromFile(BaseIcon.SETTING_DARK);
                btnAbout.CustomImages.Image = Image.FromFile(BaseIcon.ABOUT_DARK);
                btnToogleMenu.Image = Image.FromFile(BaseIcon.TOOGLE_MENU_DARK);
            }
            else
            {
                this.BackColor = BaseColor.BACK_COLOR_LIGHT;
                pnLeft.BackColor = BaseColor.PANNEL_LIGHT;
                pnFeature.BackColor = BaseColor.PANNEL_LIGHT;
                pnRight.BackColor = BaseColor.PANNEL_LIGHT;
                pnMain.BackColor = BaseColor.PANNEL_LIGHT;

                foreach (Control button in pnTop.Controls)
                {
                    if (button is GunaControlBox)
                    {
                        (button as GunaControlBox).BackColor = BaseColor.BUTTON_LIGHT;
                        (button as GunaControlBox).IconColor = BaseColor.FORE_COLOR_LIGHT;
                    }
                }

                foreach (Control button in pnLeft.Controls)
                {
                    if (button is Guna2GradientButton)
                    {
                        (button as Guna2GradientButton).BackColor = BaseColor.BUTTON_LIGHT;
                        (button as Guna2GradientButton).ForeColor = BaseColor.FORE_COLOR_LIGHT;
                        (button as Guna2GradientButton).FillColor = BaseColor.BUTTON_LIGHT;
                        (button as Guna2GradientButton).FillColor2 = BaseColor.BUTTON_LIGHT;
                    }
                }

                btnHome.CustomImages.Image = Image.FromFile(BaseIcon.HOME);
                btnTableFood.CustomImages.Image = Image.FromFile(BaseIcon.TABLE_FOOD);
                btnFood.CustomImages.Image = Image.FromFile(BaseIcon.FOOD);
                btnStatistic.CustomImages.Image = Image.FromFile(BaseIcon.STATISTIC);
                btnManage.CustomImages.Image = Image.FromFile(BaseIcon.USER_GROUP);
                btnSetting.CustomImages.Image = Image.FromFile(BaseIcon.SETTING);
                btnAbout.CustomImages.Image = Image.FromFile(BaseIcon.ABOUT);
                btnToogleMenu.Image = Image.FromFile(BaseIcon.TOOGLE_MENU);
            }
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
                _currentButton.ForeColor = BaseColor.FORE_COLOR_LIGHT_ACTIVE;
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
                    _currentButton.ForeColor = BaseColor.FORE_COLOR_LIGHT;
                    _currentButton.CustomImages.Image = _currentButton.CustomImages.CheckedImage;
                }
            }
        }
        #endregion
    }
}
