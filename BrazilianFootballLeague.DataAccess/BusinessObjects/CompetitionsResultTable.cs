using BrazilianFootballLeague.DataAccess.Interfaces;

namespace BrazilianFootballLeague.DataAccess.BusinessObjects
{
    public class CompetitionsResultTable : BaseDBEntity, IResultTable
    {
        public virtual CompetitionsSeasons Season { get; set; }
        public int SeasonID { get; set; }

        public virtual Teams Team { get; set; }
        public int TeamID { get; set; }

        public int Position { get; set; }

        public int Points { get; set; }
        public int Played { get; set; }
        public int Won { get; set; }
        public int Drawn { get; set; }
        public int Lost { get; set; }
        public int GoalsFor { get; set; }
        public int GoalsAgainst { get; set; }
    }
}