using BrazilianFootballLeague.DataAccess.BusinessObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace BrazilianFootballLeague.WebApi.Models
{
    public class CompetitionsModel
    {
        public string Competition { get; }

        public IEnumerable<SeasonsModel> Seasons { get; }


        public CompetitionsModel(Competitions competition, int? limitSeasonYear)
        {
            Competition = competition.Name;
            Seasons = competition.Seasons.Where(x => limitSeasonYear == null || x.Year >= limitSeasonYear).Select(x => new SeasonsModel(x));
        }
    }
}