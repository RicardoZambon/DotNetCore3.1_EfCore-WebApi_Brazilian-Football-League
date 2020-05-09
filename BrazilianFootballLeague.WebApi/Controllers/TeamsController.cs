using BrazilianFootballLeague.DataAccess;
using BrazilianFootballLeague.DataAccess.BusinessObjects;
using BrazilianFootballLeague.DataAccess.Statistics;
using BrazilianFootballLeague.WebApi.Enums;
using BrazilianFootballLeague.WebApi.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BrazilianFootballLeague.WebApi.Controllers
{
    [ApiController, Route("~/api/{controller}")]
    public class TeamsController : ControllerBase
    {
        private readonly AppDbContext _ctx;

        public TeamsController(AppDbContext ctx)
        {
            _ctx = ctx;
        }


        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var teams = await _ctx.GetRanked(_ctx.Teams);
            if (teams.Count() > 0)
            {
                return Ok(teams.Select((team, index) => new TeamsModel(team, index + 1)));
            }
            else
            {
                return NotFound();
            }
        }

        [HttpGet, Route("{action}/{statisticsType:int}")]
        public async Task<IActionResult> Statistics(StatisticsType statisticsType)
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

            return Ok(team.Name);
        }
    }
}