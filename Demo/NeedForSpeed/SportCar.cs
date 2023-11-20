using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeedForSpeed
{
    public class SportCar : Car
    {
        public SportCar(double fuel, int horsePower) : base(fuel, horsePower)
        {
            this.DefaultFuelConsumption = 10;
        }
    }
}
