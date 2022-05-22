using System;
using System.Collections.Generic;

namespace MyShoppingCart
{
    class PriceCalculator
    {
        public static int Calculate(Dictionary<string, int> shoppingCart, DiscountList discountList, PriceList priceList)
        {
            int total = 0;
            foreach (KeyValuePair<string, int> entry in shoppingCart)
            {
                string itemCode = entry.Key;
                int quantity = entry.Value;
                total += discountList.GetOptimalPrice(itemCode, quantity, priceList.GetBasePrice(itemCode));
            }
            return total;
        }
    }
}
