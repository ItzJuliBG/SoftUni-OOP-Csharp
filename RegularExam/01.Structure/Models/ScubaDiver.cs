using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NauticalCatchChallenge.Models
{
    public class ScubaDiver : Diver
    {
        private const int customOxyLevel = 540;
        public ScubaDiver(string name) : base(name, customOxyLevel)
        {
        }

        public override void Miss(int TimeToCatch)
        {
            base.OxygenLevel = (int)Math.Round(TimeToCatch * 0.7);
        }

        public override void RenewOxy()
        {
            throw new NotImplementedException();
        }
    }
}
