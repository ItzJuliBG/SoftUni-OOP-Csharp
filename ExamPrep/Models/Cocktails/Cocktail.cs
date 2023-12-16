using ChristmasPastryShop.Models.Cocktails.Contracts;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime;
using System.Text;
using System.Xml.Linq;

namespace ChristmasPastryShop.Models.Cocktails
{
    public abstract class Cocktail : ICocktail
    {
        private string name;
        private double price;

        protected Cocktail(string name, string size, double price)
        {
            Name = name;
            Size = size;
            Price = price;
        }

        public string Name
        {
            get { return name; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                { throw new ArgumentException("Name cannot be null or whitespace!"); }
                else { name = value; }
            }
        }

        public string Size { get; private set; }

        public double Price
        {
            get { return price; }
            private set
            {
                if (Size == "Small")
                {
                    price = value / 3;
                }
                else if (Size == "Middle")
                {
                    price = (value / 3) * 2;
                }
                else if (Size == "Large")
                {
                    price = value;
                }
                else
                {
                    throw new ArgumentException("Unavailable size!");
                }
                price = value;
            }
        }
        public override string ToString()
        {
            return $"{Name} ({Size}) - {Price:f2} lv";
        }
    }
}
