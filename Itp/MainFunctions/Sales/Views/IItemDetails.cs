using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Itp.MainFunctions.Sales.Views
{
    public interface IItemDetails
    {
        string ItemNoText { get; set; }
        string ItemNameText { get; set; }
        string DescriptionText { get; set; }
        string UnitPriceText { get; set; }
        string QuantityText { get; set; }
        string TotalPriceText { get; set; }


    }
}
