using ChristmasPastryShop.Models;
using ChristmasPastryShop.Models.Delicacies;
using ChristmasPastryShop.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChristmasPastryShop.Repositories
{
    public class DelicacyRepository : IRepository<Delicacy>
    {
        private readonly List<Delicacy> models;

        public DelicacyRepository()
        {
            this.models = new List<Delicacy>();
        }

        public IReadOnlyCollection<Delicacy> Models => models;

        public void AddModel(Delicacy model)
        {
            models.Add(model);
        }

        public void AddModel(Booth booth)
        {
            throw new NotImplementedException();
        }
    }
}
