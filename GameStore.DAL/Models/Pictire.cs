namespace GameStore.DAL.Models;

public class Pictire
{
    public int Id { get; set; }
    public string PictureUrl { get; set; } = null!;
    public virtual Game? Game { get; set; }
}