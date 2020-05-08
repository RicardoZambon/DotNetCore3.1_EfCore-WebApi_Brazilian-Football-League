namespace BrazilianFootballLeague.DataAccess.Initializers.DataImport
{
    public class JsonResultsType
    {
        public string Team { get; set; }

        public int Position { get; set; }

        public int Points { get; set; }
        public int Played { get; set; }
        public int Won { get; set; }
        public int Drawn { get; set; }
        public int Lost { get; set; }
        public int GoalsFor { get; set; }
        public int GoalsAgainst { get; set; }

    }
}