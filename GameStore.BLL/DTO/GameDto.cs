namespace GameStore.BLL.DTO;

public class GameDto
{
	public int Id { get; set; }
	public string Name { get; set; } = null!;
	public DateTime PublishDate { get; set; }
	public int AgeRating { get; set; }
	public decimal Price { get; set; }
	public string Description { get; set; } = null!;

	//public virtual Publisher? Publisher { get; set; }
	//public virtual SystemRequirement? SystemRequirement { get; set; }

	public IList<OperationSystemDto> OperatingSystems { get; set; }
	public IList<GameGenreDto> GameGenres { get; set; }
	public IList<PictureDto> Pictures { get; set; }
	public IList<VideoDto> Videos { get; set; }
	public IList<PromotionDto> Promotions { get; set; }
	public IList<GameSupportedLanguageDto> GameSupportedLanguages { get; set; }
	public IList<ReviewDto> Reviews { get; set; }
}
