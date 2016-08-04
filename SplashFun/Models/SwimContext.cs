using System.Data.Entity;

namespace SplashFun.Models
{
    public class SwimContext : DbContext
    {
        public SwimContext()
            : base("SplashFunConnection")
        {

        }

        public DbSet<Swimmer> Swimmers { get; set; }
        public DbSet<TimeRecord> TimeRecords { get; set; }

        public DbSet<Distance> Distances { get; set; }

        public DbSet<Stroke> Strokes { get; set; }

        public DbSet<Team> Teams { get; set; }

    }
}