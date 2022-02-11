using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Textile:Product
    {
        public string Textype { get; set; }
        public int Size { get; set; }
        public string Producer { get; set; }
        public Textile(string ad,double price,string textype,int size)
        {
            proname = ad;
            Price = price;
            Textype= textype;
            Size = size;
        }
    }
}
