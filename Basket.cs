using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Basket
    {
        private List<Product> products = new List<Product> ();
        public double total()
        {
           double amount = 0;
            foreach (Product product in products)
            {
                amount += product.vat();
            }

            return amount;
        }
        public void proadd(Product newproduct)
            {
            products.Add (newproduct);
            }
    }
}
