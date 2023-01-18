namespace GameStore.BLL.DTO;

public class ReviewDto
{
    public int Id { get; set; }
    public string Title { get; set; } = null!;
    public string Description { get; set; } = null!;
    public GameDto? Game { get; set; }
    public UserDto? User { get; set; }
}
