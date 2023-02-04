using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Itp.MainFunctions.Sales.Models
{
    public class ItemDetails
    {
        public string ItemNo { get; set; }
        public string ItemName { get; set; }
        public string Description { get; set; }
        public double UnitPrice { get; set; }
        public int Quantity { get; set; }
        public double TotalPrice { get; set; }

        public void updateTotalPrice()
        {
            TotalPrice = Quantity * UnitPrice;
        }




    }
}
