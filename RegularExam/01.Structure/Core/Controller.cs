using NauticalCatchChallenge.Core.Contracts;
using NauticalCatchChallenge.Models;
using NauticalCatchChallenge.Models.Contracts;
using NauticalCatchChallenge.Repositories;
using NauticalCatchChallenge.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace NauticalCatchChallenge.Core
{
    public class Controller : IController
    {
        private List<string> possibleDiverTypes = new List<string> { "FreeDiver", "ScubaDiver" };
        private List<string> possibleFishTypes = new List<string> { "ReefFish", "DeepSeaFish", "PredatoryFish" };
        private IRepository<IDiver> divers;
        private IRepository<IFish> fishes;
        public Controller()
        {
            this.divers = new DiverRepository();
            this.fishes = new FishRepository();
        }

        public string DiveIntoCompetition(string diverType, string diverName)
        {
            IDiver diver = divers.GetModel(diverName);
            if (!possibleDiverTypes.Contains(diverType))
            {
                return $"{diverType} is not allowed in our competition.";
            }
            if (diver != null)
            {
                return $"{diverName} is already a participant -> {divers.GetType().Name}.";
            }
            if (diverType == "FreeDiver")
            {
                diver = new FreeDiver(diverName);
                divers.AddModel(diver);
            }
            else
            {
                diver = new ScubaDiver(diverName);
                divers.AddModel(diver);
            }
            return $"{diverName} is successfully registered for the competition -> {divers.GetType().Name}.";

        }
        public string SwimIntoCompetition(string fishType, string fishName, double points)
        {
      var fish = fishes.GetModel(fishName);
            
            if (!possibleFishTypes.Contains(fishType))
            {
                return $"{fishType} is forbidden for chasing in our competition.";
            }
            if (fish != null)
            {
                return $"{fishName} is already allowed -> {fishes.GetType().Name}.";
            }
            if (fishType == "ReefFish")
            {
                fish = new ReefFish(fishName, points);
            }
            else if (fishType == "DeepSeaFish")
            {
                fish = new DeepSeaFish(fishName, points);
            }
            else
            {
                fish = new PredatoryFish(fishName, points);
            }
            return $"{fishName} is allowed for chasing.";
        }
        public string ChaseFish(string diverName, string fishName, bool isLucky)
        {
            IDiver diver = divers.GetModel(diverName);
            IFish fish = fishes.GetModel(fishName);
            if (diver.OxygenLevel <= 0)
            {
                diver.UpdateHealthStatus();
            }
            if (diver is null)
            {
                return $"{divers.GetType().Name} has no {diverName} registered for the competition.";
            }
            if (fish is null)
            {
                return $"{fishName} is not allowed to be caught in this competition.";
            }
            if (diver.HasHealthIssues)
            {
                return $"{diverName} will not be allowed to dive, due to health issues.";
            }
            if (diver.OxygenLevel < fish.TimeToCatch)
            {
                diver.Miss(fish.TimeToCatch);
                return $"{diverName} missed a good {fishName}.";
            }
            if (diver.OxygenLevel == fish.TimeToCatch)
            {
                if (isLucky)
                {
                    diver.Hit(fish);
                    return $"{diverName} hits a {fish.Points}pt. {fishName}.";
                }
                diver.Miss(fish.TimeToCatch);
                return $"{diverName} missed a good {fishName}.";
            }
            diver.Hit(fish);
            return $"{diverName} hits a {fish.Points}pt. {fishName}.";
        }
        public string HealthRecovery()
        {
            int recoveredCount = 0;
            if (divers.Models.Any(x => x.HasHealthIssues))
            {
                List<IDiver> diversThatNeedRecovery = divers.Models.Where(x => x.HasHealthIssues).ToList();
                foreach (var diver in diversThatNeedRecovery)
                {
                    diver.UpdateHealthStatus();
                    diver.RenewOxy();
                    recoveredCount++;
                }
            }
            return $"Divers recovered: {recoveredCount}";
        }
        public string DiverCatchReport(string diverName)
        {
           IDiver diver = divers.Models.FirstOrDefault(x => x.Name == diverName);
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Diver [ Name: {diver.Name}, Oxygen left: {diver.OxygenLevel}, Fish caught: {diver.Catch.Count}, Points earned: {diver.CompetitionPoints} ]");
            sb.AppendLine("Catch Report:");
            foreach (var currentCatch in diver.Catch)
            {
                sb.AppendLine(currentCatch.ToString());
            }
            return sb.ToString();
        }

        public string CompetitionStatistics()
        {
            List<IDiver> sortedList = divers.Models.OrderByDescending(x=> x.CompetitionPoints)
                .ThenByDescending(x=> x.Catch.Count)
                .ThenBy(x=>x.Name)
                .ToList();
            sortedList = sortedList.Where(x => x.HasHealthIssues is false).ToList();
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("**Nautical-Catch-Challenge**");
            foreach (var diver in sortedList)
            {
                sb.AppendLine(diver.ToString());
            }
            return sb.ToString();
        }
    }
}
