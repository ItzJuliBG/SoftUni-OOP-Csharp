using Raiding.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raiding.Models
{
    public class Paladin : BaseHero, IBaseHero
    {
        private string actionType = "healed";
        public Paladin(string name) 
            : base(name)
        {
            this.Power = 100;
            this.ActionType = actionType;
        }
    }
}
