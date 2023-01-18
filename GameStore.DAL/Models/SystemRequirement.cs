namespace GameStore.DAL.Models;

public class SystemRequirement
{
    public int Id { get; set; }
    public virtual ProcessorDto? Processor { get; set; }
    public virtual Ram? Ram { get; set; }
    public virtual Videocard? Videocard { get; set; }
    public int FreeSpace { get; set; }
    public virtual ICollection<Game>? Games { get; set; }
}
