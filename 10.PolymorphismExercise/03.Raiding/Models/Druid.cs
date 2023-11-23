using Raiding.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raiding.Models
{
    public class Druid : BaseHero, IBaseHero
    {
        private string actionType = "healed";
        public Druid(string name) 
            : base(name)
        {
            this.Power = 80;
            this.ActionType = actionType;
        }
      
    }
}
