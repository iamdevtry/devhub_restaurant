﻿using Dev69Restaurant.DAL.Services;
using Dev69Restaurant.Infrastructure.Settings;
using System;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace Dev69Restaurant.GUI.User
{
    public partial class UserForm : Form
    {
        private UserService _userService;
        Thread loadDataUserThread;
        public UserForm()
        {
            InitializeComponent();
            this.Icon = new Icon(BaseIcon.ICON);

            Control.CheckForIllegalCrossThreadCalls = false;

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
                DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xóa tài khoản {username} ?", "Cảnh báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    _userService.Delete(username);
                    MessageBox.Show("Xóa bản ghi thành công!", "Thành công!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDataUser();
                }
                else
                {
                    return;
                }
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

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            try
            {
                ShowUpdateUserForm();
            }
            catch (Exception ex)
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

        private void CreateUserForm_userDelegate()
        {
            LoadDataUser();
        }
        private void UpdateUserForm_userDelegate()
        {
            LoadDataUser();
        }
        #endregion

        #region Methods

        private void LoadData()
        {
            loadDataUserThread = new Thread(() => LoadDataUser());
            loadDataUserThread.IsBackground = true;
            loadDataUserThread.Start();
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
                var topLeftHeaderCell = dgvListUser.TopLeftHeaderCell;
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
                    updateUserForm.userDelegate += UpdateUserForm_userDelegate;

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