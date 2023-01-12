namespace GameStore.DAL.Models
{
    public class GamePictire
    {
        public int Id { get; set; }
        public string PictureUrl { get; set; } = null!;
        public int GameId { get; set; }
    }
}