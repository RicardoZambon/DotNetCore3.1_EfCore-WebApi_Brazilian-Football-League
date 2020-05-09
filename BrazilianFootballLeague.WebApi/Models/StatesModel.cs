using BrazilianFootballLeague.DataAccess.BusinessObjects;

namespace BrazilianFootballLeague.WebApi.Models
{
    public class StatesModel : BaseResultModel
    {
        public string State { get; }


        public StatesModel(States state, int rank) : base(state, rank)
        {
            State = state.Name;
        }
    }
}