using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dev69Restaurant.Common
{
    public delegate void UserDelegate();
    public delegate void SelectTableFoodDelegate(object obj);
    public delegate void SelectFoodDelegate(object obj);
    public delegate void DeleteFoodDelegate(object obj);
    public delegate void UpdateQuantityFoodDelegate();
    public delegate void UpdateFoodForm();
    public delegate void UpdateBillDetail();
    public delegate void UpdateFoodCategory();
}
