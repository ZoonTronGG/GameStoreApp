namespace GameStore.BLL.DTO;

public class GenreDto
{
	public int Id { get; set; }
	public string Name { get; set; } = null!;

	public IList<GameGenreDto> GameGenres { get; set; }
}