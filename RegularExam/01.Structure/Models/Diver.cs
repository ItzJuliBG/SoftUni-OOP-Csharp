using NauticalCatchChallenge.Models.Contracts;
using NauticalCatchChallenge.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NauticalCatchChallenge.Models
{
    public abstract class Diver : IDiver
    {
        private string name;
        private List<string> catches;
        public string Name
        {
            get { return name; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.DiversNameNull);
                }
                name = value;
            }
        }

        private int oxygenLevel;

        protected Diver(string name, int oxygenLevel)
        {
            Name = name;
            OxygenLevel = oxygenLevel;
        }

        public int OxygenLevel
        {
            get { return oxygenLevel; }
            protected set
            {
                if (value <0)
                {
                    oxygenLevel = 0;
                }
                else
                {
                    oxygenLevel = value;
                }
            }
        }


        public IReadOnlyCollection<string> Catch => catches; // asreadonly() maybe

        public double CompetitionPoints {get; private set;}

        public bool HasHealthIssues { get; private set; }

        public void Hit(IFish fish)
        {
            this.OxygenLevel -= fish.TimeToCatch;
            catches.Add(fish.Name);
            CompetitionPoints += fish.Points;
        }

        public abstract void Miss(int TimeToCatch);
        public abstract void RenewOxy();

        public void UpdateHealthStatus()
        {
            if (HasHealthIssues)
            {
                HasHealthIssues = false;
            }
            else
            {
                HasHealthIssues = true;
            }
        }
        public override string ToString()
        {
            return $"Diver [ Name: {Name}, Oxygen left: {OxygenLevel}, Fish caught: {Catch.Count}, Points earned: { CompetitionPoints} ]";
        }
    }
}
