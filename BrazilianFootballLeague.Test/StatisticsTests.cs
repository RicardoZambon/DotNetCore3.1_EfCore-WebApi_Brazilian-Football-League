using BrazilianFootballLeague.DataAccess.Statistics;
using BrazilianFootballLeague.Test.Parameters;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace BrazilianFootballLeague.Test
{
    public class StatisticsTests
    {
        const int EXPECTED_TEAMS_AVERAGE_ASCENDING = 3;
        const int EXPECTED_TEAMS_AVERAGE_DESCENDING = 2;
        const int EXPECTED_TEAMS_SUM_ASCENDING = 3;
        const int EXPECTED_TEAMS_SUM_DESCENDING = 1;

        public static IEnumerable<object[]> StatisticsParameters()
        {
            yield return new object[]
            {
                new StatisticsModel[]
                {
                    new StatisticsModel(1, 20),
                    new StatisticsModel(1, 40),
                    new StatisticsModel(1, 60),
                    new StatisticsModel(1, 80),

                    new StatisticsModel(2, 190),
                    new StatisticsModel(2, 1),
                    new StatisticsModel(2, 0),

                    new StatisticsModel(3, 1),
                    new StatisticsModel(3, 13),
                    new StatisticsModel(3, 6),
                    new StatisticsModel(3, 9),
                }
            };
        }


        [Theory]
        [MemberData(nameof(StatisticsParameters))]
        public void TestTeamsAverageAscending(StatisticsModel[] model)
        {
            var actualResult = TeamsStatistics.CalculateStatistic(
                model.Select(x => new Tuple<int, int>(x.TeamID, x.Score)),
                TeamsStatistics.StatisticType.Average,
                TeamsStatistics.StatisticOrder.Ascending);

            Assert.Equal(EXPECTED_TEAMS_AVERAGE_ASCENDING, actualResult);
        }

        [Theory]
        [MemberData(nameof(StatisticsParameters))]
        public void TestTeamsAverageDescending(StatisticsModel[] model)
        {
            var actualResult = TeamsStatistics.CalculateStatistic(
                model.Select(x => new Tuple<int, int>(x.TeamID, x.Score)),
                TeamsStatistics.StatisticType.Average,
                TeamsStatistics.StatisticOrder.Descending);

            Assert.Equal(EXPECTED_TEAMS_AVERAGE_DESCENDING, actualResult);
        }

        [Theory]
        [MemberData(nameof(StatisticsParameters))]
        public void TestTeamsSumAscending(StatisticsModel[] model)
        {
            var actualResult = TeamsStatistics.CalculateStatistic(
                model.Select(x => new Tuple<int, int>(x.TeamID, x.Score)),
                TeamsStatistics.StatisticType.Sum,
                TeamsStatistics.StatisticOrder.Ascending);

            Assert.Equal(EXPECTED_TEAMS_SUM_ASCENDING, actualResult);
        }

        [Theory]
        [MemberData(nameof(StatisticsParameters))]
        public void TestTeamsSumDescending(StatisticsModel[] model)
        {
            var actualResult = TeamsStatistics.CalculateStatistic(
                model.Select(x => new Tuple<int, int>(x.TeamID, x.Score)),
                TeamsStatistics.StatisticType.Sum,
                TeamsStatistics.StatisticOrder.Descending);

            Assert.Equal(EXPECTED_TEAMS_SUM_DESCENDING, actualResult);
        }
    }
}