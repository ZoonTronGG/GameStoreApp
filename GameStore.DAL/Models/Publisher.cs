namespace GameStore.DAL.Models;

public class Publisher
{
    public int Id { get; set; }
    public virtual string Name { get; set; } = null!;
    public virtual ICollection<Game>? Games { get; set; }
}