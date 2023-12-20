using EDriveRent.Models.Contracts;
using EDriveRent.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDriveRent.Repositories
{
    public class UserRepository : IRepository<IUser>
    {
        private List<IUser> currentList = new List<IUser>();
        private List<IUser> users;

        public IReadOnlyCollection<IUser> Users
        {
            get { return users; }
            private set { users = currentList; }
        }

        public void AddModel(IUser model)
        {
            currentList.Add(model);
        }

        public IUser FindById(string identifier)
        {
            return currentList.FirstOrDefault(x => x.DrivingLicenseNumber == identifier);
        }

        public IReadOnlyCollection<IUser> GetAll()
        {
            return Users;
        }

        public bool RemoveById(string identifier)
        {
            var result = currentList.FirstOrDefault(x => x.DrivingLicenseNumber == identifier);
            if (result == null)
            {
                return false;
            }
            currentList.Remove(result);
            return true;
        }
    }
}
