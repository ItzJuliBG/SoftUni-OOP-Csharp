using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            //int radius = int.Parse(Console.ReadLine());
            //IDrawable circle = new Circle(radius);
            //    circle.Draw();
            var width = int.Parse(Console.ReadLine());
            var height = int.Parse(Console.ReadLine());
            IDrawable rect = new Rectangle(width, height);
            //        circle.Draw();
            rect.Draw();

        }

    }
}
