using WildFarm.IO.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using WildFarm.Models.Interfaces;
using WildFarm.Models;

namespace WildFarm.Core;

public class Engine : IEngine
{
    private readonly IReader reader;
    private readonly IWriter writer;

    public Engine(IReader reader, IWriter writer)
    {
        this.reader = reader;
        this.writer = writer;
    }
    public void Run()
    {
        string cmd;
        List<IAnimal> animals = new List<IAnimal>();
        while((cmd = reader.ReadLine()) != $"End") 
        { 
            List<string> input = cmd.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
            IAnimal animal = null;
            switch (input[0])
            {
                case "Hen":
                    animal = new Hen(input[1], double.Parse(input[2]), double.Parse(input[3]));
                    break;
                case "Owl":
                    animal = new Owl(input[1], double.Parse(input[2]), double.Parse(input[3]));
                    break;
                case "Mouse":
                    animal = new Mouse(input[1], double.Parse(input[2]), input[3]);
                    break;
                case "Cat":
                    animal = new Cat(input[1], double.Parse(input[2]), input[3], input[4]);
                    break;
                case "Dog":
                    animal = new Dog(input[1], double.Parse(input[2]), input[3]);
                    break;
                case "Tiger":
                    animal = new Tiger(input[1], double.Parse(input[2]), input[3], input[4]);
                    break;
            }
            animals.Add(animal);
            input = new(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries));
            IFood food = null;
            switch (input[0])
            {
                case "Vegetable":
                    food = new Vegetable(int.Parse(input[1]));
                    break;
                case "Fruit":
                    food = new Fruit(int.Parse(input[1]));
                    break;
                case "Meat":
                    food = new Meat(int.Parse(input[1]));
                    break;
                case "Seeds":
                    food = new Seeds(int.Parse(input[1]));
                    break;
            }
            Console.WriteLine(animal.ProduceSound());
            animal.Eat(food);
        }
        foreach (var animal in animals)
        {
            Console.WriteLine(animal);
        }
    }
}

