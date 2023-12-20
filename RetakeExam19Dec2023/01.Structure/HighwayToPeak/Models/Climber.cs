using HighwayToPeak.Models.Contracts;
using HighwayToPeak.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HighwayToPeak.Models
{
    public abstract class Climber : IClimber
    {
        private string name;
        private int stamina;
        private List<string> peaksClimbed = new List<string>();

        protected Climber(string name, int stamina)
        {
            Name = name;
            Stamina = stamina;
        }

        public string Name
        {
            get { return name; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.ClimberNameNullOrWhiteSpace);
                }
                name = value;
            }
        }

        public int Stamina
        {
            get { return stamina; }
            protected set
            {
                if (value > 10)
                {
                    value = 10;
                }
                else if (value < 0)
                {
                    value = 0;
                }
                stamina = value;
            }
        }

        public IReadOnlyCollection<string> ConqueredPeaks => peaksClimbed;

        public void Climb(IPeak peak)
        {
          if(!this.peaksClimbed.Contains(peak.Name))
            {
                peaksClimbed.Add(peak.Name);
            }
            switch (peak.DifficultyLevel)
            {
                case "Moderate":
                    this.stamina -= 2;
                    break;  case "Hard":
                    this.stamina -= 4;
                    break;  case "Extreme":
                    this.stamina -= 6;
                    break;
            }
        }

        public abstract void Rest(int daysCount);
        public override string ToString()
        {
          StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.GetType().Name} - Name: {Name}, Stamina: {Stamina}"); //idk if it has to be gettype.name
            if(this.ConqueredPeaks == null)
            {
                sb.AppendLine($"Peaks conquered: no peaks conquered");
            }
            else
            {
                sb.AppendLine($"Peaks conquered: {ConqueredPeaks.Count}");
            }
            return sb.ToString();
        }
    }
}
