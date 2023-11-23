using Raiding.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raiding.Models
{
    public class Warrior : BaseHero, IBaseHero
    {
        private string actionType = "hit";
        public Warrior(string name) 
            : base(name)
        {
            this.Power = 100;
            this.ActionType = actionType;
        }
        public override string CastAbility()
        {
            return base.CastAbility() + " damage";
        }
    }
}
