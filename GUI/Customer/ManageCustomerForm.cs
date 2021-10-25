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

namespace Dev69Restaurant.GUI.ManageCustomer
{
    public partial class ManageCustomerForm : Form
    {
        private CustomerService _customerService;
        public ManageCustomerForm()
        {
            InitializeComponent();
            _customerService = new CustomerService();
            LoadData();
            LoadCustomerCategory();

        }
        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (txtName.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập họ tên!");
                    txtName.Focus();
                }
                else if (txtAddress.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập họ tên!");
                    txtAddress.Focus();
                }
                else if (txtPhone.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập họ tên!");
                    txtPhone.Focus();
                }
                else
                {

                    AddCustomer();
                    MessageBox.Show("Đăng kỳ tài khoản thành công! ");
                    LoadData();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Nhập không thành công!");
            }
        }

        private void AddCustomer()
        {
            Customer customer = new Customer();
            customer.Name = txtName.Text;
            customer.Phone = txtPhone.Text;
            customer.Address = txtAddress.Text;
            customer.CustomerCategoryId = int.Parse(cbxCusCategory.SelectedValue.ToString());
            customer.Status = true;
            _customerService.Add(customer);
        }

        private void LoadData()
        {
            var listCustomer = _customerService.GetAll();
            dgvListCustomer.DataSource = listCustomer.ToList();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int Id = int.Parse(dgvListCustomer.SelectedCells[0].Value.ToString());
            try
            {

                _customerService.Delete(Id);
                MessageBox.Show("Xóa thành công! ");
                LoadData();
            }
            catch (Exception)
            {
                MessageBox.Show("Xóa không thành công! ");

            }
        }
       
        
        private void LoadCustomerCategory()
        {
            var listCustomerCategory = _customerService.GetCustomerCategory();
            cbxCusCategory.DataSource = listCustomerCategory.ToList();
            cbxCusCategory.DisplayMember = "Name";
            cbxCusCategory.ValueMember = "Id";
        }

    
        private void btnSearch_Click(object sender, EventArgs e)
        {
            var keyword = txtSearch.Text;                          
                MessageBox.Show("Không tìm thấy Thông tin khách hàng!");
            dgvListCustomer.DataSource = _customerService.GetAll(keyword).ToList();

            
        }

      
    }
}
