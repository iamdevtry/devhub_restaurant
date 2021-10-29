using Dev69Restaurant.DAL.Services;
using Dev69Restaurant.DTO.Entities;
using Dev69Restaurant.DTO.EntityReports;
using Dev69Restaurant.Infrastructure.Settings;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dev69Restaurant.GUI.Stastic
{
    public partial class BillDetailForm : Form
    {
        private BillService _billService;
        private FoodService _foodService;
        private int _currentBillId;
        public BillDetailForm()
        {
            InitializeComponent();
            this.Icon = new Icon(BaseIcon.ICON);

            _billService = new BillService();
            _foodService = new FoodService();
        }
        public BillDetailForm(int billId)
        {
            InitializeComponent();
            this.Icon = new Icon(BaseIcon.ICON);

            _billService = new BillService();
            _foodService = new FoodService();
            _currentBillId = billId;
        }

        private void BillDetailForm_Load(object sender, EventArgs e)
        {
            ShowReport(_currentBillId);
            this.rptBillDetail.RefreshReport();
        }

        private void ShowReport(int id)
        {
            List<BillDetail> billDetails = _billService.GetBillByBillId(id).ToList();
            List<DTO.Entities.Food> foods= _foodService.GetAll().ToList();

            List<BillDetailRpt> billDetailsRpt = new List<BillDetailRpt>();
            foreach (BillDetail billDetail in billDetails)
            {
                var food = foods.Where(x => x.Id == billDetail.FoodId).SingleOrDefault();
                BillDetailRpt billReport = new BillDetailRpt();
                billReport.FoodName = food.Name;
                billReport.Quantity = billDetail.Quantity;
                billReport.CreatedDate = billDetail.DateCheckin;
                billReport.Price = float.Parse(food.Price+"");

                billDetailsRpt.Add(billReport);
            }

            var bill = _billService.GetBillById(id);
            ReportParameter[] param = new ReportParameter[3];
            param[0] = new ReportParameter("DateTime", bill.CreatedDate.ToString());
            param[1] = new ReportParameter("BillId", bill.Id.ToString());
            param[2] = new ReportParameter("Discount", bill.Discount.ToString());
            //var query = listBookReports.OrderByDescending(x => x.NamXB).ToList();

            this.rptBillDetail.LocalReport.ReportPath = @"..\..\Infrastructure\Reports\rptBill.rdlc";
            this.rptBillDetail.LocalReport.SetParameters(param);
            var reportDataSource = new ReportDataSource("BillDetailDataSet", billDetailsRpt);
            this.rptBillDetail.LocalReport.DataSources.Clear();
            this.rptBillDetail.LocalReport.DataSources.Add(reportDataSource);
            this.rptBillDetail.LocalReport.DisplayName = "Chi tiết hóa đơn";

            this.rptBillDetail.RefreshReport();
        }
    }
}
