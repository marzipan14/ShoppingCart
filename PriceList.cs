using System;
using System.Collections.Generic;
using System.IO;

namespace MyShoppingCart
{
    class PriceList
    {
        private Dictionary<string, int> _priceList;

        public PriceList(string path)
        {
            _priceList = new Dictionary<string, int>();
            try
            { 
                foreach (string line in File.ReadLines(path))
                {
                    string[] split = line.Split(' ');
                    string itemCode = split[0];
                    int price = Int32.Parse(split[1]);
                    if (price > 0)
                    {
                        _priceList[itemCode] = price;
                    }
                    else
                    {
                        throw new ArgumentException($"Invalid price of the item {itemCode}: {price}.");
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public int GetBasePrice(string itemCode)
        {
            return _priceList[itemCode];
        }
    }
}
