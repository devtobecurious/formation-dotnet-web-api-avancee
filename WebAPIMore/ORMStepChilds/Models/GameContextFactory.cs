using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace ORMDecouverte.Models
{
    public class GameContextFactory : IDesignTimeDbContextFactory<GameContext>
    {
        public GameContextFactory()
        {
            
        }

        public GameContext CreateDbContext(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                                .AddJsonFile("appsettings.json")
                                .Build();

            var optionBuilder = new DbContextOptionsBuilder<GameContext>();
            var connectionString = configuration.GetConnectionString("Game.Database");

            optionBuilder.UseMySQL(connectionString!, options =>
            {
            });

            return new GameContext(optionBuilder.Options);
        }
    }
}
