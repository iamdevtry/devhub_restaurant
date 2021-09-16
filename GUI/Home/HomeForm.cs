using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dev69Restaurant.GUI.Home
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private bool isCollapse = false;
        private void btnToogleMenu_Click(object sender, EventArgs e)
        {
            if (!isCollapse)
            {
                pnLeft.Visible = false;
                pnLeft.Width = 80;
                gnTransition.ShowSync(pnLeft);
                isCollapse = true;
            }
            else
            {
                pnLeft.Visible = false;
                pnLeft.Width = 320-80;
                gnTransition.ShowSync(pnLeft);
                isCollapse = false;
            }
        }
    }
}
