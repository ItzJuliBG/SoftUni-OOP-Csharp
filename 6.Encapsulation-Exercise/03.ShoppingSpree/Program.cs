using _03.ShoppingSpree;
using System.ComponentModel;
try
{
    List<char> filter = new List<char>() { '=', ';' };
    List<string> cmd = new List<string>(Console.ReadLine()
        .Split(new char[] { '=', ';' }, StringSplitOptions.RemoveEmptyEntries));
    List<Person> people = new();
    for (int i = 0; i < cmd.Count; i+=2) //<=?
    {
        string person1Name = cmd[i];
        string person1Money = cmd[i+1];
        people.Add(new Person(person1Name, double.Parse(person1Money)));
    }

cmd = new(Console.ReadLine()
        .Split(new char[] { '=', ';' }, StringSplitOptions.RemoveEmptyEntries));

    List<Product> products = new();
    for (int i = 0; i < cmd.Count; i += 2) //<=?
    {
        string product1Name = cmd[i];
        string product1Money = cmd[i + 1];
        products.Add(new Product(product1Name, double.Parse(product1Money)));
    }

string input;

    while ((input = Console.ReadLine()) != "END")
    {
        cmd = new(input.Split());
        Person currentPerson = people.First(c => c.Name == cmd[0]);
        Product currentProduct = products.First(p => p.Name == cmd[1]);

        Console.WriteLine(currentPerson.Buy(currentProduct));
    }
foreach (Person person in people)
    {
        if(person.BagOfProducts.Count > 0)
        {
            Console.WriteLine($"{person.Name} - {string.Join(", ", person.BagOfProducts)}");
        }
        else
        {
            Console.WriteLine($"{person.Name} - Nothing bought");
        }
    }
}
catch (Exception ex)
{

    Console.WriteLine(ex.Message);
}