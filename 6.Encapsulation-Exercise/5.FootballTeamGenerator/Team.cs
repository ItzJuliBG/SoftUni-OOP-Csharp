using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.FootballTeamGenerator
{
    public class Team
    {
		private string name;
		private List<Player> players;

		public List<Player> Players
		{
			get { return players; }
			set { players = value; }
		}


		public string Name
		{
			get { return name; }
			set { name = value; }
		}
		public void AddPlayer(string playerName, List<int> stats)
		{
			players.Add(new Player(playerName, stats));
		}
		public void RemovePlayer(Player player)
		{
			players.Remove(player);
		}
		public string Rating()
		{
			double totalScore = 0;
			foreach (Player player in players) 
			{
				totalScore += player.Stats.Average();
			}
			return $"{Name} - {totalScore}";
		}

	}
}
