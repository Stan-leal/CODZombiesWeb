
using Microsoft.EntityFrameworkCore;
namespace CODZombiesWeb.Models;

    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
                : base(options)
                {
                }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MapGame>().HasKey(s => new {s.GameID, s.MapID});
        }
    
    public DbSet<Map> Maps {get; set;}
    public DbSet<Game> Games {get; set;}
    public DbSet<MapGame> MapGames {get; set;}
}
