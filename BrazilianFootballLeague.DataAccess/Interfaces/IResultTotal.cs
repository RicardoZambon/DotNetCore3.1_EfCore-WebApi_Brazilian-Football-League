namespace BrazilianFootballLeague.DataAccess.Interfaces
{
    public interface IResultTotal
    {
        int GetTotalCompetitions();

        int GetTotalPoints();
        int GetTotalPlayed();
        int GetTotalWon();
        int GetTotalDrawn();
        int GetTotalLost();
        int GetTotalGoalsFor();
        int GetTotalGoalsAgainst();
    }
}