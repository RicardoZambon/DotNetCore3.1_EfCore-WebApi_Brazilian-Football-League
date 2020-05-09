using BrazilianFootballLeague.DataAccess.BusinessObjects;

namespace BrazilianFootballLeague.WebApi.Models
{
    public class ResultsModel
    {
        public string Team { get; }

        public int Position { get; }

        public int Points { get; }
        public int Played { get; }
        public int Won { get; }
        public int Drawn { get; }
        public int Lost { get; }
        public int GoalsFor { get; }
        public int GoalsAgainst { get; }


        public ResultsModel(Competitions_ResultTable result)
        {
            Team = result.Team.Name;

            Position = result.Position;

            Points = result.Points;
            Played = result.Played;
            Won = result.Won;
            Drawn = result.Drawn;
            Lost = result.Lost;
            GoalsFor = result.GoalsFor;
            GoalsAgainst = result.GoalsAgainst;
        }
    }
}