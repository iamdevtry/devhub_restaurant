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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dev69Restaurant.GUI.User
{
    public partial class CreateUserForm : Form
    {
        private UserService _userService;
        public event UserDelegate userDelegate;
        public CreateUserForm()
        {
            InitializeComponent();
            this.Icon = new Icon(BaseIcon.ICON);

            _userService = new UserService();
            LoadRole();
            LoadStatus();
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
            userDelegate(); 
        }

        #endregion

        #region methods
        private void ValidateForm()
        {
            DTO.Entities.User user = new DTO.Entities.User();

            string myString = txtUsername.Text;
            var reg = new Regex("^[a-zA-Z0-9]*$").IsMatch(myString);

            if (!reg)
            {
                MessageBox.Show("Tên đăng nhập chỉ được chứa các kí tự từ A-Z, 0-9 và không được có khoảng trắng", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên đăng nhập", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                user.Username = txtUsername.Text;
            }

            if (string.IsNullOrEmpty(txtPassword.Text) || txtPassword.Text.Length < 6)
            {
                MessageBox.Show("Mật khẩu phải chứa ít nhất 6 kí tự.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                string password = Encryptor.MD5Hash(txtPassword.Text);
                user.Password = password;
            }

            if (string.IsNullOrEmpty(txtFullName.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                user.FullName = txtFullName.Text;
            }


            user.DisplayName = txtDisplayName.Text;
            user.Phone = txtPhone.Text;
            user.Address = txtAddress.Text;

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

            if (_userService.CheckExist(user.Username))
            {
                _userService.Add(user);
                AddUserIntoUserRole(user.Username, roleId);
                MessageBox.Show("Thêm mới người thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetFields();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập đã tồn tại!", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            string[] status = {"Kích Hoạt","Khóa" };
            cmbStatus.DataSource = status.ToList();
        }

        private void ResetFields()
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtDisplayName.Text = "";
            txtFullName.Text = "";
            txtPhone.Text = "";
        }

        private void AddUserIntoUserRole(string username, int roleId)
        {
            _userService.AddUserIntoUserRole(username, roleId);
        }

        #endregion
    }
}
