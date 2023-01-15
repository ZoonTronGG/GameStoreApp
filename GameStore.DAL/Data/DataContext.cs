using GameStore.DAL.Models;
using System.Data.Entity;
using System.Security.Policy;

namespace GameStore.DAL.Data;

internal class DataContext : DbContext
{
    public DataContext() : base("DefaultConnection") { }

    public DbSet<Game> Games { get; set; }
    public DbSet<GameGenre> Genres { get; set; }
    public DbSet<Publisher> Publishers { get; set; }
    public DbSet<GamePictire> GamePictures { get; set; }
    public DbSet<GameVideo> GameVideos { get; set; }
    public DbSet<GameSupportedLanguege> GameLanguages { get; set; }
    public DbSet<GamePromotion> GamePromotions { get; set; }
    public DbSet<OperatingSystem> GameOperatingSystem { get; set; }
    public DbSet<Ram> Rams { get; set; }
    public DbSet<Processor> Processors { get; set; }
    public DbSet<Videocard> Videocards { get; set; }
    public DbSet<GameReview> GameReviews { get; set; }
    public DbSet<User> Users { get; set; }
}
