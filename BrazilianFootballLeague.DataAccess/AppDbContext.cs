using BrazilianFootballLeague.DataAccess.BusinessObjects;
using BrazilianFootballLeague.DataAccess.Initializers;
using BrazilianFootballLeague.DataAccess.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace BrazilianFootballLeague.DataAccess
{
    public class AppDbContext : DbContext
    {
        public DbSet<Competitions> Competitions { get; set; }

        public DbSet<CompetitionsResultTable> Results { get; set; }

        public DbSet<CompetitionsSeasons> Seasons { get; set; }

        public DbSet<States> States { get; set; }

        public DbSet<Teams> Teams { get; set; }


        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

#if DEBUG
            DataInitializer.Seed(modelBuilder);
#endif
        }


        public async Task<IOrderedEnumerable<T>> GetRanked<T>(DbSet<T> dbSet) where T : class, IResultTotal
            => (await dbSet.ToListAsync())
                .OrderByDescending(x => x.GetTotalPoints())
                .ThenByDescending(x => x.GetTotalWon())
                .ThenByDescending(x => x.GetTotalGoalsFor() - x.GetTotalGoalsAgainst())
                .ThenByDescending(x => x.GetTotalGoalsFor());
    }
}