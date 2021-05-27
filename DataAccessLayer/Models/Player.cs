using QuickType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class Player
    {
        public StartingEleven PlayerSE { get; set; }
        public int YellowCards { get; set; }
        public int GoalsScored { get; set; }

        public override string ToString() => $"{PlayerSE.Name} {PlayerSE.ShirtNumber} {PlayerSE.Position} {YellowCards} {GoalsScored}";
    }
}
