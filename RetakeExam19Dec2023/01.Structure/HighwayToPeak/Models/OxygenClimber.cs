using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighwayToPeak.Models
{
    public class OxygenClimber : Climber
    {
        private const int oxyStamina = 10;
        private const int staminaRecoveredPerDay = 1;
        public OxygenClimber(string name) : base(name, oxyStamina)
        {
        }

        public override void Rest(int daysCount)
        {
            Stamina += staminaRecoveredPerDay * daysCount;
            if(Stamina > 10)
            {
                Stamina = 10;
            }
        }
    }
}
