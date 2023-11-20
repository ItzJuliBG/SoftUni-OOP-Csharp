using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class Beverage : Product
    {
        public double Mililiters { get; set; }
        public Beverage(string name, decimal price, double mililiters) 
            : base(name, price)
        {
            Mililiters = mililiters;
        }
    }
}
