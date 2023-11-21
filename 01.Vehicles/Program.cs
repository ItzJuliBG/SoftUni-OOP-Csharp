using Vehicles;
List<IVehicle> vehicles = new List<IVehicle>();
List<string> input = new(Console.ReadLine().Split());
vehicles.Add(new Car(double.Parse(input[1]), double.Parse(input[2])));
input = new(Console.ReadLine().Split());
vehicles.Add(new Truck(double.Parse(input[1]), double.Parse(input[2])));
int lines = int.Parse(Console.ReadLine());

for (int i = 0; i < lines; i++)
{
    input = new(Console.ReadLine().Split());
    IVehicle currentVehicle = vehicles.FirstOrDefault(v=>v.GetType().Name == input[1]);
    if (input[0] == "Drive")
    {
        Console.WriteLine(currentVehicle.Drive(double.Parse(input[2])));
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