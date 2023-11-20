using _04.PizzaCalories;
using System.Runtime.CompilerServices;
try
{
    List<string> cmd = new(Console.ReadLine().Split());
    string pizzaName = cmd[1];
    Pizza pizza = new(pizzaName);
    string cmd1;
    while ((cmd1 = Console.ReadLine()) != "END")
    {
        List<string> input = cmd1.Split().ToList();
        string doughOrTopping = input[0];
        if (doughOrTopping == "Dough")
        {
            string flourType = input[1].ToLower();
            string bakingTechnique = input[2].ToLower();
            double grams = double.Parse(input[3]);
            Dough dough = new(flourType, bakingTechnique, grams);
            pizza.AddCaloriesOf(dough.Calories);
        }
        else if (doughOrTopping == "Topping")
        {
            string toppingType = input[1];
            double grams = double.Parse(input[2]);
            Topping topping = new(toppingType, grams);
            pizza.AddCaloriesOf(topping.Calories);
        }

    }
    Console.WriteLine($"{pizza.Name} - {pizza.Calories:f2} Calories.");
}
catch (Exception ex) {  Console.WriteLine(ex.Message); }
