namespace GameStore.BLL.DTO;

public class PictureDto
{
    public int Id { get; set; }
    public string PictureUrl { get; set; } = null!;
    public virtual GameDto? Game { get; set; }
}
