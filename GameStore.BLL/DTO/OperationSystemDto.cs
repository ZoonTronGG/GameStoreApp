namespace GameStore.BLL.DTO;

public class OperationSystemDto
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;

    public IList<GameGenreDto> GameGenres { get; set; }
}

