using BrazilianFootballLeague.DataAccess.BusinessObjects;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace BrazilianFootballLeague.DataAccess.Statistics
{
    public static class TeamsStatistics
    {
        private static IQueryable<Tuple<int, int>> GetAllResults(IQueryable<Competitions_ResultTable> competitions, Expression<Func<Competitions_ResultTable, int>> property)
            => competitions.Select(x => new Tuple<int, int>(x.TeamID, property.Compile().Invoke(x)));


        public static async Task<Teams> GetStatistics(AppDbContext dbContext, Expression<Func<Competitions_ResultTable, int>> property, StatisticType statisticType, StatisticOrder statisticOrder)
        {
            var results = await GetAllResults(dbContext.Results, x => x.Won).ToListAsync();

            return await dbContext.FindAsync<Teams>(CalculateStatistic(results, statisticType, statisticOrder));
        }

        public static int CalculateStatistic(IEnumerable<Tuple<int, int>> results, StatisticType statisticType, StatisticOrder statisticOrder)
        {
            var statistics = results.GroupBy(x => new { TeamID = x.Item1 })
                .Select(x => new { x.Key.TeamID, Score = statisticType == StatisticType.Average ? x.Average(y => y.Item2) : x.Sum(y => y.Item2) });

            statistics = statisticOrder == StatisticOrder.Descending ? statistics.OrderByDescending(x => x.Score) : statistics.OrderBy(x => x.Score);

            return statistics.FirstOrDefault().TeamID;
        }

        public enum StatisticType
        {
            Sum = 0,
            Average = 1
        }

        public enum StatisticOrder
        {
            Ascending = 0,
            Descending = 1
        }
    }
}