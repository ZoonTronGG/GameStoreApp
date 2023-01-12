namespace GameStore.DAL.Models
{
    public class GamePromotion
    {
        public int Id { get; set; }
        public int Procent { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int GameId { get; set; }
    }
}