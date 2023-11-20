using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            ICar car = new Seat("Grey","Leon");
            Console.WriteLine(car.ToString());
            Console.WriteLine(car.Start());
            Console.WriteLine(car.Stop());
            ICar tesla = new Tesla("Model 3", "Red", 2);
            Console.WriteLine(tesla.ToString());
            Console.WriteLine(tesla.Start());
            Console.WriteLine(tesla.Stop());
        }
    }
}
