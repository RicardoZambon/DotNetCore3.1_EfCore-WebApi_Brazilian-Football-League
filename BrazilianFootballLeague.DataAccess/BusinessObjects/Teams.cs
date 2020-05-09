using BrazilianFootballLeague.DataAccess.Interfaces;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace BrazilianFootballLeague.DataAccess.BusinessObjects
{
    public class Teams : BaseDBEntity, IResultTotal
    {
        [StringLength(100)]
        public string Name { get; set; }

        public virtual States State { get; set; }
        public int StateID { get; set; }


        public virtual ICollection<Competitions_ResultTable> Results { get; set; }


        public int GetTotalCompetitions() => Results.Count();

        public int GetTotalPoints() => Results.Sum(x => x.Points);
        public int GetTotalPlayed() => Results.Sum(x => x.Played);
        public int GetTotalWon() => Results.Sum(x => x.Won);
        public int GetTotalDrawn() => Results.Sum(x => x.Drawn);
        public int GetTotalLost() => Results.Sum(x => x.Lost);
        public int GetTotalGoalsFor() => Results.Sum(x => x.GoalsFor);
        public int GetTotalGoalsAgainst() => Results.Sum(x => x.GoalsAgainst);
    }
}