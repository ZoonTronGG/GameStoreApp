namespace GameStore.BLL.DTO;

public class SystemRequirementDto
{
    public int Id { get; set; }
    public ProcessorDto? Processor { get; set; }
    public RamDto? Ram { get; set; }
    public VideocardDto? Videocard { get; set; }
    public int FreeSpace { get; set; }
    public IList<GameDto>? Games { get; set; }
}