using ChristmasPastryShop.Models.Booths.Contracts;
using ChristmasPastryShop.Models.Cocktails.Contracts;
using ChristmasPastryShop.Models.Delicacies.Contracts;
using ChristmasPastryShop.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChristmasPastryShop.Models
{
    public class Booth : IBooth
    {
        private int capacity;

        public Booth(int boothId, int capacity)
        {
            BoothId = boothId;
            Capacity = capacity;
        }

        public int BoothId { get; private set; }

        public int Capacity
        {
            get { return capacity; }
            private set
            {
                if (value <= 0)
                { throw new ArgumentException("Capacity has to be greater than 0!"); }
                capacity = value;
            }
        }

        public IRepository<IDelicacy> DelicacyMenu {get; private set;}

        public IRepository<ICocktail> CocktailMenu { get; private set; }

        public double CurrentBill { get; private set; }

        public double Turnover { get; private set; }

        public bool IsReserved { get; private set; }

        public void UpdateCurrentBill(double amount)
        {
            CurrentBill += amount;
        }
        public void Charge()
        {
            Turnover += CurrentBill;
            CurrentBill = 0;
        }
        public void ChangeStatus()
        {
            if(IsReserved)
            {
                IsReserved = false;
            }
            else
            {
                IsReserved = true;
            }
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Booth: {BoothId}");
            sb.AppendLine($"Capacity: {Capacity}");
            sb.AppendLine($"Turnover: {Turnover:f2}");
            sb.AppendLine($"Cocktail menu:");
            foreach (var cocktail in CocktailMenu.Models)
            {
                sb.AppendLine(cocktail.ToString());//idk if true
            }
            foreach (var delicacy in DelicacyMenu.Models)
            {
                sb.AppendLine(delicacy.ToString());//idk if true
            }
            return sb.ToString();
        }
       

    }
}
