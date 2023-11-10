using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    public class BasketManager
    {
        //naming convention
        //syntax
        public void Add(Product product)
        {
            Console.WriteLine("Tebrikler. Sepete Eklendi: " + product.Name);
        }

        public void Add2(string ProductName, string ProductDescription, double ProductPrice, int StockQuantity)
        {
            Console.WriteLine("Tebrikler. Sepete Eklendi: " + ProductName);
        }

    }
}
