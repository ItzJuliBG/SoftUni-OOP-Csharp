using ChristmasPastryShop.Models;
using ChristmasPastryShop.Models.Booths.Contracts;
using ChristmasPastryShop.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChristmasPastryShop.Repositories
{
    public class BoothRepository : IRepository<Booth>
    {
        private readonly List<Booth> models;

        public BoothRepository()
        {
            this.models = new List<Booth>();
        }

        public IReadOnlyCollection<Booth> Models => models;

        public void AddModel(Booth model)
        {
           models.Add(model);
        }
        public IBooth GetBoothById(int id)
        {
            return models.First(x => x.BoothId == id);
        }
    }
}
