namespace GameStore.DAL.Models
{
    public class GameSystemRequirement
    {
        public int Id { get; set; }
        public int FreeSpace { get; set; }
        public int ProcessorId { get; set; }
        public int RamId { get; set; }
        public int VideocardId { get; set; }
        public int GameId { get; set; }
    }
}