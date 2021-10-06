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

namespace Dev69Restaurant.GUI.DiscountForm
{
    public partial class DiscountForm : Form
    {
        public DiscountForm()
        {
            InitializeComponent();
        }

        private DiscountService _discountService = new DiscountService();

        private void button1_Click(object sender, EventArgs e)
        {
            Discount discount = new Discount();
            discount.Name = txtName.Text;
            discount.Code = txtCode.Text;
            discount.DiscountPercent = decimal.Parse(txtDiscountPercent.Text);
            discount.ConditionPrice = decimal.Parse(txtConditionPrice.Text);
            string status = cbStatus.SelectedText;

            if (status == "Còn hạn") {
                discount.Status = true;
            }
            else
            {
                discount.Status = false;
            }

            discount.CreatedBy = "PhucCuDo";
            discount.CreatedDate = DateTime.Now;
            discount.UpdatedDate = DateTime.Now;

            AddDiscount(discount);
        }

        private void AddDiscount(Discount discount)
        {
            _discountService.Add(discount);
            MessageBox.Show("Phusc cu dow");
        }

        private void DeleteDiscount(int id)
        {
            _discountService.Delete(id);
            MessageBox.Show("Phusc cu dow BA dơ");
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            DeleteDiscount(int.Parse(txtId.Text));
        }
    }
}
