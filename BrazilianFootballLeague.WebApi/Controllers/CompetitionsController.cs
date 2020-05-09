using BrazilianFootballLeague.DataAccess;
using BrazilianFootballLeague.WebApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace BrazilianFootballLeague.WebApi.Controllers
{
    [ApiController, Route("~/api/{controller}")]
    public class CompetitionsController : ControllerBase
    {
        private readonly AppDbContext _ctx;

        public CompetitionsController(AppDbContext ctx)
        {
            _ctx = ctx;
        }


        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var competitions = await _ctx.Competitions.ToListAsync();
            if (competitions.Count() > 0)
            {
                return Ok(competitions.Select(x => new CompetitionsModel(x)));
            }
            else
            {
                return NotFound();
            }
        }
    }
}