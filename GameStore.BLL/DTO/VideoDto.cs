namespace GameStore.BLL.DTO;

public class VideoDto
{
    public int Id { get; set; }
    public string PictureUrl { get; set; } = null!;
    public virtual GameDto? Game { get; set; }
}
