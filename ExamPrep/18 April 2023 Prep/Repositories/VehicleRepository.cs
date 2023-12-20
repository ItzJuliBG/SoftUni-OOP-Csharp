using EDriveRent.Models.Contracts;
using EDriveRent.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDriveRent.Repositories
{

    public class VehicleRepository : IRepository<IVehicle>
    {
    private List<IVehicle> currentList = new List<IVehicle>();

        private IReadOnlyCollection<IVehicle> vehicles;

        public IReadOnlyCollection<IVehicle> Vehicles
        {
            get { return vehicles; }
           private set { vehicles = currentList; }
        }

        public void AddModel(IVehicle model)
        {
           currentList.Add(model);
        }

        public IVehicle FindById(string identifier)
        {
           return currentList.FirstOrDefault(x=> x.LicensePlateNumber == identifier);
        }

        public IReadOnlyCollection<IVehicle> GetAll()
        {
          return Vehicles;
        }

        public bool RemoveById(string identifier)
        {
           var result = currentList.FirstOrDefault(x=> x.LicensePlateNumber == identifier);
            if(result == null)
            {
                return false;
            }
            currentList.Remove(result);
            return true;
        }
    }
}
