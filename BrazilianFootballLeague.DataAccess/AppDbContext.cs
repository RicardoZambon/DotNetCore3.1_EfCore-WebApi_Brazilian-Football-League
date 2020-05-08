using BrazilianFootballLeague.DataAccess.BusinessObjects;
using BrazilianFootballLeague.DataAccess.Initializers;
using Microsoft.EntityFrameworkCore;

namespace BrazilianFootballLeague.DataAccess
{
    public class AppDbContext : DbContext
    {
        public DbSet<Competitions> Competitions { get; set; }

        public DbSet<Competitions_ResultTable> Results { get; set; }

        public DbSet<Competitions_Seasons> Seasons { get; set; }

        public DbSet<States> States { get; set; }

        public DbSet<Teams> Teams { get; set; }


        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

#if DEBUG
            DataInitializer.Seed(modelBuilder);
#endif
        }
    }
}