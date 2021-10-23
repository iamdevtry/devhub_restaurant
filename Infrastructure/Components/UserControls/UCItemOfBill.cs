using Dev69Restaurant.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dev69Restaurant.Infrastructure.Components.UserControls
{
    public partial class UCItemOfBill : UserControl
    {
        public event DeleteFoodDelegate deleteFoodDelegate;
        public event UpdateQuantityFoodDelegate updateQuantityFoodDelegate;
        public int quantity;
        public double totalPrice;
        public int idFood;

        public UCItemOfBill()
        {
            InitializeComponent();
        }
        public UCItemOfBill(string foodId,string foodPrice, string foodName)
        {
            InitializeComponent();
            lblFoodName.Text = foodName;
            lblPrice.Text = foodPrice;
            idFood = int.Parse(foodId);
            quantity = 1;
            string[] foods = { foodId, quantity.ToString() };
            this.Tag = foods;
            lblTotalPrice.Text = double.Parse(nmrQuantity.Value.ToString()) * double.Parse(lblPrice.Text.ToString())+"";
            totalPrice = double.Parse(nmrQuantity.Value.ToString()) * double.Parse(lblPrice.Text.ToString());
        }

        private void TotalPrice(double foodPrice)
        {
            lblTotalPrice.Text = double.Parse(nmrQuantity.Value.ToString()) * foodPrice+"";
            totalPrice = double.Parse(nmrQuantity.Value.ToString()) * foodPrice;
        }

        private void nmrQuantity_ValueChanged(object sender, EventArgs e)
        {
            double foodPrice = double.Parse(lblPrice.Text);
            quantity = int.Parse(nmrQuantity.Value.ToString());
            TotalPrice(foodPrice);
            updateQuantityFoodDelegate();
        }

        public void nmrQuantity_ValueChanged(string newQuantity = null)
        {
            double foodPrice = double.Parse(lblPrice.Text);
            quantity = int.Parse(nmrQuantity.Value.ToString())+int.Parse(newQuantity);
            nmrQuantity.Value = quantity;
            TotalPrice(foodPrice);
            updateQuantityFoodDelegate();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            deleteFoodDelegate(this);
        }
    }
}
