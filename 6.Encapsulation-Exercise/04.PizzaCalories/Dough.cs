using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.PizzaCalories
{
    public class Dough
    {
        private const string invalidTypeOfDoughExceptionMessage = "Invalid type of dough.";
        private const string invalidWeightExceptionMessage = "Dough weight should be in the range [1..200].";
        private Dictionary<string, double> flourTypes = new Dictionary<string, double>() { { "white", 1.5 }, { "wholegrain", 1.0 } };
        private Dictionary<string, double> bakingTechniques = new Dictionary<string, double>() { { "crispy", 0.9 }, { "chewy", 1.1 }, { "homemade", 1.0 } };

        private double calories;
        private double grams;

        private string flourType;

        private string bakingTechnique;

         public Dough(string flourType, string bakingTechnique, double grams)
        {
            FlourType = flourType;
            BakingTechnique = bakingTechnique;
            Grams = grams;
            Calories = calories;
        }

        public string FlourType
        {
            get { return flourType; }
            set
            {
                if (!flourTypes.ContainsKey(value))
                {
                    throw new Exception(invalidTypeOfDoughExceptionMessage);
                }
                flourType = value.ToLower();
            }
        }
        public string BakingTechnique
        {
            get { return bakingTechnique; }
            set
            {
                if (!bakingTechniques.ContainsKey(value))
                {
                    throw new Exception(invalidTypeOfDoughExceptionMessage);
                }
                bakingTechnique = value.ToLower();
            }
        }

        public double Grams
        {
            get { return grams; }
            set {
                if(value<1 || value > 200)
                {
                    throw new Exception(invalidWeightExceptionMessage);
                }
                grams = value; }
        }

        public double Calories
        {
            get { return calories; }
            private set
            {
                calories = grams * 2;
                calories *= flourTypes[FlourType];
                calories *= bakingTechniques[BakingTechnique];
            }
        }
    }
}
