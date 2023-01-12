namespace GameStore.DAL.Models
{
    public class GameVideo
    {
        public int Id { get; set; }
        public string VideoUrl { get; set; } = null!;
        public int GameId { get; set; }
    }
}