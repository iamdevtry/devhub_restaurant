using Dev69Restaurant.Common;
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

namespace Dev69Restaurant.Infrastructure.Components.UserControls
{
    public partial class UCTableFood : UserControl
    {

        public UCTableFood()
        {
            InitializeComponent();
        }

        public UCTableFood(string idTable, string status, string tableName)
        {
            InitializeComponent();
            lblStatus.Text = status;
            lblTableName.Text = tableName;
            this.BackgroundImage = Image.FromFile(BaseIcon.TABLE_FOOD_IMAGE);
            string[] foods = { idTable, status, tableName};
            this.Tag = foods;
        }


        private void UCTableFood_Click(object sender, EventArgs e)
        {
            isCheckedFood();
        }

        private void pnlineTableFood_Click(object sender, EventArgs e)
        {
            isCheckedFood();
        }

        public void isCheckedFood()
        {
            if (chbSelectTable.Checked == false)
            {
                chbSelectTable.Checked = true;
                pnlineTableFood.Visible = true;
            }
            else
            {
                chbSelectTable.Checked = false;
                pnlineTableFood.Visible = false;
            }
        }

        public void unCheckedFood()
        {
            chbSelectTable.Checked = false;
            pnlineTableFood.Visible = false;
        }

        private void chbSelectTable_Click(object sender, EventArgs e)
        {
            isCheckedFood();
        }
    }
}
