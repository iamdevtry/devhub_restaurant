using Dev69Restaurant.GUI.ManageDiscount;
using Dev69Restaurant.GUI.ManageFood;
using Dev69Restaurant.GUI.Revenue;
using Dev69Restaurant.GUI.Stastic;
using Dev69Restaurant.GUI.TableFood;
using Dev69Restaurant.GUI.User;
using Dev69Restaurant.Infrastructure.Settings;
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

namespace Dev69Restaurant.GUI.Manager
{
    public partial class ManagerForm : Form
    {
        private Form activeForm = null;
        private Guna2GradientButton _currentButton;
        public ManagerForm()
        {
            InitializeComponent();
            this.Icon = new Icon(BaseIcon.ICON);

        }

        private void btnManageStaff_Click(object sender, EventArgs e)
        {
            HideFormActive();
            ActivateButton(sender, BaseIcon.USER_GROUP_HOVER);
            UserForm userForm = new UserForm();
            activeForm = userForm;
            userForm.TopLevel = false;
            userForm.AutoScroll = true;
            //childForm.FormBorderStyle = FormBorderStyle.None;
            userForm.Dock = DockStyle.Fill;
            pnMain.Controls.Add(userForm);
            userForm.Show();
        }

        private void btnRevenue_Click(object sender, EventArgs e)
        {
            HideFormActive();
            ActivateButton(sender, BaseIcon.BAR_CHART_HOVER);
            RevenueForm revenueForm = new RevenueForm();
            activeForm = revenueForm;
            revenueForm.TopLevel = false;
            revenueForm.AutoScroll = true;
            //childForm.FormBorderStyle = FormBorderStyle.None;
            revenueForm.Dock = DockStyle.Fill;
            pnMain.Controls.Add(revenueForm);
            revenueForm.Show();
        }

        private void btnTableFood_Click(object sender, EventArgs e)
        {
            HideFormActive();
            ActivateButton(sender, BaseIcon.TABLE_FOOD_ACTIVE);
            ManageTableFoodForm manageTableFoodForm = new ManageTableFoodForm();
            activeForm = manageTableFoodForm;
            manageTableFoodForm.TopLevel = false;
            manageTableFoodForm.AutoScroll = true;
            //childForm.FormBorderStyle = FormBorderStyle.None;
            manageTableFoodForm.Dock = DockStyle.Fill;
            pnMain.Controls.Add(manageTableFoodForm);
            manageTableFoodForm.Show();

        }

        private void btnFood_Click(object sender, EventArgs e)
        {
            HideFormActive();
            ActivateButton(sender, BaseIcon.FOOD_ACTIVE);
            ManageFoodForm manageFoodForm = new ManageFoodForm();
            activeForm = manageFoodForm;
            manageFoodForm.TopLevel = false;
            manageFoodForm.AutoScroll = true;
            //childForm.FormBorderStyle = FormBorderStyle.None;
            manageFoodForm.Dock = DockStyle.Fill;
            pnMain.Controls.Add(manageFoodForm);
            manageFoodForm.Show();
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            HideFormActive();
            ActivateButton(sender, BaseIcon.REVENUE_HOVER);
            StasticForm stasticForm = new StasticForm();
            activeForm = stasticForm;
            stasticForm.TopLevel = false;
            stasticForm.AutoScroll = true;
            //childForm.FormBorderStyle = FormBorderStyle.None;
            stasticForm.Dock = DockStyle.Fill;
            pnMain.Controls.Add(stasticForm);
            stasticForm.Show();
        }

        private void btnDiscount_Click(object sender, EventArgs e)
        {
            HideFormActive();
            ActivateButton(sender, BaseIcon.DISCOUNT_HOVER);
            DiscountForm discountForm = new DiscountForm();
            activeForm = discountForm;
            discountForm.TopLevel = false;
            discountForm.AutoScroll = true;
            //childForm.FormBorderStyle = FormBorderStyle.None;
            discountForm.Dock = DockStyle.Fill;
            pnMain.Controls.Add(discountForm);
            discountForm.Show();
        }

        private void HideFormActive()
        {
            if (activeForm != null)
            {
                activeForm.Hide();
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
    }
}
