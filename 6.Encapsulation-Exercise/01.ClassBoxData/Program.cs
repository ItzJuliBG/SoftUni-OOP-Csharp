using _01.ClassBoxData;

double int1 = double.Parse(Console.ReadLine());
double int2 = double.Parse(Console.ReadLine());
double int3 = double.Parse(Console.ReadLine());
try
{
Box box = new Box(int1, int2, int3);
double surfaceArea = box.SurfaceArea();
double lateralSurfaceArea = box.LateralSurfaceArea();
double volume = box.Volume();
Console.WriteLine($"Surface Area - {surfaceArea:f2}");
Console.WriteLine($"Lateral Surface Area - {lateralSurfaceArea:f2}");
Console.WriteLine($"Volume - {volume:f2}");

}
catch (Exception ex)
{

    Console.WriteLine(ex.Message);
}