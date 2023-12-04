using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildFarm.Models.Interfaces;

namespace WildFarm.Models
{
    public class Mouse : Mammal, IAnimal
    {
        public Mouse(string name, double weight, string livingRegion) : base(name, weight, livingRegion)
        {
            AllowedFoods = new List<Type> { typeof(Vegetable), typeof(Fruit) };
            WeightMultiplier = 0.10;
        }

        public override ICollection<Type> AllowedFoods { get; }
        public override double WeightMultiplier { get ; protected set; }

        public override string ProduceSound()
        {
            return "Squeak";
        }
        public override string ToString()
        {
            return $"{GetType().Name} [{Name}, {Weight}, {LivingRegion}, {FoodEaten}]";
        }
    }
}
