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
    public partial class UpdateUserForm : Form
    {
        #region properties
        private DTO.Entities.User _currentUser;
        private UserService _userService;
        public UpdateUserForm(DTO.Entities.User user)
        {
            InitializeComponent();
            _currentUser = user;
            _userService = new UserService();
            LoadData();
        }
        #endregion

        #region Events

        #endregion

        #region methods
        public void LoadData()
        {
            LoadInfoUser();
        }

        private void LoadInfoUser()
        {
            var user = _userService.GetInfo(_currentUser);
            txtUsername.Text= user.Username;
            txtPassword.Text = user.Password;
            txtDisplayName.Text= user.DisplayName;
            txtFullName.Text= user.FullName;
        }
        #endregion

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            try
            {
                DTO.Entities.User user = new DTO.Entities.User();
                user.Username = txtUsername.Text;
                user.Password = txtPassword.Text;
                user.DisplayName = txtDisplayName.Text;
                user.FullName = txtFullName.Text;
                user.Status = true;

                _userService.Update(user);
                MessageBox.Show("Cập nhật thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
