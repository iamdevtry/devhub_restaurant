using Dev69Restaurant.Common;
using Dev69Restaurant.DAL.Services;
using Dev69Restaurant.DTO.Entities;
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
            _billService = new BillService();
            _foodService = new FoodService();
        }

        private void RevenueForm_Load(object sender, EventArgs e)
        {
            LoadData();
            ShowChartAWeek();
            BindChartDefault();

            var info = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
            lblRevenueToday.Text = String.Format(info, "{0:c}", GetRevenueToday());
            GetPopularItem();
        }

        List<RevenueChart> revenueCharts = new List<RevenueChart>();

        private void LoadData()
        {
            DateTime dateStart = DateTime.Now.Date;

            var firstDayOfMonth = new DateTime(2021, 10, 22);
            var lastDayOfMonth = firstDayOfMonth.AddDays(6);

            List<Bill> bills = _billService.GetBills().ToList();
            var invoices = bills.Where(x => x.CreatedDate >= firstDayOfMonth && x.CreatedDate <= lastDayOfMonth).ToList();
            var dates = invoices.Select(x => x.CreatedDate.Value.Date).Distinct().ToList();

            foreach (var bill in dates)
            {
                RevenueChart revenueChart = new RevenueChart();
                revenueChart.Date = bill.Day;
                revenueChart.Month = bill.Month;
                revenueChart.Year = bill.Year;
                revenueChart.Value = double.Parse(GetTotalPrice(bills, (DateTime)bill) + "");
                revenueCharts.Add(revenueChart);
            }
        }

        private decimal GetTotalPrice(List<Bill> bills, DateTime dateTime)
        {

            var retrievedInvoices = bills.Where(n => n.CreatedDate.Value.Date == dateTime).Select(x => x.CreatedDate.Value.Date);

            decimal totalPrice = bills
            .Where(n => retrievedInvoices.Contains(n.CreatedDate.Value.Date))
            .Sum(n => n.TotalPrice);

            return totalPrice;
        }


        private decimal GetRevenueToday()
        {
            var bills = _billService.GetBills();
            var retrievedInvoices = bills.Where(n => n.CreatedDate.Value.Date == DateTime.Now.Date).Select(x => x.CreatedDate.Value.Date);

            decimal totalPrice = bills
            .Where(n => retrievedInvoices.Contains(n.CreatedDate.Value.Date))
            .Sum(n => n.TotalPrice);

            return totalPrice;
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
            var billDetail = sells.OrderByDescending(item => item.Amount).First();
            var food = _foodService.Find(billDetail.Name);

            lblPopularItem.Text = food.Name;
            lblQuantity.Text = billDetail.Amount.ToString();

        }

        private void ShowChartAWeek()
        {
            revenueChartBindingSource.DataSource = new List<RevenueChart>();

            var startDate = new DateTime(2021,10,22);
            var endDate = startDate.AddDays(7);

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
            DateTime dateStart = DateTime.Now.Date;
            var firstDayOfMonth = new DateTime(dateStart.Year, dateStart.Month, dateStart.Day);

            var firstDayOfMonth2 = new DateTime(2021, 10, 22);
            var lastDayOfMonth = firstDayOfMonth2.AddDays(6);

            chartRevenue.Series.Clear();
            SeriesCollection series = new SeriesCollection();
            var years = (from o in revenueCharts
                         select new { Year = o.Year }).Distinct();
            foreach (var year in years)
            {
                List<double> values = new List<double>();
                double value = 0;
                var data = from o in revenueCharts
                           where o.Date >= firstDayOfMonth2.Date.Day && o.Date <= lastDayOfMonth.Date.Day
                           orderby o.Date ascending
                           select new { o.Value, o.Date };
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
