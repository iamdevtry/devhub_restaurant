using Dev69Restaurant.Common;
using Dev69Restaurant.DAL.Services;
using Dev69Restaurant.DTO.Entities;
using Dev69Restaurant.Infrastructure.Settings;
using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dev69Restaurant.GUI.Revenue
{
    public partial class RevenueForm : Form
    {
        private BillService _billService;
        private FoodService _foodService;
        public RevenueForm()
        {
            InitializeComponent();
            this.Icon = new Icon(BaseIcon.ICON);

            _billService = new BillService();
            _foodService = new FoodService();
        }

        private void RevenueForm_Load(object sender, EventArgs e)
        {
            LoadData();
            ShowChartAWeek();
            BindChartDefault();
            GetPopularItem();
        }

        List<RevenueChart> revenueCharts = new List<RevenueChart>();

        private void LoadData()
        {
            DateTime dateStart = DateTime.Now.Date;

            //var firstDayOfMonth = new DateTime(2021, 10, 22);
            var firstDayOfMonth = dateStart.AddDays(-6);
            var lastDayOfMonth = firstDayOfMonth.AddDays(6);

            List<Bill> bills = _billService.GetBills().ToList();
            var invoices = bills.Where(x => x.CreatedDate >= firstDayOfMonth && x.CreatedDate <= lastDayOfMonth).ToList();
            var dates = invoices.Select(x => x.CreatedDate.Value.Date).Distinct().ToList();

            foreach (var bill in dates)
            {
                RevenueChart revenueChart = new RevenueChart();
                revenueChart.dateTime = new DateTime(bill.Year, bill.Month, bill.Day);
                revenueChart.Value = double.Parse(GetTotalPrice(bills, (DateTime)bill) + "");
                revenueCharts.Add(revenueChart);
            }


            var info = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
            lblRevenueToday.Text = String.Format(info, "{0:c}", GetRevenueToday(bills));
        }

        private decimal GetTotalPrice(List<Bill> bills, DateTime dateTime)
        {

            var retrievedInvoices = bills.Where(n => n.CreatedDate.Value.Date == dateTime).Select(x => x.CreatedDate.Value.Date);

            decimal totalPrice = bills
            .Where(n => retrievedInvoices.Contains(n.CreatedDate.Value.Date))
            .Sum(n => n.TotalPrice);

            return totalPrice;
        }


        private decimal GetRevenueToday(List<Bill> bills)
        {
            try
            {
                DateTime dt = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
                var retrievedInvoices = bills.Where(n => n.CreatedDate.Value.Date == dt).Select(x => x.CreatedDate);
                decimal totalPrice = bills
                .Where(n => retrievedInvoices.Contains(n.CreatedDate))
                .Sum(n => n.TotalPrice);

                return totalPrice;
            }
            catch
            {
                MessageBox.Show("Chưa có dữ liệu để thống kê!");
                return 0;
            }

        }

        private void GetPopularItem()
        {
            var billDetails = _billService.GetBillDetails().ToList();
            var sells = billDetails
                .Where(n => n.DateCheckout.Date == DateTime.Now.Date)
                .GroupBy(a => a.FoodId)
                .Select(a => new { Amount = a.Sum(b => b.Quantity), Name = a.Key})
                .OrderByDescending(a => a.Amount)
                .ToList();
            if (sells.Count < 1)
            {
                MessageBox.Show("Chưa có dữ liệu để thống kê!");
                return;
            }
            else
            {
                var billDetail = sells.OrderByDescending(item => item.Amount).First();
                var food = _foodService.Find(billDetail.Name);

                lblPopularItem.Text = food.Name;
                lblQuantity.Text = billDetail.Amount.ToString();
            }
        }

        private void ShowChartAWeek()
        {
            revenueChartBindingSource.DataSource = new List<RevenueChart>();

            DateTime date = DateTime.Now.Date;

            var startDate = date.AddDays(-6);
            var endDate = date;


            var numDays = (int)((endDate - startDate).TotalDays);
            List<DateTime> myDates = Enumerable
                       .Range(0, numDays)
                       .Select(x => startDate.AddDays(x))
                       .ToList();

            List<string> myDaysOfWeek = myDates.Select(d => d.DayOfWeek.ToString()+" "+d.ToShortDateString()).ToList();


            chartRevenue.AxisX.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Week",
                Labels = myDaysOfWeek
            }) ;

            var info = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
            chartRevenue.AxisY.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Doanh thu",
                LabelFormatter = value => String.Format(info, "{0:c}", value)
            });
            chartRevenue.LegendLocation = LiveCharts.LegendLocation.Right;
        }

        private void BindChartDefault()
        {
            var lastDayOfMonth = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            var firstDayOfMonth = lastDayOfMonth.AddDays(-6);

            chartRevenue.Series.Clear();
            SeriesCollection series = new SeriesCollection();
            var years = (from o in revenueCharts
                         select new { Year = o.dateTime.Year }).Distinct();
            foreach (var year in years)
            {
                List<double> values = new List<double>();
                double value = 0;
                var data = from o in revenueCharts
                           where o.dateTime >= firstDayOfMonth.Date &&  o.dateTime <= lastDayOfMonth.Date
                           orderby o.dateTime ascending
                           select new { o.Value, o.dateTime };
                foreach (var item in data)
                {
                    value = item.Value;
                    values.Add(value);
                }
                series.Add(new LineSeries() { Title = year.Year.ToString(), Values = new ChartValues<double>(values) });

            }
            chartRevenue.Series = series;
        }
    }
}
