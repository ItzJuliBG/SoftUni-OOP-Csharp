using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildFarm.Models.Interfaces;

namespace WildFarm.Models
{
    public class Dog : Mammal, IAnimal
    {
        public Dog(string name, double weight, string livingRegion) : base(name, weight, livingRegion)
        {
            AllowedFoods = new List<Type> { typeof(Meat) };
            WeightMultiplier = 0.40;
        }

        public override ICollection<Type> AllowedFoods { get; }
        public override double WeightMultiplier { get; protected set; }

        public override string ProduceSound()
        {
            return "Woof!";
        }
        public override string ToString()
        {
            return $"{GetType().Name} [{Name}, {Weight}, {LivingRegion}, {FoodEaten}]";
        }
    }
}
