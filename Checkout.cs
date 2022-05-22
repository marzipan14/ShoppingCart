using System;
using System.Collections.Generic;

namespace MyShoppingCart
{
    class Checkout
    {
        private DiscountList _discountList;
        private PriceList _priceList;
        private Dictionary<string, int> _shoppingCart;

        public Checkout()
        {
            _discountList = new DiscountList("../../discounts.txt");
            _priceList = new PriceList("../../prices.txt");
            _shoppingCart = new Dictionary<string, int>();
        }

        private bool Scan()
        {
            string newItem = Console.ReadLine().Trim();
            if (newItem == "STOP")
            {
                return false;
            } 
            else
            {
                if (_shoppingCart.ContainsKey(newItem))
                    _shoppingCart[newItem]++;
                else
                    _shoppingCart[newItem] = 1;
                return true;
            }
        }

        public int ConsumeCart()
        {
            try
            {
                while (Scan()) { }
                return PriceCalculator.Calculate(_shoppingCart, _discountList, _priceList);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return -1;
            }
        }

    }
}
