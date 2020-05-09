using BrazilianFootballLeague.DataAccess.BusinessObjects;
using System.Collections.Generic;
using System.Linq;

namespace BrazilianFootballLeague.WebApi.Models
{
    public class CompetitionsModel
    {
        public string Competition { get; }

        public IEnumerable<SeasonsModel> Seasons { get; }


        public CompetitionsModel(Competitions competition)
        {
            Competition = competition.Name;
            Seasons = competition.Seasons.Select(x => new SeasonsModel(x));
        }
    }
}