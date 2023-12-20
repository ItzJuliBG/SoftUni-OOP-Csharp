using HighwayToPeak.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighwayToPeak.Models
{
    public class BaseCamp : IBaseCamp
    {
        private List<string> climbersList = new List<string>();
        public BaseCamp()
        {

        }
        public IReadOnlyCollection<string> Residents => climbersList.OrderBy(x => x).ToList();

        public void ArriveAtCamp(string climberName)
        {
            climbersList.Add(climberName);
        }

        public void LeaveCamp(string climberName)
        {
            climbersList.Remove(climberName);
        }
    }
}
