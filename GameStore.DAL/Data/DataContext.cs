using GameStore.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Protocols;
using System.Configuration;

namespace GameStore.DAL.Data;

public class DataContext : DbContext
{
    public DbSet<Game> Games { get; set; } = null!;
    public DbSet<Genre> Genres { get; set; } = null!;
    public DbSet<Publisher> Publishers { get; set; } = null!;
    public DbSet<Pictire> Pictures { get; set; } = null!;
    public DbSet<GameVideo> Videos { get; set; } = null!;
    public DbSet<SupportedLanguege> Languages { get; set; } = null!;
    public DbSet<Promotion> Promotions { get; set; } = null!;
    public DbSet<GameStore.DAL.Models.OperationSystem> OperatingSystems { get; set; } = null!;

    public DbSet<Ram> Rams { get; set; } = null!;
    public DbSet<Processor> Processors { get; set; } = null!;
    public DbSet<Videocard> Videocards { get; set; } = null!;
    public DbSet<SystemRequirement> SystemRequirements { get; set; } = null!;
    public DbSet<Review> Reviews { get; set; } = null!;
    public DbSet<User> Users { get; set; } = null!;

    public DataContext()
    {
        Database.EnsureCreated();
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=(LocalDb)\\MSSQLLocalDB;Database=GameShop;Trusted_Connection=True;");
    }
}
