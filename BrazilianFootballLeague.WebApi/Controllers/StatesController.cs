using BrazilianFootballLeague.DataAccess;
using BrazilianFootballLeague.WebApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.Sqlite;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace BrazilianFootballLeague.WebApi.Controllers
{
    [ApiController, Route("~/api/{controller}")]
    public class StatesController : ControllerBase
    {
        private readonly AppDbContext _ctx;
        private readonly ILogger<TeamsController> _logger;

        public StatesController(AppDbContext ctx, ILogger<TeamsController> logger)
        {
            _ctx = ctx;
            _logger = logger;
        }


        [HttpGet]
        public async Task<IActionResult> Index()
        {
            try
            {
                var teams = await _ctx.GetRanked(_ctx.States);
                if (teams.Count() > 0)
                {
                    var statesModel = teams.Select((team, index) => new StatesModel(team, index + 1));

                    _logger.Log(LogLevel.Information, "Successfully returned the list of states.");
                    return Ok(statesModel);
                }
                else
                {
                    _logger.Log(LogLevel.Warning, "Searched for all states, but none found.");
                    return NotFound();
                }
            }
            catch (SqliteException dbEx)
            {
                _logger.LogError($"Error in database when trying get a list of states: {dbEx.Message}. {dbEx.StackTrace}");
#if DEBUG
                throw;
#else
                return Problem("Error while accessing the database to get a list of states.");
#endif
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error when trying get a list of states: {ex.Message}. {ex.StackTrace}");
#if DEBUG
                throw;
#else
               return Problem("Error when getting a list of states.");
#endif
            }
        }
    }
}