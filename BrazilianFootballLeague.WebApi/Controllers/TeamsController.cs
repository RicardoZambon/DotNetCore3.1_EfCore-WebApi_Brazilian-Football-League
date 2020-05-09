using BrazilianFootballLeague.DataAccess;
using BrazilianFootballLeague.DataAccess.BusinessObjects;
using BrazilianFootballLeague.DataAccess.Statistics;
using BrazilianFootballLeague.WebApi.Enums;
using BrazilianFootballLeague.WebApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.Data.Sqlite;
using Microsoft.Extensions.Logging;
using System;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BrazilianFootballLeague.WebApi.Controllers
{
    [ApiController, Route("~/api/{controller}")]
    public class TeamsController : ControllerBase
    {
        private readonly AppDbContext _ctx;
        private readonly ILogger<TeamsController> _logger;

        public TeamsController(AppDbContext ctx, ILogger<TeamsController> logger)
        {
            _ctx = ctx;
            _logger = logger;
        }


        [HttpGet]
        public async Task<IActionResult> Index()
        {
            try
            {
                var teams = await _ctx.GetRanked(_ctx.Teams);
                if (teams.Count() > 0)
                {
                    var teamsModel = teams.Select((team, index) => new TeamsModel(team, index + 1));

                    _logger.Log(LogLevel.Information, "Successfully returned the list of teams.");
                    return Ok(teamsModel);
                }
                else
                {
                    _logger.Log(LogLevel.Warning, "Searched for all teams, but none found.");
                    return NotFound();
                }
            }
            catch (SqliteException dbEx)
            {
                _logger.LogError($"Error in database when trying get a list of teams: {dbEx.Message}. {dbEx.StackTrace}");
#if DEBUG
                throw;
#else
                return Problem("Error while accessing the database to get a list of teams.");
#endif
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error when trying get a list of teams: {ex.Message}. {ex.StackTrace}");
#if DEBUG
                throw;
#else
               return Problem("Error when getting a list of teams.");
#endif
            }
        }

        [HttpGet, Route("{action}/{statisticsType:int}")]
        public async Task<IActionResult> Statistics(StatisticsType statisticsType)
        {
            try
            {
                Teams team;

                switch (statisticsType)
                {
                    case StatisticsType.MaxGoalsFor:
                        team = await TeamsStatistics.GetStatistics(_ctx, x => x.GoalsFor, TeamsStatistics.StatisticGrouping.Teams, TeamsStatistics.StatisticType.Average, TeamsStatistics.StatisticOrder.Descending);
                        break;
                    case StatisticsType.MinGoalsAgainst:
                        team = await TeamsStatistics.GetStatistics(_ctx, x => x.GoalsAgainst, TeamsStatistics.StatisticGrouping.Teams, TeamsStatistics.StatisticType.Average, TeamsStatistics.StatisticOrder.Ascending);
                        break;
                    case StatisticsType.MaxWon:
                        team = await TeamsStatistics.GetStatistics(_ctx, x => x.Won, TeamsStatistics.StatisticGrouping.Teams, TeamsStatistics.StatisticType.Sum, TeamsStatistics.StatisticOrder.Descending);
                        break;
                    case StatisticsType.MinWon:
                        team = await TeamsStatistics.GetStatistics(_ctx, x => x.Won, TeamsStatistics.StatisticGrouping.Teams, TeamsStatistics.StatisticType.Sum, TeamsStatistics.StatisticOrder.Ascending);
                        break;
                    case StatisticsType.BestAvaregeWons:
                        team = await TeamsStatistics.GetStatistics(_ctx, x => x.Won, TeamsStatistics.StatisticGrouping.TeamsAndSeasons, TeamsStatistics.StatisticType.Average, TeamsStatistics.StatisticOrder.Descending);
                        break;
                    case StatisticsType.WorseAvaregeWons:
                        team = await TeamsStatistics.GetStatistics(_ctx, x => x.Won, TeamsStatistics.StatisticGrouping.TeamsAndSeasons, TeamsStatistics.StatisticType.Average, TeamsStatistics.StatisticOrder.Ascending);
                        break;
                    default:
                        return NotFound();
                }

                _logger.Log(LogLevel.Information, $"Successfully returned the statistic {statisticsType}.");
                return Ok(team.Name);
            }
            catch (SqliteException dbEx)
            {
                _logger.LogError($"Error in database when trying get the statistic {statisticsType}: {dbEx.Message}. {dbEx.StackTrace}");
#if DEBUG
                throw;
#else
                return Problem($"Error in database when trying get the statistic {statisticsType}.");
#endif
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error when trying get the statistic {statisticsType}: {ex.Message}. {ex.StackTrace}");
#if DEBUG
                throw;
#else
               return Problem($"Error in database when trying get the statistic {statisticsType}.");
#endif
            }
        }
    }
}