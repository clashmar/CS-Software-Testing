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

        public double Discount { get; set; } = 0;

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

            if (Discount == 0)
            {
                return Math.Round(price, 2);
            } else
            {
                return Math.Round(price * Discount, 2);
            }
            
        }

        public void ApplyDiscount(double discount)
        {
            if (discount >= 0 && discount <= 1)
            {
                Discount = discount;
            } else
            {
                Discount = 0;
            }
            
        }
    }
}
