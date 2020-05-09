using BrazilianFootballLeague.DataAccess.BusinessObjects;
using System.Collections.Generic;
using System.Linq;

namespace BrazilianFootballLeague.WebApi.Models
{
    public class SeasonsModel
    {
        public int Year { get; }

        public IEnumerable<ResultsModel> Results { get; }


        public SeasonsModel(Competitions_Seasons season)
        {
            Year = season.Year;
            Results = season.Results.Select(x => new ResultsModel(x));
        }
    }
}