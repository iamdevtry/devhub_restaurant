using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dev69Restaurant.Components.UserControls
{
    public partial class UCTableFood : UserControl
    {
        public UCTableFood()
        {
            InitializeComponent();
        }


        private void UCTableFood_Click(object sender, EventArgs e)
        {
            if(chbSelectTable.Checked == false)
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

        private void pnlineTableFood_Click(object sender, EventArgs e)
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

        private void lblTableName_Click(object sender, EventArgs e)
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
    }
}
