using EDriveRent.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDriveRent.Models
{
    public abstract class Vehicle : IVehicle
    {
        private string brand;
        private string model;
        private string licensePlateNumber;
        private int batteryLevel;
        private bool isDamaged;

        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }



        public string Model
        {
            get { return model; }
            set { model = value; }
        }


        public double MaxMileage { get; private set; }


        public string LicensePlateNumber
        {
            get { return licensePlateNumber; }
            set { licensePlateNumber = value; }
        }



        public int BatteryLevel
        {
            get { return batteryLevel; }
            set { batteryLevel = value; }
        }



        public bool IsDamaged
        {
            get { return isDamaged; }
            set { isDamaged = false; }
        }


        public void ChangeStatus()
        {
            throw new NotImplementedException();
        }

        public void Drive(double mileage)
        {
            throw new NotImplementedException();
        }

        public void Recharge()
        {
            throw new NotImplementedException();
        }
    }
}
