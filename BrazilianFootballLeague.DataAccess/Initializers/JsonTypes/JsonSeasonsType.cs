using System.Collections.Generic;

namespace BrazilianFootballLeague.DataAccess.Initializers.DataImport
{
    public class JsonSeasonsType
    {
        public int Year { get; set; }

        public IEnumerable<JsonResultsType> Results { get; set; }
    }
}