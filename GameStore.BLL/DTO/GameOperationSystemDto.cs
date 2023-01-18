namespace GameStore.BLL.DTO;

public class GameOperationSystemDto
{
    public int GameId { get; set; }
    public int OperationSystemId { get; set; }

    public GameDto Game { get; set; }
    public OperationSystemDto OperationSystem { get; set; }
}
