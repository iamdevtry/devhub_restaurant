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
    public partial class UserForm : Form
    {
        private UserService _userService;
        public UserForm()
        {
            InitializeComponent();
            _userService = new UserService();
            LoadData();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            CreateUserForm createUserForm = new CreateUserForm();
            createUserForm.StartPosition = FormStartPosition.CenterScreen;
            createUserForm.ShowDialog();
        }

        private void LoadData()
        {
            LoadDataUser();
        }

        private void LoadDataUser()
        {
            var listUsers = _userService.GetAll().ToList();
            int index = dgvListUser.Rows.Count;

            foreach(var item in listUsers)
            {
                index++;
                dgvListUser.Rows.Add(index, item.FullName, item.DisplayName, item.Username,item.BirthDay,item.Address,item.Phone,item.Status);
            }
            //dgvListUser.DataSource = _userService.GetAll().ToList();
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            DTO.Entities.User user = new DTO.Entities.User();

            var currentUser = dgvListUser.SelectedCells[3].Value.ToString();
            user.Username = currentUser;

            UpdateUserForm updateUserForm = new UpdateUserForm(user);
            updateUserForm.StartPosition = FormStartPosition.CenterScreen;
            updateUserForm.ShowDialog();
        }
    }
}
