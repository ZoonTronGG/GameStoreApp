namespace GameStore.DAL.Models;

public class GamePictire
{
    public int Id { get; set; }
    public string PictureUrl { get; set; } = null!;
    public virtual Game? Game { get; set; }
}