namespace GameStore.BLL.DTO;

public class GameSupportedLanguageDto
{
    public int GameId { get; set; }
    public int SupportedLanguageId { get; set; }

    public GameDto Game { get; set; }
    public SupportedLanguageDto SupportedLanguage { get; set; }
}
