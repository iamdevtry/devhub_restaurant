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

namespace Dev69Restaurant.GUI.TableFood
{
    public partial class ManageTableFoodForm : Form
    {
        private TableService _tableFoodService;
        
        public ManageTableFoodForm()
        {
            _tableFoodService = new TableService();
            InitializeComponent(); 
            LoadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên! ");
                txtName.Focus();
                return;
            }
            else if(txtAreaId.Text== "")
            {
                MessageBox.Show("Bạn chưa nhập khu vực! ");
                txtAreaId.Focus();
                return;
            }
            else
            {
                AddTableFood();
                MessageBox.Show("Thêm thành công! ");
                LoadData();
            }
        }

        private void AddTableFood()
        {
            DTO.Entities.TableFood tableFood = new DTO.Entities.TableFood();
            tableFood.Name = txtName.Text;
            tableFood.AreaId = int.Parse(txtAreaId.Text);
            tableFood.Status = true;
            _tableFoodService.Add(tableFood);
        }

        private void LoadData()
        {
            var listTable = _tableFoodService.GetAll();
            dgvListTable.DataSource = listTable.ToList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int Id = int.Parse(dgvListTable.SelectedCells[0].Value.ToString());
            try
            {
                _tableFoodService.Delete(Id);
                LoadData();
                MessageBox.Show("Xóa thành công!");
            }
            catch (Exception)
            {
                MessageBox.Show("Xóa không thành công!");

            }
        }
        private void bntSearch_Click(object sender, EventArgs e)
        {
            var keyword = txtSearch.Text;
            dgvListTable.DataSource = _tableFoodService.GetAll(keyword).ToList();
        }
    }
}
