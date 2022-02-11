using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Bread:Product
    {
        public string Breadtype { get; set; }
        public int Weight { get; set; }
        public override double vat()
        {
            return Price * 1.01;
        }
        public Bread(string name,double price,string breadtype,int weight)
        {
            proname = name;
            Price = price;
            Breadtype = breadtype;
            Weight = weight;
        }
    }
}
