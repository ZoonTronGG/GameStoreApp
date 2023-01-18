namespace GameStore.BLL.DTO;

public class SupportedLanguageDto
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public IList<GameSupportedLanguageDto> GameSupportedLanguages { get; set; }
}
