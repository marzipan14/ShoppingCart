using System;

namespace MyShoppingCart
{
    class Discount
    {
        private int _discountItemAmount;
        private int _discountValue;

        public Discount(int amount, int value)
        {
            if (amount <= 0 || value < 0)
            {
                throw new ArgumentException("Invalid discount data provided.");
            }
            _discountItemAmount = amount;
            _discountValue = value;
        }

        public int GetOptimalPrice(int quantity, int basePrice)
        {
            if (quantity <= 0 || basePrice < 0)
            {
                throw new ArgumentException("Invalid item data provided.");
            }

            return Math.Min(
                quantity*basePrice,
                (quantity/_discountItemAmount)*_discountValue + (quantity%_discountItemAmount)*basePrice
            );
        }
    }
}
