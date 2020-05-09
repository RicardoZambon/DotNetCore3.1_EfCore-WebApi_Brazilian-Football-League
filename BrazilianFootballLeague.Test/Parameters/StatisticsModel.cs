namespace BrazilianFootballLeague.Test.Parameters
{
    public class StatisticsModel
    {
        public int TeamID { get; set; }

        public int Score { get; set; }


        public StatisticsModel(int teamId, int score)
        {
            TeamID = teamId;
            Score = score;
        }
    }
}