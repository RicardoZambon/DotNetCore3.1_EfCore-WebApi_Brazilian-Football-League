using BrazilianFootballLeague.DataAccess.Interfaces;
using BrazilianFootballLeague.WebApi.Interfaces;

namespace BrazilianFootballLeague.WebApi.Models
{
    public abstract class BaseResultModel : IResultModel
    {
        public int Rank { get; }

        public int TotalCompetitions { get; }

        public int TotalPoints { get; }
        public int TotalPlayed { get; }
        public int TotalWon { get; }
        public int TotalDrawn { get; }
        public int TotalLost { get; }
        public int TotalGoalsFor { get; }
        public int TotalGoalsAgainst { get; }

        public int GoalDifference { get { return TotalGoalsFor - TotalGoalsAgainst; } }


        public BaseResultModel(IResultTotal resultEntity, int rank)
        {
            Rank = rank;

            TotalCompetitions = resultEntity.GetTotalCompetitions();

            TotalPoints = resultEntity.GetTotalPoints();
            TotalPlayed = resultEntity.GetTotalPlayed();
            TotalWon = resultEntity.GetTotalWon();
            TotalDrawn = resultEntity.GetTotalDrawn();
            TotalLost = resultEntity.GetTotalLost();
            TotalGoalsFor = resultEntity.GetTotalGoalsFor();
            TotalGoalsAgainst = resultEntity.GetTotalGoalsAgainst();
        }
    }
}