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

namespace Dev69Restaurant.GUI.ManageArea
{
    public partial class ManageAreaForm : Form
    {
        private AreaService _areaService;
        public ManageAreaForm()
        {
            _areaService = new AreaService();
            InitializeComponent();
            LoadData();
        }
        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (txtName.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập  tên khu vực!");
                    txtName.Focus();
                }
                else
                {
                    AddArea();
                    MessageBox.Show("Đăng kỳ khu vực thành công! ");
                    LoadData();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Nhập không thành công!");
            }
        }

        private void AddArea()
        {
            Area area = new Area();
            area.Name = txtName.Text;
            _areaService.Add(area);            
        }

        private void LoadData()
        {
            var listArea = _areaService.GetAll();
            dgvListArea.DataSource = listArea.ToList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int Id = int.Parse(dgvListArea.SelectedCells[0].Value.ToString());
            try
            {   
                DialogResult dr = MessageBox.Show("Bạn có muốn xóa? ", "Thông báo! ", MessageBoxButtons.YesNo);
                if (dr== DialogResult.Yes)
                {
                    _areaService.Delete(Id);
                    MessageBox.Show("Xóa thành công! ");
                    LoadData();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Xóa không thành công! ");

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                DTO.Entities.Area area = new DTO.Entities.Area();
                area.Id = int.Parse(dgvListArea.SelectedCells[0].Value.ToString());
                area.Name = txtName.Text;
                _areaService.Update(area);
                LoadData();
                MessageBox.Show("Cập nhật thành công!");
            }
            catch (Exception)
            {

                MessageBox.Show("Lỗi! ");
            }

        }

        private void dgvListArea_Click(object sender, EventArgs e)
        {
            if (dgvListArea.SelectedCells[0] != null)
            {
                txtName.Text = dgvListArea.SelectedCells[1].Value.ToString();
            }
        }
   
        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            var keyword = txtSearch.Text;
            dgvListArea.DataSource = _areaService.GetAll(keyword).ToList();

        }
    }


}
