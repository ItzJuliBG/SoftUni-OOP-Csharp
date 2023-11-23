using Raiding.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raiding.Models
{
    public class Rogue : BaseHero, IBaseHero
    {
        private string actionType = "hit";
        public Rogue(string name) 
            : base(name)
        {
            this.Power = 80;
            this.ActionType = actionType;
        }
        public override string CastAbility()
        {
            return base.CastAbility() + " damage";
        }
    }
}
