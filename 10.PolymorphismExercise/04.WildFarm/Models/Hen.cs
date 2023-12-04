using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildFarm.Models.Interfaces;

namespace WildFarm.Models
{
    public class Hen : Bird, IAnimal
    {
        public Hen(string name, double weight, double wingSize) : base(name, weight, wingSize)
        {
            AllowedFoods = new List<Type> { typeof(Fruit), typeof(Meat), typeof(Seeds), typeof(Vegetable) };
            WeightMultiplier = 0.35;
        }

        public override ICollection<Type> AllowedFoods { get; }
        public override double WeightMultiplier { get ; protected set; }

        public override string ProduceSound()
        {
            return "Cluck";
        }
    }
}
