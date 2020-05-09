namespace BrazilianFootballLeague.WebApi.Interfaces
{
    public interface IResultModel
    {
        int Rank { get; }

        int TotalCompetitions { get; }

        int TotalPoints { get; }
        int TotalPlayed { get; }
        int TotalWon { get; }
        int TotalDrawn { get; }
        int TotalLost { get; }
        int TotalGoalsFor { get; }
        int TotalGoalsAgainst { get; }
    }
}