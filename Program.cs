using Dev69Restaurant.GUI.ManageDiscount;
using Dev69Restaurant.GUI.Home;
using Dev69Restaurant.GUI.Login;
using Dev69Restaurant.GUI.ManageFoodCategory;
using Dev69Restaurant.GUI.Manager;
using Dev69Restaurant.GUI.Stastic;
using Dev69Restaurant.GUI.TableFood;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dev69Restaurant.GUI.Revenue;

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
            //Application.Run(new HomeForm());
            //Application.Run(new LoginForm());

            //Application.Run(new ManagerForm());
            //Application.Run(new FoodCategoryForm());

            //Application.Run(new ManageTableFoodForm());
            //Application.Run(new BillDetailForm());
            //Application.Run(new DiscountForm());
            Application.Run(new RevenueForm());

        }
    }
}
