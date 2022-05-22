using System;
using System.Collections.Generic;
using System.IO;

namespace MyShoppingCart
{
    class PriceList
    {

        private Dictionary<string, int> priceList;

        public PriceList(string path) {
            priceList = new Dictionary<string, int>();
            foreach (string line in File.ReadLines(path))
            {
                string[] split = line.Split(' ');
                string itemCode = split[0];
                int price = Int32.Parse(split[1]);
                priceList[itemCode] = price;
            }
        }

        public int getBasePrice(string itemCode)
        {
            return priceList[itemCode];
        }
}
