using Raiding.IO.Interfaces;
using Raiding.Models;
using Raiding.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;


namespace Raiding.Core;

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
        int peopleCount = int.Parse(Console.ReadLine());
        ICollection<IBaseHero> list = new List<IBaseHero>();
        double totalHeroPower = 0;
        for (int i = 0; i < peopleCount; i++)
        {
            
            string name = Console.ReadLine();
            string type = Console.ReadLine();
            switch (type)
            {
                case "Druid":
                    {
                        list.Add(new Druid(name));
                    }
                    break;
                case "Paladin":
                    list.Add(new Paladin(name)); break;
                case "Rogue":
                    list.Add(new Rogue(name)); break;
                case "Warrior":
                    list.Add(new Warrior(name)); break;
                default:
                    Console.WriteLine($"Invalid hero!");
                    break;
            }
        }
        double bossHealth = double.Parse(Console.ReadLine());
        foreach (var item in list)
        {
            Console.WriteLine(item.CastAbility());
            totalHeroPower += item.Power;
        }
        if(totalHeroPower >= bossHealth)
        {
            Console.WriteLine("Victory!");
        }
        else
        {
            Console.WriteLine("Defeat...");
        }
    }
}

