using Dev69Restaurant.Common;
using Dev69Restaurant.DAL.Services;
using Dev69Restaurant.GUI.Home;
using Dev69Restaurant.GUI.ResetPassword;
using Dev69Restaurant.Infrastructure.Settings;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dev69Restaurant.GUI.Login
{
    public partial class LoginForm : Form
    {
        private LoginService _loginService;
        public LoginForm()
        {
            InitializeComponent();

            this.Icon = new Icon(BaseIcon.ICON);
            _loginService = new LoginService();
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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string password = Encryptor.MD5Hash(txtPassword.Text);
            var user = _loginService.Login(txtUsername.Text, password);
            var userRole = _loginService.GetRoleByUsername(txtUsername.Text);

            if (user != null)
            {
                HomeForm homeForm = new HomeForm(user,userRole.ShortName);
                this.Hide();
                homeForm.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng.", "Đăng nhập thất bại", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        #endregion

        private void lblForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            VerifyCodeForm verifyCodeForm = new VerifyCodeForm();
            verifyCodeForm.StartPosition = FormStartPosition.CenterScreen;
            verifyCodeForm.Show();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            shadowForm.SetShadowForm(this);
        }
    }
}
