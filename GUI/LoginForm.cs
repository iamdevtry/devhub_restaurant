using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dev69Restaurant.GUI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            LoadForm();
        }


        #region Methods
        private void LoadForm()
        {
            btnHidePassword.Visible = false;
            btnShowPassword.Visible = true;
            txtPassword.UseSystemPasswordChar = true;
        }
        private void ShowPassword()
        {
            if(btnHidePassword.Visible == false)
            {
                btnHidePassword.Visible = true;
                btnShowPassword.Visible = false;
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                btnHidePassword.Visible = false;
                btnShowPassword.Visible = true;
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void btnHidePassword_Click(object sender, EventArgs e)
        {
            ShowPassword();
        }

        private void btnShowPassword_Click(object sender, EventArgs e)
        {
            ShowPassword();
        }

        #endregion
    }
}
