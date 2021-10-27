using Dev69Restaurant.GUI.ManageDiscount;
using Dev69Restaurant.GUI.ManageFood;
using Dev69Restaurant.GUI.Revenue;
using Dev69Restaurant.GUI.Stastic;
using Dev69Restaurant.GUI.TableFood;
using Dev69Restaurant.GUI.User;
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
        public ManagerForm()
        {
            InitializeComponent();
        }

        private void btnManageStaff_Click(object sender, EventArgs e)
        {
            UserForm userForm = new UserForm();
            userForm.TopLevel = false;
            userForm.AutoScroll = true;
            //childForm.FormBorderStyle = FormBorderStyle.None;
            userForm.Dock = DockStyle.Fill;
            pnMain.Controls.Add(userForm);
            userForm.Show();
        }

        private void btnRevenue_Click(object sender, EventArgs e)
        {
            RevenueForm revenueForm = new RevenueForm();
            revenueForm.TopLevel = false;
            revenueForm.AutoScroll = true;
            //childForm.FormBorderStyle = FormBorderStyle.None;
            revenueForm.Dock = DockStyle.Fill;
            pnMain.Controls.Add(revenueForm);
            revenueForm.Show();
        }

        private void btnTableFood_Click(object sender, EventArgs e)
        {
            ManageTableFoodForm manageTableFoodForm = new ManageTableFoodForm();
            manageTableFoodForm.TopLevel = false;
            manageTableFoodForm.AutoScroll = true;
            //childForm.FormBorderStyle = FormBorderStyle.None;
            manageTableFoodForm.Dock = DockStyle.Fill;
            pnMain.Controls.Add(manageTableFoodForm);
            manageTableFoodForm.Show();
        }

        private void btnFood_Click(object sender, EventArgs e)
        {
            ManageFoodForm manageFoodForm = new ManageFoodForm();
            manageFoodForm.TopLevel = false;
            manageFoodForm.AutoScroll = true;
            //childForm.FormBorderStyle = FormBorderStyle.None;
            manageFoodForm.Dock = DockStyle.Fill;
            pnMain.Controls.Add(manageFoodForm);
            manageFoodForm.Show();
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            StasticForm stasticForm = new StasticForm();
            stasticForm.TopLevel = false;
            stasticForm.AutoScroll = true;
            //childForm.FormBorderStyle = FormBorderStyle.None;
            stasticForm.Dock = DockStyle.Fill;
            pnMain.Controls.Add(stasticForm);
            stasticForm.Show();
        }

        private void btnDiscount_Click(object sender, EventArgs e)
        {
            DiscountForm discountForm = new DiscountForm();
            discountForm.TopLevel = false;
            discountForm.AutoScroll = true;
            //childForm.FormBorderStyle = FormBorderStyle.None;
            discountForm.Dock = DockStyle.Fill;
            pnMain.Controls.Add(discountForm);
            discountForm.Show();
        }
    }
}
