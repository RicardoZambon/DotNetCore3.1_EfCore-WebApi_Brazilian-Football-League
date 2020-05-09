using System.Collections.Generic;

namespace BrazilianFootballLeague.DataAccess.BusinessObjects
{
    public class CompetitionsSeasons : BaseDBEntity
    {
        public virtual Competitions Competition { get; set; }
        public int CompetitionID { get; set; }

        public int Year { get; set; }


        public virtual ICollection<CompetitionsResultTable> Results { get; set; }
    }
}