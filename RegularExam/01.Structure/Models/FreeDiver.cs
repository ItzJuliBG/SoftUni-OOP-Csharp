using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NauticalCatchChallenge.Models
{
    public class FreeDiver : Diver
    {
        private const int customOxyLevel = 120;
        public FreeDiver(string name) : base(name, customOxyLevel)
        {
        }

        public override void Miss(int TimeToCatch)
        {
           base.OxygenLevel = (int)Math.Round(TimeToCatch*0.4);
        }

        public override void RenewOxy()
        {
            base.OxygenLevel = customOxyLevel;
        }
    }
}
