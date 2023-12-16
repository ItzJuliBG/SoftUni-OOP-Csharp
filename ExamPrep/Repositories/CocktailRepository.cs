using ChristmasPastryShop.Models;
using ChristmasPastryShop.Models.Cocktails;
using ChristmasPastryShop.Models.Delicacies;
using ChristmasPastryShop.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChristmasPastryShop.Repositories
{
    public class CocktailRepository : IRepository<Cocktail>
    {
        private readonly List<Cocktail> models;

        public CocktailRepository()
        {
            this.models = new List<Cocktail>();
        }

        public IReadOnlyCollection<Cocktail> Models => models;

        public void AddModel(Cocktail cocktail)
        {
            models.Add(cocktail);
        }

        public void AddModel(Booth booth)
        {
            throw new NotImplementedException();
        }
    }
}
