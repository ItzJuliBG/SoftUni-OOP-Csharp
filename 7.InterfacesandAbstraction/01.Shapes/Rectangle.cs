using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Rectangle : IDrawable
    {

        private int width;

        private int height;

        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public int Width
        {
            get { return width; }
            private set { width = value; }
        }
        public int Height
        {
            get { return height; }
            private set { height = value; }
        }


        public void Draw()
        {
            this.DrawLine();
            Console.WriteLine();
            for (int i = 0; i < height-2; i++)
            {
                Console.Write("*");
                for (int j = 0; j < width-2; j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("*");
            }
            this.DrawLine();
        }
        private void DrawLine()
        {
            for (int i = 0; i < width; i++)
            {
                Console.Write("*");
            }
        }
    }
}
