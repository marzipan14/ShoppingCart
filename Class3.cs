using System;
using System.Collections.Generic;

namespace ShoppingCart
{
    class PriceCalculator
    {

        static int Calculate(Dictionary<CartItem, int> cart, DiscountList discountList)
        {
            int total = 0;
            foreach (var (item, quantity) in cart)
            {
                total += discountList.ObtainDiscount(item, quantity);
            }
            return total;
        }

    }
}
