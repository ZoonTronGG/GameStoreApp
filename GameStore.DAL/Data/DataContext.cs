using GameStore.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace GameStore.DAL.Data;

public class DataContext : DbContext
{
    public DbSet<Game> Games { get; set; }
    public DbSet<Genre> Genres { get; set; }
    public DbSet<Publisher> Publishers { get; set; }
    public DbSet<Picture> Pictures { get; set; }
    public DbSet<GameVideo> Videos { get; set; }
    public DbSet<SupportedLanguege> Languages { get; set; }
    public DbSet<Promotion> Promotions { get; set; }
    public DbSet<GameStore.DAL.Models.OperationSystem> OperatingSystems { get; set; }

    public DbSet<Ram> Rams { get; set; }
    public DbSet<Processor> Processors { get; set; }
    public DbSet<Videocard> Videocards { get; set; }
    public DbSet<SystemRequirement> SystemRequirements { get; set; }
    public DbSet<Review> Reviews { get; set; }
    public DbSet<User> Users { get; set; }

    public DataContext()
    {
        Database.EnsureCreated();
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
		string appsettingsPath = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\..\\..\\GameStore.DAL\\appsettings.json"));
		var builder = new ConfigurationBuilder().AddJsonFile(appsettingsPath, optional: true, reloadOnChange: true);

		IConfiguration configuration = builder.Build();
		optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
    }
}