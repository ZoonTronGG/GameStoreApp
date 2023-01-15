using GameStore.DAL.Models;
using System.Data.Entity;
using System.Security.Policy;

namespace GameStore.DAL.Data;

internal class DataContext : DbContext
{
    public DataContext() : base("DefaultConnection") { }

    public DbSet<Game> Games { get; set; }
    public DbSet<Genre> Genres { get; set; }
    public DbSet<Models.Publisher> Publishers { get; set; }
    public DbSet<Pictire> GamePictures { get; set; }
    public DbSet<GameVideo> GameVideos { get; set; }
    public DbSet<SupportedLanguege> GameLanguages { get; set; }
    public DbSet<Promotion> GamePromotions { get; set; }
    public DbSet<OperatingSystem> GameOperatingSystem { get; set; }
    public DbSet<Ram> Rams { get; set; }
    public DbSet<Processor> Processors { get; set; }
    public DbSet<Videocard> Videocards { get; set; }
    public DbSet<Review> GameReviews { get; set; }
    public DbSet<User> Users { get; set; }
}
