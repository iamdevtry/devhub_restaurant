using Dev69Restaurant.Common;
using Dev69Restaurant.DAL.Services;
using Dev69Restaurant.Infrastructure.Components.UserControls;
using Dev69Restaurant.Infrastructure.Settings;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dev69Restaurant.GUI.TableFood
{
    public partial class TableFoodForm : Form
    {
        private TableService _tableService;
        public event SelectTableFoodDelegate selectTableFoodDelegate;
        public TableFoodForm()
        {
            InitializeComponent();
            this.Icon = new Icon(BaseIcon.ICON);

            _tableService = new TableService();
            LoadTableFood();
        }

        private void LoadTableFood()
        {
            var listTableFoods = _tableService.GetAll();
            foreach(var table in listTableFoods)
            {
                string status = table.Status ? "Trống" : "Có người";
                UCTableFood ucTableFood = new UCTableFood(table.Id.ToString(), status, table.Name);
                ucTableFood.Click += UcTableFood_Click;
                pnTableFood.Controls.Add(ucTableFood);
            }
        }

        private void UcTableFood_Click(object sender, EventArgs e)
        {
            foreach (UCTableFood item in pnTableFood.Controls)
            {
                item.unCheckedFood();
            }

            UCTableFood ucTableFood = sender as UCTableFood;
            ucTableFood.isCheckedFood();
            selectTableFoodDelegate(ucTableFood.Tag);
        }

    }
}
