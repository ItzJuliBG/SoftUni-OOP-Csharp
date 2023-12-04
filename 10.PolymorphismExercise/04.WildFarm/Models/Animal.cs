using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildFarm.Models.Interfaces;

namespace WildFarm.Models
{
    public abstract class Animal : IAnimal
    {
        protected Animal(string name, double weight)
        {
            Name = name;
            Weight = weight;
        }

        public string Name { get; private set; }

        public double Weight { get; private set; }

        public int FoodEaten { get; private set; }
        public abstract double WeightMultiplier { get; protected set; }

        public abstract ICollection<Type> AllowedFoods { get; }

        public abstract string ProduceSound();
        //TODO: Eat method with weight multiplier
        public override string ToString()
        {
            return $"{GetType().Name} [{Name}";
        }
        public void Eat(IFood foodType)
        {
            if(!AllowedFoods.Contains((Type)foodType.GetType()))
            {
                Console.WriteLine($"{GetType().Name} does not eat {foodType.GetType().Name}!");
            }
            else
            {
                Weight = Weight +(WeightMultiplier*foodType.Quantity);
                FoodEaten+= foodType.Quantity;
            }

        }
    }
}
