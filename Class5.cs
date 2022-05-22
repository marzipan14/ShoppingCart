using System;

namespace ShoppingCart
{
    class Discount
    {
        private int basePriceForSingleItem;
        private int discountPriceForMultipleItems;
        private int numberOfItemsForDiscount;

        public int ObtainDiscountPrice(int quantity)
        {
            return Math.Min(
                quantity*basePriceForSingleItem,
                (quantity/numberOfItemsForDiscount)*discountPriceForMultipleItems + (quantity%numberOfItemsForDiscount)*basePriceForSingleItem
            );
        }
    }
}
