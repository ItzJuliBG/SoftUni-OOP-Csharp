using EDriveRent.Core.Contracts;
using EDriveRent.Models;
using EDriveRent.Models.Contracts;
using EDriveRent.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EDriveRent.Core
{
    public class Controller : IController
    {
        private UserRepository users = new UserRepository();
        private VehicleRepository vehicles = new VehicleRepository();
        private RouteRepository routes = new RouteRepository();
        private int routeID = 0;
        public string AllowRoute(string startPoint, string endPoint, double length)
        {
            if (routes.Routes.Any(x => x.StartPoint == startPoint && x.EndPoint == endPoint && x.Length == length))
            {
                return $"{startPoint}/{endPoint} - {length} km is already added in our platform.";
            }
            else if (routes.Routes.Any(x => x.StartPoint == startPoint && x.EndPoint == endPoint && x.Length < length))
            {
                return $"{startPoint}/{endPoint} shorter route is already added in our platform.";
            }
            routeID++;
            IRoute route = routes.Routes.FirstOrDefault(x => x.StartPoint == startPoint && x.EndPoint == endPoint && x.Length > length);
            if (route != null)
            {
                route.LockRoute();
            }
            else
            {
                route = new Route(startPoint, endPoint, length, routeID);
            }
            return $"{startPoint}/{endPoint} - {length} km is unlocked in our platform."; //may have a mistake

        }

        public string MakeTrip(string drivingLicenseNumber, string licensePlateNumber, string routeId, bool isAccidentHappened)
        {
            throw new NotImplementedException();
        }

        public string RegisterUser(string firstName, string lastName, string drivingLicenseNumber)
        {
            User user = new User(firstName, lastName, drivingLicenseNumber);
            if (users.FindById(drivingLicenseNumber) != null)
            {
                return $"{drivingLicenseNumber} is already registered in our platform.";
            }
            users.AddModel(user);
            return $"{firstName} {lastName} is registered successfully with DLN- {drivingLicenseNumber}";
        }

        public string RepairVehicles(int count)
        {
            throw new NotImplementedException();
        }

        public string UploadVehicle(string vehicleType, string brand, string model, string licensePlateNumber)
        {
            if (vehicles.FindById(licensePlateNumber) != null)//this may have to be in inner if cycle
            {
                return $"{licensePlateNumber} belongs to another vehicle.";
            }
            if (vehicleType == "CargoVan")
            {
                vehicles.AddModel(new CargoVan(brand, model, licensePlateNumber));
                return $"Return the following message: {brand} {model} is uploaded successfully with LPN-{licensePlateNumber}";
            }
            else if (vehicleType == "PassengerCar")
            {
                vehicles.AddModel(new PassengerCar(brand, model, licensePlateNumber));
                return $"Return the following message: {brand} {model} is uploaded successfully with LPN-{licensePlateNumber}";
            }

            else
            {
                return $"{vehicleType} is not accessible in our platform.";
            }
        }

        public string UsersReport()
        {
            throw new NotImplementedException();
        }
    }
}
