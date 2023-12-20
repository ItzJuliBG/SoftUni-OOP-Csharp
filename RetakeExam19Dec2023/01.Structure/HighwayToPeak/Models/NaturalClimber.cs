using HighwayToPeak.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighwayToPeak.Models
{
    public class NaturalClimber : Climber
    {
        private const int naturOxy = 6;
        private const int staminaRecoveredPerDay = 2;
        public NaturalClimber(string name) : base(name, naturOxy)
        {
        }
//Will NOT be allowed to climb peaks with extreme difficulty level.
        public override void Rest(int daysCount)
        {
            Stamina += staminaRecoveredPerDay * daysCount;
            if (Stamina > 10)
            {
                Stamina = 10;
            }
        }
    }
}
