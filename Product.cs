using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Product
    {
        public string proname { get; set; }
        public double Price { get; set; }
        public virtual double vat()
        {
            return Price * 1.08;
        }
        public Product()
        {

        }
        public Product(string name, double price)
        {
            proname = name;
            Price = price;
        }

    }
}

