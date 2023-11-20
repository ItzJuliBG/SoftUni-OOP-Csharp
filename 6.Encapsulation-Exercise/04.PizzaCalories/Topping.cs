using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.PizzaCalories
{
    public class Topping
    {
        private double baseCaloriesPerGram = 2;
        private Dictionary<string, double> toppingTypes = new Dictionary<string, double>() { { "meat", 1.2 }, { "veggies", 0.8 }, { "cheese", 1.1 }, { "sauce", 0.9 } };
        private double grams;
        private double calories;

        //initialize them in ctor

        private string toppingType;

        public Topping(string toppingType, double grams)
        {
            ToppingType = toppingType;
            Grams = grams;
            Calories = calories;
        }

        public string ToppingType
        {
            get { return toppingType; }
            set
            {
                toppingType = value;
                if (!toppingTypes.ContainsKey(value.ToLower()))
                {
                    throw new Exception($"Cannot place {value} on top of your pizza.");
                }
                toppingType = value;
            }
        }

        public double Calories
        {
            get { return calories; }
            private set
            {
                calories = Grams * 2;
                calories*= toppingTypes[ToppingType.ToLower()];

            }
        }

        public double Grams
        {
            get { return grams; }
            private set
            {
                if(value<1 || value > 50)
                {
                    throw new Exception($"{toppingType} weight should be in the range [1..50].");
                }
                grams = value;
            }
        }







    }
}
