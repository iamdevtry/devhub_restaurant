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

namespace Dev69Restaurant.GUI.Checkout
{
    public partial class CheckoutForm : Form
    {
        private BillService _billService;
        private FoodService _foodService;
        private UserService _userService;
        private int _currentBillId;
        public CheckoutForm()
        {
            InitializeComponent();
            _billService = new BillService();
            _foodService = new FoodService();
        }

        public CheckoutForm(int billId)
        {
            InitializeComponent();
            this.Icon = new Icon(BaseIcon.ICON);
            _billService = new BillService();
            _foodService = new FoodService();
            _userService = new UserService();
            _currentBillId = billId;
        }

        private void CheckoutForm_Load(object sender, EventArgs e)
        {
            ShowReport(_currentBillId);
            this.rptBillDetail.RefreshReport();
        }

        private void ShowReport(int id)
        {
            List<BillDetail> billDetails = _billService.GetBillByBillId(id).ToList();
            List<DTO.Entities.Food> foods = _foodService.GetAll().ToList();
            List<DTO.Entities.User> users = _userService.GetAll().ToList();

            List<CheckoutRpt> billDetailsRpt = new List<CheckoutRpt>();
            foreach (BillDetail billDetail in billDetails)
            {
                var food = foods.Where(x => x.Id == billDetail.FoodId).SingleOrDefault();
                CheckoutRpt billReport = new CheckoutRpt();
                billReport.FoodName = food.Name;
                billReport.Quantity = billDetail.Quantity;
                billReport.Price = float.Parse(food.Price + "");

                billDetailsRpt.Add(billReport);
            }

            var bill = _billService.GetBillById(id);
            var user = users.Where(x => x.Username == bill.CreatedBy).SingleOrDefault();

            ReportParameter[] param = new ReportParameter[5];
            param[0] = new ReportParameter("DateCheckout", bill.CreatedDate.ToString());
            param[1] = new ReportParameter("Table", bill.TableId.ToString());
            param[2] = new ReportParameter("Discount", bill.Discount.ToString());
            param[3] = new ReportParameter("Cashier", user.FullName.ToString());
            param[4] = new ReportParameter("BillId", bill.Id.ToString());
            //var query = listBookReports.OrderByDescending(x => x.NamXB).ToList();

            this.rptBillDetail.LocalReport.ReportPath = @"..\..\Infrastructure\Reports\rptCheckout.rdlc";
            this.rptBillDetail.LocalReport.SetParameters(param);
            var reportDataSource = new ReportDataSource("BillDataSet", billDetailsRpt);
            this.rptBillDetail.LocalReport.DataSources.Clear();
            this.rptBillDetail.LocalReport.DataSources.Add(reportDataSource);
            this.rptBillDetail.LocalReport.DisplayName = "Hóa đơn thanh toán";

            this.rptBillDetail.RefreshReport();
        }
    }
}
