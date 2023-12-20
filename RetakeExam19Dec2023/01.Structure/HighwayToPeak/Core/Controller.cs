using HighwayToPeak.Core.Contracts;
using HighwayToPeak.IO;
using HighwayToPeak.Models;
using HighwayToPeak.Models.Contracts;
using HighwayToPeak.Repositories;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighwayToPeak.Core
{
    public class Controller : IController
    {
        private PeakRepository peaks = new PeakRepository();
        private ClimberRepository climbers = new ClimberRepository();
        private BaseCamp baseCamp = new BaseCamp();
        public Controller()
        {
        }

        public string AddPeak(string name, int elevation, string difficultyLevel)
        {
            if (peaks.Get(name) != null)
            {
                return $"{name} is already added as a valid mountain destination.";
            }
            if (difficultyLevel != "Extreme" && difficultyLevel != "Hard" && difficultyLevel != "Moderate")
            {
                return $"{difficultyLevel} peaks are not allowed for international climbers.";
            }
            IPeak peak = new Peak(name, elevation, difficultyLevel);
            peaks.Add(peak);
            return $"{name} is allowed for international climbing. See details in PeakRepository.";

        }

        public string AttackPeak(string climberName, string peakName)
        {
            IClimber climber = climbers.Get(climberName);
            IPeak peak = peaks.Get(peakName);
            if (climber == null)
            {
                return $"Climber - {climberName}, has not arrived at the BaseCamp yet.";
            }
            if (peak == null)
            {
                return $"{peakName} is not allowed for international climbing.";
            }
            if (!baseCamp.Residents.Contains(climberName))
            {
                return $"{climberName} not found for gearing and instructions. The attack of {peakName} will be postponed.";
            }
            if (peak.DifficultyLevel == "Extreme" && climber is NaturalClimber) // or with gettype
            {
                return $"{climberName} does not cover the requirements for climbing {peakName}.";
            }
            baseCamp.LeaveCamp(climberName);
            climber.Climb(peak);
            if (climber.Stamina == 0)
            {
                return $"{climberName} did not return to BaseCamp.";
            }
            baseCamp.ArriveAtCamp(climberName);
            return $"{climberName} successfully conquered {peakName} and returned to BaseCamp.";
        }
        public string BaseCampReport()
        {
            if (baseCamp.Residents.Count == 0)
            {
                return $"BaseCamp is currently empty.";
            }
            IClimber climber = null;
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("BaseCamp residents:");
            foreach (string name in baseCamp.Residents)
            {
                climber = climbers.Get(name);
                sb.AppendLine($"Name: {climber.Name}, Stamina: {climber.Stamina}, Count of Conquered Peaks: {climber.ConqueredPeaks.Count}");
            }
            return sb.ToString().Trim();
        }

        public string CampRecovery(string climberName, int daysToRecover)
        {
            IClimber climber = climbers.Get(climberName);
            if (!baseCamp.Residents.Contains(climberName))
            {
                return $"{climberName} not found at the BaseCamp.";
            }
            if (climber.Stamina == 10) //if needed then natural == 6 
            {
                return $"{climberName} has no need of recovery.";
            }
            climber.Rest(daysToRecover);
            return $"{climberName} has been recovering for {daysToRecover} days and is ready to attack the mountain.";
        }

        public string NewClimberAtCamp(string name, bool isOxygenUsed)
        {
            IClimber climber = null;
            if (climbers.Get(name) != null)
            {
                return $"{name} is a participant in ClimberRepository and cannot be duplicated.";
            }
            if (isOxygenUsed)
            {
                climber = new OxygenClimber(name);
            }
            else
            {
                climber = new NaturalClimber(name);
            }
            climbers.Add(climber);
            baseCamp.ArriveAtCamp(name);
            return $"{name} has arrived at the BaseCamp and will wait for the best conditions.";

        }

        public string OverallStatistics()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("***Highway-To-Peak***".Trim());
            List<IClimber> sortedClimbers = climbers.All.OrderByDescending(x => x.ConqueredPeaks.Count).ThenBy(x => x.Name).ToList();
            foreach (var climber in sortedClimbers)
            {
                sb.AppendLine(climber.ToString().Trim());
                List<IPeak> sortedPeaks = new List<IPeak>();
                foreach (var peak in climber.ConqueredPeaks)
                {
                    sortedPeaks.Add(peaks.Get(peak));
                }
                sortedPeaks = sortedPeaks.OrderByDescending(x => x.Elevation).ToList();
                foreach(var peak in sortedPeaks)
                {
                    sb.AppendLine(peak.ToString().Trim());
                }
            }
            return sb.ToString().Trim();
        }
    }
}
