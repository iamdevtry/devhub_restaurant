using Dev69Restaurant.DAL.Services;
using Dev69Restaurant.DTO.Entities;
using Dev69Restaurant.GUI.ManageFoodCategory;
using Dev69Restaurant.Infrastructure.Settings;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dev69Restaurant.GUI.ManageFood
{
    public partial class ManageFoodForm : Form
    {
        private FoodService _foodService;
        Thread loadDataUserThread;

        string appPath = "";
        string iName = "";   // <---
        string filepath = "";   // <---
        public ManageFoodForm()
        {
            InitializeComponent();
            this.Icon = new Icon(BaseIcon.ICON);

            Control.CheckForIllegalCrossThreadCalls = false;
            _foodService = new FoodService();

            LoadData();
        }

        private void btnChangeAvatar_Click(object sender, EventArgs e)
        {
            OpenFileDialog opFile = new OpenFileDialog();
            opFile.Title = "Select a Image";
            opFile.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All Files(*.*)|*.*";

            appPath = Path.GetDirectoryName(Application.ExecutablePath) + @"\ProImages\"; // <---
            if (Directory.Exists(appPath) == false)                                              // <---
            {                                                                                    // <---
                Directory.CreateDirectory(appPath);                                              // <---
            }                                                                                    // <---

            if (opFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    iName = opFile.SafeFileName;   // <---
                    filepath = opFile.FileName;    // <---
                    picAvatar.Image = new Bitmap(opFile.OpenFile());
                }
                catch (Exception exp)
                {
                    MessageBox.Show("Unable to open file " + exp.Message);
                }
            }
            else
            {
                opFile.Dispose();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgvListFood.SelectedCells[2].Value.ToString());
            if (GetSelectedRowById(id) == -1)
            {
                MessageBox.Show("Không tìm thấy mục cần xóa.", "Thông báo", MessageBoxButtons.YesNo);
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa?", "Thông báo", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        _foodService.Delete(id);
                        LoadFood();
                        MessageBox.Show("Xóa thành công!");
                        txtName.Text = "";
                        txtPrice.Text = "";
                        picAvatar.Image = null;
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadFood(txtSearch.Text);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn cập nhật?", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    if (GetSelectedRowByName(txtName.Text) != -1)
                    {
                        Update(appPath + iName);
                        SaveImage();
                        LoadFood();
                        MessageBox.Show("Cập nhật thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy thông tin cần cập nhật.", "Thông báo", MessageBoxButtons.YesNo);
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("Cập nhật thất bại!!!");
                }
            }
        }

        private void dgvListFood_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvListFood.SelectedCells[0].Value != null)
            {
                txtName.Text = dgvListFood.SelectedCells[1].Value.ToString();
                txtPrice.Text = dgvListFood.SelectedCells[4].Value.ToString();

                if (dgvListFood.SelectedCells[5].Value.ToString() == "Ẩn")
                {
                    optHidden.Checked = true;
                }
                else
                {
                    optDisplay.Checked = true;
                }

                var categoryFood = _foodService.GetFoodCategory().ToList();
                string categoryName = dgvListFood.SelectedCells[3].Value.ToString();
                foreach (var item in categoryFood)
                {
                    if (item.Name == categoryName)
                    {
                        cmbFoodCategory.SelectedValue = item.Id;
                    }
                }

                int idFood = int.Parse(dgvListFood.SelectedCells[2].Value.ToString());
                var avt = _foodService.Find(idFood);

                if (avt.Image != null)
                {
                    picAvatar.Image = Image.FromFile(avt.Image);
                }
                else
                {
                    picAvatar.Image = Image.FromFile(BaseIcon.NO_IMAGE);
                }
            }
            else
            {
                return;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                AddFood(appPath + iName);
                SaveImage();
            }
            catch (Exception)
            {
                MessageBox.Show("Chưa nhập đủ thông tin!!!");
            }
        }

        private void AddFood(string avatar)
        {
            DTO.Entities.Food food = new DTO.Entities.Food();
            food.Name = txtName.Text;


            double price = double.Parse(txtPrice.Text);
            if (price < 0)
            {
                MessageBox.Show("Giá tiền không được nhỏ hơn 0.", "Thông báo", MessageBoxButtons.YesNo);
            }
            else
            {
                food.Price = decimal.Parse(txtPrice.Text);
            }

            if (optDisplay.Checked == true)
            {
                food.Status = true;
            }
            else
            {
                food.Status = false;
            }


            if (!string.IsNullOrEmpty(avatar))
            {
                food.Image = avatar;
            }
            else
            {
                food.Image = BaseIcon.NO_IMAGE;
            }

            food.CategoryId = int.Parse(cmbFoodCategory.SelectedValue.ToString());
            food.CreatedDate = DateTime.Now;
            _foodService.Add(food);
            LoadFood();
            MessageBox.Show("Nhập dữ liệu thành công!");
        }

        private void Update(string avatar)
        {
            DTO.Entities.Food food = new DTO.Entities.Food();
            food.Id = int.Parse(dgvListFood.SelectedCells[2].Value.ToString());

            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên món ăn .", "Thông báo", MessageBoxButtons.YesNo);
            }
            else
            {
                food.Name = txtName.Text;
            }

            double price = double.Parse(txtPrice.Text);
            if (price < 0)
            {
                MessageBox.Show("Giá tiền không được nhỏ hơn 0.", "Thông báo", MessageBoxButtons.YesNo);
            }
            else
            {
                food.Price = decimal.Parse(txtPrice.Text);
            }

            if (optDisplay.Checked == true)
            {
                food.Status = true;
            }
            else
            {
                food.Status = false;
            }


            if (!string.IsNullOrEmpty(avatar))
            {
                food.Image = avatar;
            }
            else
            {
                food.Image = BaseIcon.NO_IMAGE;
            }

            food.CategoryId = int.Parse(cmbFoodCategory.SelectedValue.ToString());
            food.UpdatedDate = DateTime.Now;
            _foodService.Update(food);
            LoadFood();
        }
        private void LoadData()
        {
            loadDataUserThread = new Thread(() => LoadFood());
            loadDataUserThread.IsBackground = true;
            loadDataUserThread.Start();
        }

        private void LoadFood(string keyword = null)
        {
            dgvListFood.Rows.Clear();
            var listFoods = _foodService.GetAll(keyword).ToList();
            var foodCategoryList = _foodService.GetFoodCategory().ToList();

            cmbFoodCategory.DataSource = foodCategoryList;
            cmbFoodCategory.DisplayMember = "Name";
            cmbFoodCategory.ValueMember = "Id";

            int index = dgvListFood.Rows.Count;

            foreach (var item in listFoods)
            {
                index++;
                string status = item.Status ? "Hiển thị" : "Ẩn";

                var foodCategory = foodCategoryList.Where(x => x.Id == item.CategoryId).SingleOrDefault();

                var topLeftHeaderCell = dgvListFood.TopLeftHeaderCell;
                dgvListFood.Rows.Add(index, item.Name, item.Id, foodCategory.Name, item.Price, status);
            }
        }

        private int GetSelectedRowByName(string name)
        {
            for (int i = 0; i < dgvListFood.Rows.Count; i++)
            {
                if (dgvListFood.Rows[i].Cells[1].Value.ToString() == name)
                {
                    return i;
                }
            }
            return -1;
        }

        private int GetSelectedRowById(int id)
        {
            for (int i = 0; i < dgvListFood.Rows.Count; i++)
            {
                if (dgvListFood.Rows[i].Cells[2].Value.ToString() == id+"")
                {
                    return i;
                }
            }
            return -1;
        }

        private void SaveImage()
        {
            try
            {
                if (string.IsNullOrEmpty(filepath) || string.IsNullOrEmpty(appPath) || string.IsNullOrEmpty(iName))
                {
                    return;
                }
                else
                {
                    if (File.Exists(appPath + iName))
                    {
                        return;
                    }
                    else
                    {
                        File.Copy(filepath, appPath + iName);
                        appPath = "";
                        iName = "";   // <---
                        filepath = "";
                    }
                }

            }
            catch (Exception exp)
            {
                MessageBox.Show("Unable to open file " + exp.Message);
            }
        }

        private void lblManageCate_Click(object sender, EventArgs e)
        {
            FoodCategoriesForm foodCategoriesForm = new FoodCategoriesForm();
            foodCategoriesForm.StartPosition = FormStartPosition.CenterScreen;
            foodCategoriesForm.updateFoodCategory += FoodCategoriesForm_updateFoodCategory;
            foodCategoriesForm.ShowDialog();
        }

        private void FoodCategoriesForm_updateFoodCategory()
        {
            LoadData();
        }
    }
}
