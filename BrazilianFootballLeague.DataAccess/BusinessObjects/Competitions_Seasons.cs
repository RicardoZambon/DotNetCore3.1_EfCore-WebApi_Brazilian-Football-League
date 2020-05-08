using System.Collections.Generic;

namespace BrazilianFootballLeague.DataAccess.BusinessObjects
{
    public class Competitions_Seasons : BaseDBEntity
    {
        public virtual Competitions Competition { get; set; }
        public int CompetitionID { get; set; }

        public int Year { get; set; }


        public virtual ICollection<Competitions_ResultTable> Results { get; set; }
    }
}