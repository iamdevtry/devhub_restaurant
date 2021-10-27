using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dev69Restaurant.DTO.EntityReports
{
    class BillDetailRpt
    {
        public string FoodName { get; set; }
        public int Quantity { get; set; }
        public DateTime CreatedDate { get; set; }
        public float Price { get; set; }
    }
}
