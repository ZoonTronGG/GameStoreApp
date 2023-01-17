using GameStore.BLL.Models;

namespace GameStore.BLL.DTO;

public class GameDto
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public DateTime PublishDate { get; set; }
    public int AgeRating { get; set; }
    public decimal Price { get; set; }
    public string Description { get; set; } = null!;

    //public virtual Publisher? Publisher { get; set; }
    //public virtual SystemRequirement? SystemRequirement { get; set; }

    //public virtual ICollection<OperationSystem>? OperationSystems { get; set; }
    public List<GenreDto> Genres { get; set; }
    //public virtual ICollection<Picture>? Pictures { get; set; }
    //public virtual ICollection<GameVideo>? Videos { get; set; }
    //public virtual ICollection<Promotion>? Promotions { get; set; }
    //public virtual ICollection<SupportedLanguege>? SupportedLangueges { get; set; }
    //public virtual ICollection<Review>? Reviews { get; set; }
}
