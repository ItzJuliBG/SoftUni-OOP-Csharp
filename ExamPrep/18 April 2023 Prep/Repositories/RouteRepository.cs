using EDriveRent.Models.Contracts;
using EDriveRent.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDriveRent.Repositories
{
    public class RouteRepository : IRepository<IRoute>
    {
        private List<IRoute> currentList = new List<IRoute>();
        private IReadOnlyCollection<IRoute> routes;

        public IReadOnlyCollection<IRoute> Routes
        {
            get { return routes; }
            set { routes = currentList; }
        }

        public void AddModel(IRoute model)
        {
           currentList.Add(model);
        }

        public IRoute FindById(string identifier)
        {
            return currentList.FirstOrDefault(x => x.RouteId == int.Parse(identifier));
        }

        public IReadOnlyCollection<IRoute> GetAll()
        {
            return Routes;
        }

        public bool RemoveById(string identifier)
        {
            var result = currentList.FirstOrDefault(x => x.RouteId == int.Parse(identifier));
            if(result == null)
            {
                return false;
            }
            currentList.Remove(result);
            return true;
        }
    }
}
