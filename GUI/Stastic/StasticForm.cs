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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dev69Restaurant.GUI.Stastic
{
    public partial class StasticForm : Form
    {
        private BillService _billService;
        private TableService _tableService;
        Thread loadDataUserThread;
        public StasticForm()
        {
            InitializeComponent();
            this.Icon = new Icon(BaseIcon.ICON);

            Control.CheckForIllegalCrossThreadCalls = false;

            _billService = new BillService();
            _tableService = new TableService();
            DateStart.Value = DateTime.Now;
            DateEnd.Value = DateTime.Now;

            LoadData();
        }

        private void DateStart_ValueChanged(object sender, EventArgs e)
        {
            GetAllData();
        }

        private void DateEnd_ValueChanged(object sender, EventArgs e)
        {
            GetAllData();
        }

        private void ckbAllInMonth_CheckedChanged(object sender, EventArgs e)
        {
            GetAllData();
        }

        private void LoadData()
        {
            loadDataUserThread = new Thread(() => LoadBill());
            loadDataUserThread.IsBackground = true;
            loadDataUserThread.Start();
        }

        private void LoadBill()
        {
            GetAllData();
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            if (dgvListUser.Rows.Count < 1)
            {
                MessageBox.Show("Không có dữ liệu để xem.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (dgvListUser.SelectedCells[1].Value != null)
                {
                    int currentBillId = int.Parse(dgvListUser.SelectedCells[1].Value.ToString());

                    BillDetailForm billDetailForm = new BillDetailForm(currentBillId);
                    billDetailForm.StartPosition = FormStartPosition.CenterScreen;
                    billDetailForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy tài khoản.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void GetAllData(string keyword=null)
        {
            
            DateTime dateStart = DateStart.Value.Date;
            DateTime dateEnd = DateEnd.Value.Date;

            var listBills = _billService.GetBills(keyword).ToList();
            List<Bill> bills = new List<Bill>();
            if (ckbAllInMonth.Checked == true)
            {
                var firstDayOfMonth = new DateTime(dateStart.Year, dateStart.Month, 1);
                var lastDayOfMonth = firstDayOfMonth.AddMonths(1).AddDays(-1);

                bills = listBills.Where(x => x.CreatedDate >= firstDayOfMonth && x.CreatedDate <= lastDayOfMonth).ToList();
            }
            else
            {
                bills = listBills.Where(x => x.CreatedDate >= dateStart && x.CreatedDate <= dateEnd).ToList();
            }
            var listTables = _tableService.GetAll().ToList();
            LoadDatagridview(bills, listTables);
        }

        private void LoadDatagridview(List<Bill> bills,List<DTO.Entities.TableFood> tableFoods)
        {
            dgvListUser.Rows.Clear();
            int index = dgvListUser.Rows.Count;
            foreach (var item in bills)
            {
                index++;
                var tableName = tableFoods.Where(x => x.Id == item.TableId).SingleOrDefault();
                var topLeftHeaderCell = dgvListUser.TopLeftHeaderCell;
                dgvListUser.Rows.Add(index, item.Id, tableName.Name, item.CreatedDate, item.PaymentMethod, item.Discount, item.TotalPrice, item.CreatedBy);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            GetAllData(txtSearch.Text);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            GetAllData(txtSearch.Text);
        }

    }
}
