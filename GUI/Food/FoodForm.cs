using Dev69Restaurant.Common;
using Dev69Restaurant.DAL.Services;
using Dev69Restaurant.Infrastructure.Components.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dev69Restaurant.GUI.Food
{
    public partial class FoodForm : Form
    {
        private FoodService _foodService;
        public event SelectFoodDelegate selectFoodDelegate;

        public FoodForm()
        {
            InitializeComponent();
            _foodService = new FoodService();
            LoadFood();
        }
        private void LoadFood()
        {
            var listFoods = _foodService.GetAll();
            foreach (var food in listFoods)
            {
                UCTableFood ucTableFood = new UCTableFood(food.Id.ToString(), food.Price.ToString(), food.Name);
                ucTableFood.Click += UcTableFood_Click;

                pnFood.Controls.Add(ucTableFood);
            }
        }

        private void UcTableFood_Click(object sender, EventArgs e)
        {
            UCTableFood ucTableFood = sender as UCTableFood;
            selectFoodDelegate(ucTableFood.Tag);

        }
    }
}
