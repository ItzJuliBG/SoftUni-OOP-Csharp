using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace _01.ClassBoxData
{
    public class Box
    {
        private double length;
        private double width;
        private double height;

        public Box(double length, double width, double heigh)
        {
            Length = length;
            Width = width;
            Heigh = heigh;
        }

        public double Length
        {
            get { return length; }
            private set
            {
                if (value <= 0)
                {

                    throw new ArgumentException($"{nameof(Length)} cannot be zero or negative.");
                }
                length = value;
            }
        }
        public double Width
        {
            get { return width; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"{nameof(Width)} cannot be zero or negative.");
                }
                width = value;
            }
        }
        public double Heigh
        {
            get { return height; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"{nameof(Heigh)} cannot be zero or negative.");
                }
                height = value;
            }
        }
        public double SurfaceArea() //Surface Area = 2lw + 2lh + 2wh
        {
            double result = 2 * Length * Width + 2 * Length * Heigh + 2 * Width * Heigh;
            return result;
        }
        public double LateralSurfaceArea() //Lateral Surface Area = 2lh + 2wh
        {
            return 2 * Length * Heigh + 2 * Width * Heigh;
        }
        public double Volume() //Volume = lwh
        {
            return Length * Width * Heigh;
        }


    }
}
