namespace GameStore.DAL.Models;

public class Promotion
{
    public int Id { get; set; }
    public int Procent { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public virtual Game? Games { get; set; }
}