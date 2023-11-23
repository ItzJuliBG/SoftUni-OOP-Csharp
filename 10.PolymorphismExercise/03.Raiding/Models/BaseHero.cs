using Raiding.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raiding.Models
{
    public abstract class BaseHero : IBaseHero
    {

        protected BaseHero(string name)
        {
            Name = name;
        }

        public string Name { get; private set; }
        public int Power { get; protected set; }
        public string ActionType { get; protected set; }

        public virtual string CastAbility()
        {
            return $"{GetType().Name} - {Name} {ActionType} for {Power}";
        }
       
    }
}
