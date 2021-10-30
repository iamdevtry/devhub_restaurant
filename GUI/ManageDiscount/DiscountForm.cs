using Dev69Restaurant.DAL.Services;
using Dev69Restaurant.DTO.Entities;
using Dev69Restaurant.Infrastructure.Settings;
using System;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace Dev69Restaurant.GUI.ManageDiscount
{
    public partial class DiscountForm : Form
    {
        private DiscountService _discountService;
        private Thread loadDataDiscountThread;

        public DiscountForm()
        {
            InitializeComponent();
            this.Icon = new Icon(BaseIcon.ICON);

            Control.CheckForIllegalCrossThreadCalls = false;
            _discountService = new DiscountService();
            LoadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateForm() == 1)
                {
                    Discount discount = new Discount();
                    discount.Name = txtName.Text;
                    discount.Code = txtCode.Text;
                    discount.DiscountPercent = decimal.Parse(txtPercent.Text);
                    discount.ConditionPrice = decimal.Parse(txtConditionPrice.Text);
                    discount.StartDate = dtpStartDate.Value.Date;
                    discount.EndDate = dtpEndDate.Value.Date;

                    if (rdActive.Checked == true)
                    {
                        discount.Status = true;
                    }
                    else
                    {
                        discount.Status = false;
                    }

                    AddDiscount(discount);
                    MessageBox.Show("Thêm mới khuyến mãi thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDataDiscount();
                    ResetField();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ResetField()
        {
            txtName.Text = "";
            txtCode.Text = "";
            txtPercent.Text = "";
            txtConditionPrice.Text = "";
        }

        private void AddDiscount(Discount discount)
        {
            _discountService.Add(discount);
        }

        private void UpdateDiscount(Discount discount)
        {
            _discountService.Update(discount);
        }

        private int ValidateForm()
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên khuyến mãi.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return -1;
            }
            else if (string.IsNullOrEmpty(txtCode.Text))
            {
                MessageBox.Show("Bạn chưa mã CODE khuyến mãi.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return -1;
            }
            else if (string.IsNullOrEmpty(txtPercent.Text))
            {
                MessageBox.Show("Bạn chưa phần trăm khuyến mãi.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return -1;
            }
            else if (!string.IsNullOrEmpty(txtPercent.Text))
            {
                int percent = int.Parse(txtPercent.Text);
                if (percent < 0 || percent > 100)
                {
                    MessageBox.Show("Phần trăm khuyến mãi không được nhỏ hơn 0 và lớn hơn 100", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return -1;
                }
                else
                {
                    return 1;
                }
            }
            else if (!string.IsNullOrEmpty(txtConditionPrice.Text))
            {
                int condi = int.Parse(txtConditionPrice.Text);
                if (condi < 0)
                {
                    MessageBox.Show("Điều kiện khuyến mãi không được nhỏ hơn 0", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return -1;
                }
                else
                {
                    return 1;
                }
            }
            else
            {
                return 1;
            }
        }

        private void LoadData()
        {
            loadDataDiscountThread = new Thread(() => LoadDataDiscount());
            loadDataDiscountThread.IsBackground = true;
            loadDataDiscountThread.Start();
        }

        private void LoadDataDiscount(string keyword = null)
        {
            dgvListDiscount.Rows.Clear();
            var listDiscounts = _discountService.GetAll(keyword).ToList();
            int index = dgvListDiscount.Rows.Count;

            foreach (var item in listDiscounts)
            {
                index++;
                string status = item.Status ? "Kích Hoạt" : "Khóa";
                var topLeftHeaderCell = dgvListDiscount.TopLeftHeaderCell;
                dgvListDiscount.Rows.Add(index, item.Id, item.Name, item.Code, item.EndDate, item.DiscountPercent, status);
            }
        }

        private void dgvListDiscount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvListDiscount.SelectedCells[1].Value != null)
            {
                int id = int.Parse(dgvListDiscount.SelectedCells[1].Value.ToString());
                var discount = _discountService.GetById(id);
                txtName.Text = discount.Name;
                txtCode.Text = discount.Code;
                txtConditionPrice.Text = discount.ConditionPrice.ToString();
                txtPercent.Text = discount.DiscountPercent.ToString();

                if (discount.StartDate == null)
                {
                    dtpStartDate.CustomFormat = "";
                }
                else
                {
                    dtpStartDate.Value = discount.StartDate.Value;
                }

                if (discount.StartDate == null)
                {
                    dtpEndDate.CustomFormat = "";
                }
                else
                {
                    dtpEndDate.Value = discount.EndDate.Value;
                }

                if (discount.Status == true)
                {
                    rdActive.Checked = true;
                }
                else
                {
                    rdBlock.Checked = true;
                }
            }
            else
            {
                return;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvListDiscount.SelectedCells[1].Value != null)
                {
                    int id = int.Parse(dgvListDiscount.SelectedCells[1].Value.ToString());
                    Discount discount = new Discount();
                    discount.Id = id;
                    discount.Name = txtName.Text;
                    discount.Code = txtCode.Text;
                    discount.DiscountPercent = decimal.Parse(txtPercent.Text);
                    discount.ConditionPrice = decimal.Parse(txtConditionPrice.Text);
                    discount.StartDate = dtpStartDate.Value.Date;
                    discount.EndDate = dtpEndDate.Value.Date;

                    if (rdActive.Checked == true)
                    {
                        discount.Status = true;
                    }
                    else
                    {
                        discount.Status = false;
                    }

                    UpdateDiscount(discount);
                    MessageBox.Show("Chỉnh sửa khuyến mãi thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDataDiscount();
                    ResetField();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy mục cần chỉnh sửa!.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvListDiscount.SelectedCells[1].Value != null)
                {
                    int id = int.Parse(dgvListDiscount.SelectedCells[1].Value.ToString());

                    DeleteDiscount(id);
                    LoadDataDiscount();
                    ResetField();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy mục cần chỉnh sửa!.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DeleteDiscount(int id)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa mục này?.", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                _discountService.Delete(id);
                MessageBox.Show("Xóa khuyến mãi thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                return;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadDataDiscount(txtSearch.Text);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadDataDiscount(txtSearch.Text);
        }

    }
}