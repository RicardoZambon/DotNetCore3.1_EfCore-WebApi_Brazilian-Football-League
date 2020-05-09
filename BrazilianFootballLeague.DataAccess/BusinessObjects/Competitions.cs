using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace BrazilianFootballLeague.DataAccess.BusinessObjects
{
    public class Competitions : BaseDBEntity
    {
        [StringLength(100)]
        public string Name { get; set; }


        public virtual ICollection<CompetitionsSeasons> Seasons { get; set; }


        public Teams GetBestTeam_GoalsFor(Competitions competitions)
        {
            return Seasons
                .SelectMany(x => x.Results.Select(y => new { y.Team, y.GoalsFor }))
                .GroupBy(x => x.Team)
                .Select(x => new { Team = x.Key, GoalsFor = x.Average(y => y.GoalsFor) })
                .OrderByDescending(x => x.GoalsFor)
                .FirstOrDefault()
                .Team;
        }
    }
}