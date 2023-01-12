namespace GameStore.DAL.Models
{
    public class GameReview
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public int GameId { get; set; }
        public int UserId { get; set; }
    }
}