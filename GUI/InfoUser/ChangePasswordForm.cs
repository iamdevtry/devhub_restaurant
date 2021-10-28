using Dev69Restaurant.DAL.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dev69Restaurant.GUI.InfoUser
{
    public partial class ChangePasswordForm : Form
    {
        private DTO.Entities.User _currentUser;
        private UserService _userService;
        public ChangePasswordForm()
        {
            InitializeComponent();
        }

        public ChangePasswordForm(DTO.Entities.User user)
        {
            InitializeComponent();
            _currentUser = user;
            _userService = new UserService();
        }

        private void btnUpdatePass_Click(object sender, EventArgs e)
        {
            try
            {
                var user = _userService.GetInfo(_currentUser);
                if (ValidateForm(user) == 1)
                {
                    user.Password = txtNewPass.Text;
                    _userService.UpdatePassword(user);
                    MessageBox.Show("Đổi mật khẩu thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private int ValidateForm(DTO.Entities.User user)
        {
            if (txtOldPass.Text != user.Password)
            {
                MessageBox.Show("Mật khẩu cũ không đúng. Hãy nhập lại!", "Sai mật khẩu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
            else if (txtNewPass.Text != txtConfirmPass.Text)
            {
                MessageBox.Show("Mật khẩu xác nhận không trùng khớp mật khẩu mới. Hãy nhập lại!", "Sai mật khẩu xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
            else if (txtNewPass.Text.ToString().Length < 6)
            {
                MessageBox.Show("Mật khẩu không được ít hơn 6 kí tự", "Mật khẩu quá ngắn", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
            else
            {
                return 1;
            }
        }
    }
}
