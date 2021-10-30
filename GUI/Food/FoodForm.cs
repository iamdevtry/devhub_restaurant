using Dev69Restaurant.Common;
using Dev69Restaurant.DAL.Services;
using Dev69Restaurant.Infrastructure.Components.UserControls;
using Dev69Restaurant.Infrastructure.Settings;
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
            this.Icon = new Icon(BaseIcon.ICON);

            _foodService = new FoodService();
            LoadFood();
        }

        public FoodForm(string keyword)
        {
            InitializeComponent();
            this.Icon = new Icon(BaseIcon.ICON);

            _foodService = new FoodService();
            GetAllByCategory(keyword);
        }

        private void GetAllByCategory(string keyword)
        {
            var listFoods = _foodService.GetAllByCategory(keyword);
            foreach (var food in listFoods)
            {
                UCTableFood ucTableFood = new UCTableFood(food.Id.ToString(), food.Price.ToString(), food.Name);
                if(food.Image == null)
                {
                    ucTableFood.BackgroundImage = Image.FromFile(BaseIcon.NO_IMAGE);
                }
                else
                {
                    ucTableFood.BackgroundImage = Image.FromFile(food.Image);
                }

                ucTableFood.Click += UcTableFood_Click;

                pnFood.Controls.Add(ucTableFood);
            }
        }

        private void LoadFood(string keyword=null)
        {
            var listFoods = _foodService.GetAll(keyword);
            foreach (var food in listFoods)
            {
                UCTableFood ucTableFood = new UCTableFood(food.Id.ToString(), food.Price.ToString(), food.Name);
                if (food.Image == null)
                {
                    ucTableFood.BackgroundImage = Image.FromFile(BaseIcon.NO_IMAGE);
                }
                else
                {
                    ucTableFood.BackgroundImage = Image.FromFile(food.Image);
                }
                ucTableFood.Click += UcTableFood_Click;

                pnFood.Controls.Add(ucTableFood);
            }
        }

        private void UcTableFood_Click(object sender, EventArgs e)
        {
            UCTableFood ucTableFood = sender as UCTableFood;
            selectFoodDelegate(ucTableFood.Tag);
        }

        public void UnChecked()
        {
            foreach (UCTableFood item in pnFood.Controls)
            {
                item.unCheckedFood();
            }
        }
    }
}
