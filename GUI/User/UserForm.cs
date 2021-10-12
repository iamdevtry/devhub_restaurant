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

        #region Events
        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    SearchUser();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            try
            {
                string username = dgvListUser.SelectedCells[3].Value.ToString();
                _userService.Delete(username);
                MessageBox.Show("Xóa bản ghi thành công!", "Thành công!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDataUser();
            }
            catch
            {
                MessageBox.Show("Xóa bản ghi không thành công!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            CreateUserForm createUserForm = new CreateUserForm();
            createUserForm.StartPosition = FormStartPosition.CenterScreen;

            createUserForm.userDelegate += CreateUserForm_userDelegate;

            createUserForm.ShowDialog();
        }

        private void CreateUserForm_userDelegate()
        {
            LoadDataUser();
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            try
            {
                ShowUpdateUserForm();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                SearchUser();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region Methods
        private void LoadData()
        {
            LoadDataUser();
        }

        private void SearchUser()
        {
            string keyword = txtSearch.Text;
            var result = _userService.GetAll(keyword).ToList();
            if (result.Count > 0)
            {
                LoadDataUser(keyword);
            }
            else
            {
                MessageBox.Show("Không tìm thấy bản ghi nào.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void LoadDataUser(string keyword = null)
        {
            dgvListUser.Rows.Clear();
            var listUsers = _userService.GetAll(keyword).ToList();
            int index = dgvListUser.Rows.Count;

            foreach (var item in listUsers)
            {
                index++;
                string status = item.Status ? "Kích Hoạt" : "Khóa";
                dgvListUser.Rows.Add(index, item.FullName, item.DisplayName, item.Username, item.BirthDay, item.Address, item.Phone, status);
            }
        }

        private void ShowUpdateUserForm()
        {
            DTO.Entities.User user = new DTO.Entities.User();

            if (dgvListUser.Rows.Count < 1)
            {
                MessageBox.Show("Không có dữ liệu để cập nhật.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (dgvListUser.SelectedCells[3].Value != null)
                {
                    var currentUser = dgvListUser.SelectedCells[3].Value.ToString();
                    user.Username = currentUser;

                    UpdateUserForm updateUserForm = new UpdateUserForm(user);
                    updateUserForm.StartPosition = FormStartPosition.CenterScreen;
                    updateUserForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy tài khoản.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        #endregion
    }
}
