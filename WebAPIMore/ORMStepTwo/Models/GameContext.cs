using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

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

            var converter = new ValueConverter<WeaponLevel, string>(x => x.ToString(),
                                       x => (WeaponLevel)Enum.Parse<WeaponLevel>(x));

            modelBuilder.Entity<Weapon>()
                        .Property(item => item.Level)
                        .HasConversion(converter);
                        //.HasConversion(x => x.ToString(),
                        //               x => (WeaponLevel)Enum.Parse<WeaponLevel>(x));
        }

        public DbSet<Wookiee> Wookies { get; set; }

    }
}
