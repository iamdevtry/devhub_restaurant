using Dev69Restaurant.Common;
using Dev69Restaurant.DAL.Services;
using Dev69Restaurant.DTO.Entities;
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

namespace Dev69Restaurant.GUI.ManageFoodCategory
{
    public partial class FoodCategoriesForm : Form
    {
        private FoodCategoryService _foodCategoryService;
        public event UpdateFoodCategory updateFoodCategory;
        public FoodCategoriesForm()
        {
            InitializeComponent();
            this.Icon = new Icon(BaseIcon.ICON);

            _foodCategoryService = new FoodCategoryService();

            LoadFoodCategory();
        }

        private void LoadFoodCategory(string keyword = null)
        {
            dgvListFoodCategory.Rows.Clear();
            var listFoodCategory = _foodCategoryService.GetAll(keyword).ToList();
            int index = dgvListFoodCategory.Rows.Count;

            foreach (var item in listFoodCategory)
            {
                index++;
                string status = item.Status ? "Hiển thị" : "Khóa";
                var topLeftHeaderCell = dgvListFoodCategory.TopLeftHeaderCell;
                dgvListFoodCategory.Rows.Add(index, item.Name,item.Id, item.Description,status);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadFoodCategory(txtSearch.Text);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FoodCategory foodCategory = new FoodCategory();
            try
            {

                foodCategory.Name = txtName.Text;
                foodCategory.Description = rtxtDescription.Text;
                if (optDisplay.Checked == true)
                {
                    foodCategory.Status = true;
                }
                else
                {
                    foodCategory.Status = false;
                }
                foodCategory.CreatedDate = DateTime.Now;
                _foodCategoryService.Add(foodCategory);
                LoadFoodCategory();
                MessageBox.Show("Nhập dữ liệu thành công!");
            }
            catch (Exception)
            {
                MessageBox.Show("Chưa nhập đủ thông tin!!!");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgvListFoodCategory.SelectedCells[2].Value.ToString());
            if (GetSelectedRowById(id) == -1)
            {
                MessageBox.Show("Không tìm thấy mục cần sửa!", "Thông báo", MessageBoxButtons.YesNo);
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn có chắc muốn cập nhật?", "Thông báo", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        DTO.Entities.FoodCategory foodCategory = new DTO.Entities.FoodCategory();
                        foodCategory.Id = int.Parse(dgvListFoodCategory.SelectedCells[2].Value.ToString());
                        foodCategory.Name = txtName.Text;
                        if (optDisplay.Checked == true)
                        {
                            foodCategory.Status = true;
                        }
                        else
                        {
                            foodCategory.Status = false;
                        }
                        foodCategory.Description = rtxtDescription.Text;
                        _foodCategoryService.Update(foodCategory);
                        LoadFoodCategory();
                        MessageBox.Show("Cập nhật thành công!");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Cập nhật thất bại!!!");
                    }
                }
            }
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgvListFoodCategory.SelectedCells[2].Value.ToString());
            if (GetSelectedRowById(id) == -1)
            {
                MessageBox.Show("Không tìm thấy mục cần xóa!", "Thông báo", MessageBoxButtons.YesNo);
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa?", "Thông báo", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        _foodCategoryService.Delete(id);
                        LoadFoodCategory();
                        MessageBox.Show("Xóa thành công!");
                        txtName.Text = "";
                        optDisplay.Checked = false;
                        optHidden.Checked = false;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Xóa thất bại!");
                    }
                }
            }

        }

        private int GetSelectedRowById(int id)
        {
            for (int i = 0; i < dgvListFoodCategory.Rows.Count; i++)
            {
                if (dgvListFoodCategory.Rows[i].Cells[2].Value.ToString() == id + "")
                {
                    return i;
                }
            }
            return -1;
        }

        private void dgvListFoodCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvListFoodCategory.SelectedCells[0].Value != null)
            {
                txtName.Text = dgvListFoodCategory.SelectedCells[1].Value.ToString();
                if(dgvListFoodCategory.SelectedCells[3].Value != null)
                {
                    rtxtDescription.Text = dgvListFoodCategory.SelectedCells[3].Value.ToString();
                }
                else
                {
                    rtxtDescription.Text = "";
                }
                
                if (dgvListFoodCategory.SelectedCells[4].Value.ToString() == "Khóa")
                {
                    optHidden.Checked = true;
                }
                else
                {
                    optDisplay.Checked = true;
                }

            }
            else
            {
                return;
            }
        }

        private void FoodCategoriesForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            updateFoodCategory();
        }

        private void FoodCategoriesForm_Load(object sender, EventArgs e)
        {
            shadowForm.SetShadowForm(this);
        }
    }
}
