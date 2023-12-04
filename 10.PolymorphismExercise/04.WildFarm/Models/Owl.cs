using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildFarm.Models.Interfaces;

namespace WildFarm.Models
{
    public class Owl : Bird, IAnimal
    {
        public Owl(string name, double weight, double wingSize) : base(name, weight, wingSize)
        {
            AllowedFoods = new List<Type> { typeof(Meat) };
            WeightMultiplier = 0.25;
        }


        public override ICollection<Type> AllowedFoods { get; }
        public override double WeightMultiplier { get; protected set; }

        public override string ProduceSound()
        {
            return "Hoot Hoot";
        }
    }
}
