using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildFarm.Models.Interfaces;

namespace WildFarm.Models
{
    public class Meat : Food, IFood
    {
        public Meat(int quantity) : base(quantity)
        {
        }
    }
}
