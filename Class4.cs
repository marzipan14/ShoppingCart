using System;
using System.Collections.Generic;
using System.IO;

namespace ShoppingCart
{
    class DiscountList
    {

        private Dictionary<string, Discount> discountList;

        public DiscountList(string path)
        {
            discountList = new Dictionary<string, Discount>();
            foreach (string line in File.ReadLines(path))
            {
                string[] split = line.Split(' ');
                string itemCode = split[0];
                int quantity = Int32.Parse(split[1]);
                int totalPrice = Int32.Parse(split[2]);
                discountList[itemCode] = new Discount(quantity, totalPrice);
            }
        }

        public int ObtainDiscountPrice(string itemCode, int quantity)
        {
            return discountList[itemCode].ObtainDiscountPrice(quantity);
        }
    }
}
