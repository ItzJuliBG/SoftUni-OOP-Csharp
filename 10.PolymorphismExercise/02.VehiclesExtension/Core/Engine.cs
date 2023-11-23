using Vehicles.Core.Interfaces;
using Vehicles.IO.Interfaces;
using Vehicles.Models;

namespace Vehicles.Core;

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
        try
        {
            List<IVehicle> vehicles = new List<IVehicle>();
            List<string> input = new(Console.ReadLine().Split());
            vehicles.Add(new Car(double.Parse(input[1]), double.Parse(input[2]), double.Parse(input[3])));
            input = new(Console.ReadLine().Split());
            vehicles.Add(new Truck(double.Parse(input[1]), double.Parse(input[2]), double.Parse(input[3])));
            input = new(Console.ReadLine().Split());
            int lines = int.Parse(Console.ReadLine());
            vehicles.Add(new Bus(double.Parse(input[1]), double.Parse(input[2]), double.Parse(input[3])));

            for (int i = 0; i < lines; i++)
            {
                input = new(Console.ReadLine().Split());
                IVehicle currentVehicle = vehicles.FirstOrDefault(v => v.GetType().Name == input[1]);
                if (input[0] == "Drive")
                {
                    Console.WriteLine(currentVehicle.Drive(double.Parse(input[2])));
                }
                else if (input[0] == "DriveEmpty")
                {
                    Console.WriteLine(currentVehicle.DriveEmpty(double.Parse(input[2])));
                }
                else
                {
                    currentVehicle.Refuel(double.Parse(input[2]));
                }
            }
            foreach (var vehicle in vehicles)
            {
                Console.WriteLine(vehicle);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}

