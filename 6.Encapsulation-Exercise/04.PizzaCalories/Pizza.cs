using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.PizzaCalories
{
    public class Pizza
    {
        private string name;
        private int toppingCount = -1;

        public Pizza(string name)
        {
            Name = name;
        }

        public string Name
        {
            get { return name; }
            set
            {
                if(string.IsNullOrEmpty(value) || value.Length<1 || value.Length > 15)
                {
                    throw new Exception("Pizza name should be between 1 and 15 symbols.");
                }
                name = value;
            }
        }
        public double Calories { get; private set; }

        public void AddCaloriesOf(double caloriesOf)
        {
            Calories += caloriesOf;
            toppingCount++;
            if(toppingCount == 11) 
            {
                throw new Exception("Number of toppings should be in range [0..10].");
            }
        }


    }
}
