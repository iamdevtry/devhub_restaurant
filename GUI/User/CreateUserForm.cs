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

namespace Dev69Restaurant.GUI.User
{
    public partial class CreateUserForm : Form
    {
        private UserService _userService;
        public CreateUserForm()
        {
            InitializeComponent();
            _userService = new UserService();

        }

        #region events
        private void CreateUserForm_Load(object sender, EventArgs e)
        {
            gnShadowForm.SetShadowForm(this);
        }

        private void btnRegisterUser_Click(object sender, EventArgs e)
        {
            try
            {
                ValidateForm();
            }
            catch
            {
                MessageBox.Show("Thêm mới người dùng không thành công!", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void CreateUserForm_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        #endregion

        #region methods
        private void ValidateForm()
        {
            DTO.Entities.User user = new DTO.Entities.User();
            if (string.IsNullOrEmpty(txtUsername.Text) || txtUsername.Text.Any(Char.IsWhiteSpace))
            {
                MessageBox.Show("Loi");
                return;
            }
            else
            {
                user.Username = txtUsername.Text;
            }

            if (string.IsNullOrEmpty(txtPassword.Text) || txtPassword.Text.Length < 6)
            {
                MessageBox.Show("Mật khẩu phải chứa ít nhất 6 kí tự.");
                return;
            }
            else
            {
                user.Password = txtPassword.Text;
            }

            if (string.IsNullOrEmpty(txtFullName.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên. ");
                return;
            }
            else
            {
                user.FullName = txtFullName.Text;
            }


            user.DisplayName = txtDisplayName.Text;
            user.BirthDay = Convert.ToDateTime(dtpBirthDay.Value.ToShortDateString());
            user.Phone = txtPhone.Text;
            user.Email = txtEmail.Text;
            user.Address = txtAddress.Text;
            user.Status = true;

            if (_userService.CheckExist(user.Username))
            {
                _userService.Add(user);
                MessageBox.Show("Thêm mới người thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetFields();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập đã tồn tại!", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ResetFields()
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtDisplayName.Text = "";
            txtFullName.Text = "";
            txtPhone.Text = "";
            txtEmail.Text = "";
        }

        #endregion
    }
}
