using System.Collections.Generic;

namespace BrazilianFootballLeague.DataAccess.Initializers.DataImport
{
    public class JsonFileImportType
    {
        public IEnumerable<JsonCompetitionsType> Competitions { get; set; }
    }
}