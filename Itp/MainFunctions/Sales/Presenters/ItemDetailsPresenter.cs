using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Itp.MainFunctions.Sales.Models;
using Itp.MainFunctions.Sales.Views;

namespace Itp.MainFunctions.Sales.Presenters
{
    public class ItemDetailsPresenter
    {
        IItemDetails ItemDetailsViews;

        public ItemDetailsPresenter(IItemDetails view)
        {
            ItemDetailsViews = view;
        }

        public void updateTotalPrice()
        {
            ItemDetails itemDetails = new ItemDetails();

            itemDetails.ItemNo = ItemDetailsViews.ItemNoText;
            itemDetails.ItemName = ItemDetailsViews.ItemNameText;
            itemDetails.Description = ItemDetailsViews.DescriptionText;

            itemDetails.UnitPrice = double.Parse(ItemDetailsViews.UnitPriceText);
            itemDetails.Quantity = int.Parse(ItemDetailsViews.QuantityText);


            itemDetails.updateTotalPrice();
            ItemDetailsViews.TotalPriceText = itemDetails.TotalPrice.ToString();
        }
    }
}
