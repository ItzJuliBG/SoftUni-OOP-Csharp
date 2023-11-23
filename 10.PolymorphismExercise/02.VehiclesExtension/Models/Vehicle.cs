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
        private readonly double acConsumptionPerKM = 0;
        private double tankCapacity;

        protected Vehicle(double fuelQuantity, double fuelConsumption, double tankCapacity, double acConsumptionPerKM)
        {
            FuelQuantity = fuelQuantity;
            FuelConsumption = fuelConsumption;
            TankCapacity = tankCapacity;
            this.acConsumptionPerKM = acConsumptionPerKM;
        }

        public double FuelQuantity { get; set; }

        public double FuelConsumption { get; private set; }

        public double TankCapacity
        {
            get => tankCapacity; private set
            {
                if (FuelQuantity > value)
                {
                    FuelQuantity = 0;
                }
                tankCapacity = value;
            }
        }


        public virtual string Drive(double distance)
        {
            double fuelNeeded = (FuelConsumption + acConsumptionPerKM) * distance;
            if (fuelNeeded <= FuelQuantity)
            {
                FuelQuantity -= fuelNeeded;
                return $"{GetType().Name} travelled {distance} km";
            }
            return $"{GetType().Name} needs refueling";
        }
        public virtual string DriveEmpty(double distance)
        {
            double fuelNeeded = FuelConsumption * distance;
            if (fuelNeeded <= FuelQuantity)
            {
                FuelQuantity -= fuelNeeded;
                return $"{GetType().Name} travelled {distance} km";
            }
            return $"{GetType().Name} needs refueling";
        }

        public virtual void Refuel(double liters)
        {
            if (liters <= 0)
            {
                Console.WriteLine("Fuel must be a positive number");
            }
            else if (liters > TankCapacity) // or liters > TankCapacity
            {
                Console.WriteLine($"Cannot fit {liters} fuel in the tank");
            }
            else
            {
                FuelQuantity += liters;
            }
        }

        public override string ToString()
        {
            return $"{GetType().Name}: {FuelQuantity:f2}";
        }



    }
}
