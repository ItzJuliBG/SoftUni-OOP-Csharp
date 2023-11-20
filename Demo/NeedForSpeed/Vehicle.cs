using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeedForSpeed
{
    public class Vehicle
    {
        public Vehicle(double fuel, int horsePower)
        { 
        
            Fuel = fuel;
            HorsePower = horsePower;
        }

        private double defaultFuelConsumption = 1.25;

        public double DefaultFuelConsumption
        {
            get { return defaultFuelConsumption; }
            set { defaultFuelConsumption = value; }
        }

        public virtual double FuelConsumption { get; set; }
        public double Fuel { get; set; }
        public int HorsePower { get; set; }
        public virtual void Drive(double kilometers)
        {
            double fuel = Fuel;
            double fuelConsumption = FuelConsumption;
            double defaultFuelConsumption = DefaultFuelConsumption;
            fuel = fuel - (defaultFuelConsumption* kilometers);
            Console.WriteLine(fuel);
        }
    }
}
