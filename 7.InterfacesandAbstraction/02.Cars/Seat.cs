using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    public class Seat : ICar
    {
        public Seat(string color, string model)
        {
            Color = color;
            Model = model;
        }

        public string Color { get; set; }
        public string Model { get; set; }

        public string Start()
        {
            return($"Engine start!"); 
            
        }

        public string Stop()
        {
            return "Breaaak!";
        }
        public override string ToString()
        {
            return $"{Color} Seat {Model}";
        }
    }
}

//Grey Seat Leon
//Engine start
//Breaaak!
//Red Tesla Model 3 with 2 Batteries
//Engine start
//Breaaak!