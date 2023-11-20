using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.FootballTeamGenerator
{
    public class Player
    {
        private string name;
        private List<int> stats;

        public Player(string name, List<int> stats)
        {
            Name = name;
            Stats = stats;
        }

        public List<int> Stats
        {
            get { return stats; }
            set
            {
                int t = value.FirstOrDefault(x => x < 1 || x > 50);
                if (t != null)
                {
                    int indexOfExceptionStat = value.IndexOf(t);
                    switch (indexOfExceptionStat)
                    {
                        case 0:
                            throw new Exception("Endurance should be between 0 and 100.");
                        case 1:
                            throw new Exception("Sprint should be between 0 and 100.");
                        case 2:
                            throw new Exception("Dribble should be between 0 and 100.");
                        case 3:
                            throw new Exception("Passing should be between 0 and 100.");
                        case 4:
                            throw new Exception("Shooting should be between 0 and 100.");
                    }

                }
                stats = value;

            }
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("A name should not be empty.");
                }
                name = value;
            }
        }

    }
}
