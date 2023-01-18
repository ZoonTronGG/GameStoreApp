namespace GameStore.BLL.DTO;

public class PublisherDto
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public IList<GameDto>? Games { get; set; }
}
