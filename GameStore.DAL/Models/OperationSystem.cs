namespace GameStore.DAL.Models;

public class OperationSystem
{
    public int Id { get; set; }
    public int FreeSpace { get; set; }
    public virtual Processor? Processor { get; set; }
    public virtual Ram? Ram { get; set; }
    public virtual Videocard? Videocard { get; set; }
    public virtual ICollection<Game>? Games { get; set; }
}
