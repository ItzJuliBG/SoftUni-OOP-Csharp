using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public class Car : Vehicle, IVehicle
    {
        private const double acConsumptionPerKM = 0.9;
        public Car(double fuelQuantity,double  fuelConsumption, double tankCapacity) 
            : base(fuelQuantity, fuelConsumption, tankCapacity, acConsumptionPerKM)
        {
        }
    }
}
