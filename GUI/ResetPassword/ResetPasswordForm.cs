using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Dev69Restaurant.DAL.Services;
using Dev69Restaurant.Common;

namespace Dev69Restaurant.GUI.ResetPassword
{
    public partial class ResetPasswordForm : Form
    {
        private UserService _userService;
        string email = VerifyCodeForm.to;
        string username = VerifyCodeForm.user;
        public ResetPasswordForm()
        {
            InitializeComponent();
            _userService = new UserService();
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            if(txtNewPassword.Text == txtConfirmPass.Text)
            {
                var user = _userService.GetByUsername(username);
                user.Password = Encryptor.MD5Hash(txtNewPassword.Text);
                _userService.UpdatePassword(user);
                MessageBox.Show("Đổi mật khẩu thành công!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Mật khẩu xác nhận không trùng khớp!");
            }
        }
    }
}
