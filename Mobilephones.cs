using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Mobilephones:Product
    {
        public string Specs { get; set; }  
        public string Brand { get; set; }
        public Mobilephones(string name,double price,string brand)
        {
            proname = name;
            Price=price;
            Brand=brand;
        }
    }
}
