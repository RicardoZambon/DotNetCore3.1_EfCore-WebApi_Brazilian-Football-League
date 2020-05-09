using BrazilianFootballLeague.DataAccess;
using BrazilianFootballLeague.WebApi.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace BrazilianFootballLeague.WebApi.Controllers
{
    [ApiController, Route("~/api/{controller}")]
    public class StatesController : ControllerBase
    {
        private readonly AppDbContext _ctx;

        public StatesController(AppDbContext ctx)
        {
            _ctx = ctx;
        }


        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var teams = await _ctx.GetRanked(_ctx.States);
            if (teams.Count() > 0)
            {
                return Ok(teams.Select((team, index) => new StatesModel(team, index + 1)));
            }
            else
            {
                return NotFound();
            }
        }
    }
}