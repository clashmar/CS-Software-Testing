using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Software_Testing
{
    public class Product
    {
        public int ProductId { get; set; }
        public static int numberOfProducts = 0;
        public static List<Product> Products { get; set; } = new List<Product>();

        public Product(int productId)
        {
            ProductId = productId;
            numberOfProducts++;
            Products.Add(this);
        }
    }
}
