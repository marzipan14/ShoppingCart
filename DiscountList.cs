using System;
using System.Collections.Generic;
using System.IO;

namespace MyShoppingCart
{
    class DiscountList
    {
        private Dictionary<string, Discount> _discountList;

        public DiscountList(string path)
        {
            _discountList = new Dictionary<string, Discount>();
            try
            {
                foreach (string line in File.ReadLines(path))
                {
                    string[] split = line.Split(' ');
                    string itemCode = split[0];
                    int quantity = Int32.Parse(split[1]);
                    int totalPrice = Int32.Parse(split[2]);
                    _discountList[itemCode] = new Discount(quantity, totalPrice);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public int GetOptimalPrice(string itemCode, int quantity, int basePrice)
        {
            return _discountList.ContainsKey(itemCode) ? 
                _discountList[itemCode].GetOptimalPrice(quantity, basePrice)
                : quantity * basePrice;
        }
    }
}
