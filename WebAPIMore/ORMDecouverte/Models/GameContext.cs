using Microsoft.EntityFrameworkCore;

namespace ORMDecouverte.Models
{
    public class GameContext: DbContext
    {
        public GameContext(DbContextOptions options) : base(options)
        {
        }

        protected GameContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Wookiee> Wookies { get; set; }

    }
}
