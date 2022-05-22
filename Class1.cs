using System;

namespace ShoppingCart
{
    class Checkout {

        public Checkout()
        {

        }

        private bool Scan()
        {

        }

        public int ConsumeCart()
        {
            while (Scan()) { }
            return PriceCalculator.Calculate();
        }

    }
}
