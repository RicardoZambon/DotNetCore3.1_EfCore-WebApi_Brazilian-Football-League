using BrazilianFootballLeague.DataAccess;
using BrazilianFootballLeague.WebApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace BrazilianFootballLeague.WebApi.Controllers
{
    [ApiController, Route("~/api/{controller}")]
    public class CompetitionsController : ControllerBase
    {
        private readonly AppDbContext _ctx;
        private readonly ILogger<TeamsController> _logger;

        public CompetitionsController(AppDbContext ctx, ILogger<TeamsController> logger)
        {
            _ctx = ctx;
            _logger = logger;
        }


        [HttpGet]
        public async Task<IActionResult> Index()
        {
            try
            {
                var competitions = await _ctx.Competitions.ToListAsync();
                if (competitions.Count() > 0)
                {
                    var competitionsModel = competitions.Select(x => new CompetitionsModel(x, 5));

                    _logger.Log(LogLevel.Information, "Successfully returned the list of competitions.");
                    return Ok(competitionsModel);
                }
                else
                {
                    _logger.Log(LogLevel.Warning, "Searched for all competitions, but none found.");
                    return NotFound();
                }
            }
            catch (SqliteException dbEx)
            {
                _logger.LogError($"Error in database when trying get a list of competitions: {dbEx.Message}. {dbEx.StackTrace}");
#if DEBUG
                throw;
#else
                return Problem("Error while accessing the database to get a list of competitions.");
#endif
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error when trying get a list of competitions: {ex.Message}. {ex.StackTrace}");
#if DEBUG
                throw;
#else
               return Problem("Error when getting a list of competitions.");
#endif
            }
        }
    }
}