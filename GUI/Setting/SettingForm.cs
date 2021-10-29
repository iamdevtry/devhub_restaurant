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

namespace Dev69Restaurant.GUI.Setting
{
    public partial class SettingForm : Form
    {
        public SettingForm()
        {
            InitializeComponent();
            this.Icon = new Icon(BaseIcon.ICON);

        }

        private void tgbtnSwitchTheme_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
