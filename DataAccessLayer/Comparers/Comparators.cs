using DataAccessLayer.Models;
using QuickType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
	public class YellowCardsDescComparer : IComparer<Player>
	{
		public int Compare(Player x, Player y)
		{
			return x.YellowCards.CompareTo(y.YellowCards);
		}
	}

	public class YellowCardsAscComparer : IComparer<Player>
	{
		public int Compare( Player x, Player y )
		{
			return -x.YellowCards.CompareTo(y.YellowCards);
		}
	}

	public class GoalsScoredDescComparer : IComparer<Player>
	{
		public int Compare( Player x, Player y )
		{
			return x.GoalsScored.CompareTo(y.GoalsScored);
		}
	}
	
	public class GoalsScoredAscComparer : IComparer<Player>
	{
		public int Compare( Player x, Player y )
		{
			return -x.GoalsScored.CompareTo(y.GoalsScored);
		}
	}
}
