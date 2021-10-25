using Dev69Restaurant.DAL.Services;
using Dev69Restaurant.DTO.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dev69Restaurant.GUI.ManageCustomerCategory
{
    public partial class ManageCustomerCategoryForm : Form
    {
        private CustomerCategoryService _customerCategoryService;
        public ManageCustomerCategoryForm()
        {
            _customerCategoryService = new CustomerCategoryService();
            InitializeComponent();
            LoadData();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtName.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập tên danh mục! ");
                    txtName.Focus();
                }
                else
                {
                    AddCustomerCategory();
                    LoadData();
                    MessageBox.Show("Thêm thành công! ");                  
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Lỗi! ");
            }
        }

        private void AddCustomerCategory()
        {
            CustomerCategory customerCategory = new CustomerCategory();
            customerCategory.Name = txtName.Text;
            customerCategory.Status = true;
            _customerCategoryService.Add(customerCategory);
        }

        private void LoadData()
        {
            var listCustomerCategory = _customerCategoryService.GetAll();
            dgvCustomerCategory.DataSource = listCustomerCategory.ToList();
            dgvCustomerCategory.Columns["CreatedDate"].Visible = false;
            dgvCustomerCategory.Columns["CreatedBy"].Visible = false;
            dgvCustomerCategory.Columns["UpdatedDate"].Visible = false;
            dgvCustomerCategory.Columns["UpdatedBy"].Visible = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int Id = int.Parse(dgvCustomerCategory.SelectedCells[0].Value.ToString());
            try
            {
                DialogResult dr = MessageBox.Show("Bạn có muốn xóa? ", "Thông báo! ", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    _customerCategoryService.Delete(Id);
                    LoadData();
                    MessageBox.Show("Xóa thành công! ");

                }
            }
            catch (Exception)
            {

                MessageBox.Show("Lỗi!");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                DTO.Entities.CustomerCategory customerCategory = new DTO.Entities.CustomerCategory();
                customerCategory.Id = int.Parse(dgvCustomerCategory.SelectedCells[0].Value.ToString());
                customerCategory.Name = txtName.Text;
                _customerCategoryService.Update(customerCategory);
                LoadData();
                MessageBox.Show("Cập nhật thành công! ");
            }
            catch (Exception)
            {

                MessageBox.Show("Cập nhật không thành công! ");
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var keyword= txtSearch.Text;                    
            dgvCustomerCategory.DataSource = _customerCategoryService.GetAll(keyword).ToList();



        }

    

        private void dgvCustomerCategory_Click_1(object sender, EventArgs e)
        {
            if (dgvCustomerCategory.SelectedCells[0] != null)
            {
                txtName.Text = dgvCustomerCategory.SelectedCells[1].Value.ToString();
            }
        }
    }
}
