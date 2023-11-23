using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles.Models
{
    public class Bus : Vehicle, IVehicle
    {
        private const double acConsumptionPerKM = 1.4;
        public Bus(double fuelQuantity, double  fuelConsumption, double tankCapacity)
            : base(fuelQuantity, fuelConsumption, tankCapacity, acConsumptionPerKM)
        {
        }
       public string DriveEmpty(double distance)
        {
            double fuelNeeded = FuelConsumption * distance;
            if (fuelNeeded <= FuelQuantity)
            {
                FuelQuantity-= fuelNeeded;
                return $"{GetType().Name} travelled {distance} km";
            }
            return $"{GetType().Name} needs refueling";
        }
        public override string Drive(double distance)
        {
            double fuelNeeded = (FuelConsumption +acConsumptionPerKM)* distance;
            if (fuelNeeded <= FuelQuantity)
            {
                FuelQuantity -= fuelNeeded;
                return $"{GetType().Name} travelled {distance} km";
            }
            return $"{GetType().Name} needs refueling";
        }
    }
}
