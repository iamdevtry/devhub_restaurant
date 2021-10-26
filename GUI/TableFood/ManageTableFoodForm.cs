using Dev69Restaurant.DAL.Services;
using Dev69Restaurant.DTO.Entities;
using Dev69Restaurant.Infrastructure.Settings;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            InitializeComponent();
            _tableFoodService = new TableService();
            LoadData();
            picAvatar.Image = Image.FromFile(BaseIcon.TABLE_FOOD_IMAGE);
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (GetSelectedRow(txtName.Text) != -1)
            {
                var item = _tableFoodService.Find(txtName.Text);
                int Id = item.Id;
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
            else
            {
                MessageBox.Show("Không có dữ liệu để xóa", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        private void bntSearch_Click(object sender, EventArgs e)
        {
            var keyword = txtSearch.Text;
            LoadData(keyword);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DTO.Entities.TableFood tableFood = new DTO.Entities.TableFood();

            if (dgvListTable.Rows.Count < 1)
            {
                MessageBox.Show("Không có dữ liệu để cập nhật.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (dgvListTable.SelectedCells[1].Value != null)
                {
                    if (txtName.Text == "")
                    {
                        MessageBox.Show("Bạn chưa nhập tên! ");
                        txtName.Focus();
                        return;
                    }
                    else
                    {
                        if (GetSelectedRow(txtName.Text) != -1)
                        {
                            tableFood.Name = txtName.Text;
                            _tableFoodService.Update(tableFood);
                            MessageBox.Show("Thêm thành công! ");
                            LoadData();
                        }
                        else
                        {
                            MessageBox.Show("Tên bàn đã tồn tại, hãy nhập lại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                    }

                }
                else
                {
                    MessageBox.Show("Không tìm thấy bàn.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void dgvListTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                txtName.Text = dgvListTable.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên! ");
                txtName.Focus();
                return;
            }
            else
            {
                if (GetSelectedRow(txtName.Text) == -1)
                {
                    AddTableFood();
                    MessageBox.Show("Thêm thành công! ");
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Tên bàn đã tồn tại, hãy nhập lại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

            }
        }

        private void AddTableFood()
        {
            DTO.Entities.TableFood tableFood = new DTO.Entities.TableFood();
            tableFood.Name = txtName.Text;
            tableFood.Status = true;
            _tableFoodService.Add(tableFood);
        }

        private void LoadData(string keyword=null)
        {
            var listTables = _tableFoodService.GetAll(keyword).ToList();
            LoadDatagridView(listTables);
        }

        private void LoadDatagridView(List<DTO.Entities.TableFood> tableFoods)
        {
            dgvListTable.Rows.Clear();
            int index = dgvListTable.Rows.Count;

            foreach (var item in tableFoods)
            {
                index++;
                string status = item.Status ? "Kích Hoạt" : "Khóa";
                var topLeftHeaderCell = dgvListTable.TopLeftHeaderCell;
                dgvListTable.Rows.Add(index, item.Name, status);
            }
        }

        private int GetSelectedRow(string name)
        {
            for (int i = 0; i < dgvListTable.Rows.Count; i++)
            {
                if (dgvListTable.Rows[i].Cells[1].Value.ToString() == name)
                {
                    return i;
                }
            }
            return -1;
        }

    }
}
