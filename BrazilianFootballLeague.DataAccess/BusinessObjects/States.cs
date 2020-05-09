using BrazilianFootballLeague.DataAccess.Interfaces;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace BrazilianFootballLeague.DataAccess.BusinessObjects
{
    public class States : BaseDBEntity, IResultTotal
    {
        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(2)]
        public string Code { get; set; }


        public virtual ICollection<Teams> Teams { get; set; }


        public int GetTotalCompetitions() => Teams.SelectMany(x => x.Results.Select(y => y.SeasonID)).Distinct().Count();

        public int GetTotalPoints() => Teams.Sum(x => x.GetTotalPoints());
        public int GetTotalPlayed() => Teams.Sum(x => x.GetTotalPlayed());
        public int GetTotalWon() => Teams.Sum(x => x.GetTotalWon());
        public int GetTotalDrawn() => Teams.Sum(x => x.GetTotalDrawn());
        public int GetTotalLost() => Teams.Sum(x => x.GetTotalLost());
        public int GetTotalGoalsFor() => Teams.Sum(x => x.GetTotalGoalsFor());
        public int GetTotalGoalsAgainst() => Teams.Sum(x => x.GetTotalGoalsAgainst()) ;
    }
}