using Dev69Restaurant.GUI.Home;
using Dev69Restaurant.GUI.Login;
using Dev69Restaurant.GUI.Manager;
using Dev69Restaurant.GUI.TableFood;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dev69Restaurant
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new HomeForm());
            //Application.Run(new LoginForm());
            //Application.Run(new ManagerForm());
        }
    }
}
