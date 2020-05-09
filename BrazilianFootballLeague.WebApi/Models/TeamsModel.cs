using BrazilianFootballLeague.DataAccess.BusinessObjects;

namespace BrazilianFootballLeague.WebApi.Models
{
    public class TeamsModel : BaseResultModel
    {
        public string Team { get; }


        public TeamsModel(Teams team, int rank) : base(team, rank)
        {
            Team = team.Name;
        }
    }
}