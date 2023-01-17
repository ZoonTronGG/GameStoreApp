using GameStore.BLL.DTO;

namespace GameStore.BLL.Models;

public class GenreDto
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;

    public List<int> GamesId { get; set; }
}
