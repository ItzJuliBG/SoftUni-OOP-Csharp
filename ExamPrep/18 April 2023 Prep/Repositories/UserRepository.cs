using EDriveRent.Models.Contracts;
using EDriveRent.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDriveRent.Repositories
{
    public class UserRepository : IRepository<User>
    {
        private List<IUser> users = new List<IUser>();

        public UserRepository(List<IUser> users)
        {
            this.users = new List<IUser>();
        }

        public void AddModel(User model)
        {
           users.Add(model);
        }

        public User FindById(string identifier)
        {
            //return users.FirstOrDefault(x=> x.i
            return null;
        }

        public IReadOnlyCollection<User> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool RemoveById(string identifier)
        {
            throw new NotImplementedException();
        }
    }
}
