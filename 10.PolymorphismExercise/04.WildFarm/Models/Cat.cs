using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WildFarm.Models
{
    public class Cat : Feline
    {
        public Cat(string name, double weight, string livingRegion, string breed) : base(name, weight, livingRegion, breed)
        {
            AllowedFoods = new List<Type> { typeof(Vegetable), typeof(Meat) };
            WeightMultiplier = 0.30;
        }

        public override ICollection<Type> AllowedFoods { get; }
        public override double WeightMultiplier { get; protected set; }

        public override string ProduceSound()
        {
            return "Meow";
        }
    }
}
