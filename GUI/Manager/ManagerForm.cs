using Dev69Restaurant.GUI.Revenue;
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
    }
}
