using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public class Truck :Vehicle, IVehicle
    {
        private const double acConsumptionPerKM = 1.6;
        private const double fuelLeakagePerc = 0.95;
        public Truck(double fuelQuantity, double fuelConsumption)
            : base(fuelQuantity, fuelConsumption, acConsumptionPerKM)
        {
        }
        public override void Refuel(double liters)
        {
            base.Refuel(liters*fuelLeakagePerc);
        }
    }
}
