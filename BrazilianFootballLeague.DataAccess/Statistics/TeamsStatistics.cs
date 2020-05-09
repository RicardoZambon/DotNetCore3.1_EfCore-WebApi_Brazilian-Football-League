using BrazilianFootballLeague.DataAccess.BusinessObjects;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace BrazilianFootballLeague.DataAccess.Statistics
{
    public static class TeamsStatistics
    {
        private static IQueryable<Tuple<int, int, int>> GetAllResults(IQueryable<Competitions_ResultTable> competitions, Expression<Func<Competitions_ResultTable, int>> property)
            => competitions.Select(x => new Tuple<int, int, int>(x.TeamID, x.SeasonID, property.Compile().Invoke(x)));


        public static async Task<Teams> GetStatistics(AppDbContext dbContext, Expression<Func<Competitions_ResultTable, int>> property, StatisticGrouping statisticGrouping, StatisticType statisticType, StatisticOrder statisticOrder)
        {
            var results = await GetAllResults(dbContext.Results, x => x.Won).ToListAsync();

            var statistics = (statisticGrouping == StatisticGrouping.Teams
                    ? results.GroupBy(x => new int[] { x.Item1 })
                    : results.GroupBy(x => new int[] { x.Item1, x.Item2 }))
                
                .Select(x => new Tuple<int[], double>(x.Key, (statisticType == StatisticType.Average ? x.Average(y => y.Item3) : x.Sum(y => y.Item3))));

            statistics = statisticOrder == StatisticOrder.Descending ? statistics.OrderByDescending(x => x.Item2) : statistics.OrderBy(x => x.Item2);

            return await dbContext.Teams.FindAsync(statistics.FirstOrDefault().Item1[0]);
        }


        public enum StatisticGrouping
        {
            Teams = 0,
            TeamsAndSeasons = 1
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