using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Software_Testing
{
    public class ShoppingCart
    {
        public Dictionary<string, double> items = new Dictionary<string, double>();

        public void AddItem(string itemName, double price)
        {
            items[itemName] = price;
        }

        public double CalculatePrice()
        {
            double price = 0;

            foreach (var item in items)
            {
                price = price + item.Value;
            }

            return price;
        }
    }
}
