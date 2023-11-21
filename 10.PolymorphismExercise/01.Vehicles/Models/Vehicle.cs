using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public abstract class Vehicle : IVehicle
    {
        private double acConsumptionPerKM = 0;
        protected Vehicle(double fuelQuantity, double fuelConsumption, double acConsumptionPerKM)
        {
            FuelQuantity = fuelQuantity;
            FuelConsumption = fuelConsumption;
            this.acConsumptionPerKM = acConsumptionPerKM;
        }

        public double FuelQuantity { get; private set; }

        public double FuelConsumption { get; private set; }

        public string Drive(double distance)
        {
            double fuelNeeded = (FuelConsumption+acConsumptionPerKM) * distance;
            if (fuelNeeded <= FuelQuantity)
            {
                FuelQuantity -= fuelNeeded;
                return $"{GetType().Name} travelled {distance} km";
            }
            return $"{GetType().Name} needs refueling";
        }

        public virtual void Refuel(double liters)
        {
            FuelQuantity += liters;
        }
        public override string ToString()
        {
           return $"{GetType().Name}: {FuelQuantity:f2}";
        }
    }
}
