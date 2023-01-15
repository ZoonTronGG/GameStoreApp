namespace GameStore.DAL.Models
{
    public class GameReview
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public virtual Game? Game { get; set; }
        public virtual User? User { get; set; }
    }
}