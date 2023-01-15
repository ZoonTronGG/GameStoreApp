namespace GameStore.DAL.Models;

public class Game
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public DateTime PublishDate { get; set; }
    public int AgeRating { get; set; }
    public decimal Price { get; set; }
    public string Description { get; set; } = null!;

    public virtual Publisher? Publisher { get; set; }
    public virtual OperationSystem? GameOperationSystem { get; set; }


    public virtual ICollection<Genre>? Genres { get; set; }
    public virtual ICollection<Pictire>? Pictures { get; set; }
    public virtual ICollection<GameVideo>? Videos { get; set; }
    public virtual ICollection<Promotion>? Promotions { get; set; }
    public virtual ICollection<SupportedLanguege>? SupportedLangueges { get; set; }
    public virtual ICollection<Review>? Reviews { get; set; }
}
