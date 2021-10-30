using Dev69Restaurant.Common;
using Dev69Restaurant.DAL.Services;
using Dev69Restaurant.Infrastructure.Settings;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dev69Restaurant.GUI.ResetPassword
{
    public partial class VerifyCodeForm : Form
    {
        string randomCode;
        public static string to, user;
        private UserService _userService;

        public VerifyCodeForm()
        {
            InitializeComponent();
            this.Icon = new Icon(BaseIcon.ICON);

            _userService = new UserService();
        }

        private void btnSendCode_Click(object sender, EventArgs e)
        {
            if (ValidateAccount(txtUsername.Text, txtEmail.Text) == 1)
            {
                string from, pass, message;
                Random random = new Random();
                randomCode = (random.Next(999999)).ToString();
                MailMessage mail = new MailMessage();
                to = (txtEmail.Text).ToString();
                from = ConfigHelper.GetByKey("FromEmailAddress");
                pass = ConfigHelper.GetByKey("FromEmailPassword");
                message = "Mã xác nhận tạo mới mật khẩu của bạn là: " + randomCode;
                mail.To.Add(to);
                mail.From = new MailAddress(from);
                mail.Body = message;
                mail.Subject = "Mã khôi phục mật khẩu!";
                SmtpClient smtp = new SmtpClient(ConfigHelper.GetByKey("SMTPHost"));
                smtp.EnableSsl = true;
                smtp.Port = int.Parse(ConfigHelper.GetByKey("SMTPPort"));
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Credentials = new NetworkCredential(from, pass);
                try
                {
                    smtp.Send(mail);
                    MessageBox.Show("Mã xác nhận đã được gửi, hãy kiểm tra email của bạn!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc email không tồn tại!");
            }
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            if(randomCode == txtVerifyCode.Text)
            {
                to = txtEmail.Text;
                user = txtUsername.Text;
                ResetPasswordForm resetPasswordForm = new ResetPasswordForm();
                this.Hide();
                resetPasswordForm.Show();
            }
            else
            {
                MessageBox.Show("Mã xác nhận không tồn tại!");
            }
        }

        private void VerifyCodeForm_Load(object sender, EventArgs e)
        {
            shadowForm.SetShadowForm(this);
        }

        private int ValidateAccount(string username, string email)
        {
            if (string.IsNullOrEmpty(txtUsername.Text) && string.IsNullOrEmpty(txtEmail.Text))
            {
                return -1;
            }
            else
            {
                var user = _userService.CheckExistByUserNameAndEmail(username, email);
                if (user)
                {
                    return -1;
                }
                else
                {
                    return 1;
                }
            }

        }
    }
}
