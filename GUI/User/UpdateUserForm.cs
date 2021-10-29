using Dev69Restaurant.Common;
using Dev69Restaurant.DAL.Services;
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

namespace Dev69Restaurant.GUI.User
{
    public partial class UpdateUserForm : Form
    {
        #region properties
        private DTO.Entities.User _currentUser;
        private UserService _userService;
        public event UserDelegate userDelegate;
        public UpdateUserForm(DTO.Entities.User user)
        {
            InitializeComponent();
            this.Icon = new Icon(BaseIcon.ICON);

            _currentUser = user;
            _userService = new UserService();
            LoadData();
        }
        #endregion

        #region Events
        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            try
            {
                ValidateForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void UpdateUserForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            userDelegate();
        }
        #endregion

        #region methods
        public void LoadData()
        {
            LoadRole();
            LoadStatus();
            LoadInfoUser();
        }

        private void ValidateForm()
        {
            DTO.Entities.User user = new DTO.Entities.User();
            user.Username = txtUsername.Text;

            //if (string.IsNullOrEmpty(txtPassword.Text) || txtPassword.Text.Length < 6)
            //{
            //    MessageBox.Show("Mật khẩu phải chứa ít nhất 6 kí tự.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}
            if (!string.IsNullOrEmpty(txtPassword.Text))
            {
                if(txtPassword.Text.Length < 6)
                {
                    MessageBox.Show("Mật khẩu phải chứa ít nhất 6 kí tự.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    string password = Encryptor.MD5Hash(txtPassword.Text);
                    user.Password = password;
                }

            }
            else
            {
                user.Password = _userService.GetInfo(_currentUser).Password;
            }
            user.DisplayName = txtDisplayName.Text;

            if (string.IsNullOrEmpty(txtFullName.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                user.FullName = txtFullName.Text;
            }

            string status = cmbStatus.SelectedValue.ToString();
            if (status == "Khóa")
            {
                user.Status = false;
            }
            else
            {
                user.Status = true;
            }

            int roleId = int.Parse(cmbRole.SelectedValue.ToString());
            _userService.UpdateRoleByUsername(user.Username, roleId);

            _userService.Update(user);
            MessageBox.Show("Cập nhật thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void LoadInfoUser()
        {
            var user = _userService.GetInfo(_currentUser);
            txtUsername.Text= user.Username;
            //txtPassword.Text = user.Password;
            txtDisplayName.Text= user.DisplayName;
            txtFullName.Text= user.FullName;
            
            if(user.Status == true)
            {
                cmbStatus.SelectedIndex = 0;
            }
            else
            {
                cmbStatus.SelectedIndex = 1;
            }

            LoadUserRoleDetail(user.Username);
        }

        private void LoadRole()
        {
            var listRoles = _userService.GetAllRole();
            cmbRole.DataSource = listRoles.ToList();
            cmbRole.DisplayMember = "Name";
            cmbRole.ValueMember = "Id";
        }

        private void LoadStatus()
        {
            string[] status = { "Kích Hoạt", "Khóa" };
            cmbStatus.DataSource = status.ToList();
        }

        private void LoadUserRoleDetail(string username)
        {
            var userRole = _userService.GetRoleByUsername(username);
            var listRoles = _userService.GetAllRole();
            foreach (var item in listRoles)
            {
                if (userRole.Role.ShortName == item.ShortName)
                {
                    cmbRole.SelectedValue = item.Id;
                }
            }
        }
        #endregion
    }
}
