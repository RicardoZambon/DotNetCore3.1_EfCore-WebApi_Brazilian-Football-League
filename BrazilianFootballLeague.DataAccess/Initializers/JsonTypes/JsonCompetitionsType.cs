using System.Collections.Generic;

namespace BrazilianFootballLeague.DataAccess.Initializers.DataImport
{
    public class JsonCompetitionsType
    {
        public string Name { get; set; }

        public IEnumerable<JsonSeasonsType> Seasons { get; set; }
    }
}