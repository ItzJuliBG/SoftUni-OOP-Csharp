namespace ChristmasPastryShop.Repositories.Contracts
{
    using ChristmasPastryShop.Models;
    using System.Collections.Generic;
    public interface IRepository<T>
    {
        public IReadOnlyCollection<T> Models { get; }

        void AddModel(T model);
        void AddModel(Booth booth);
        
    }
}
