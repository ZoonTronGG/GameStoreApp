using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.DAL.Models
{
    public class Game
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public DateTime PublishDate { get; set; }
        public int AgeRating { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; } = null!;

        public virtual GamePublisher? Publisher { get; set; }
        public virtual GameOperationSystem? GameOperationSystem { get; set; }


        public virtual ICollection<GameGenre>? Genres { get; set; }
        public virtual ICollection<GamePictire>? Pictures { get; set; }
        public virtual ICollection<GameVideo>? Videos { get; set; }
        public virtual ICollection<GamePromotion>? Promotions { get; set; }
        public virtual ICollection<GameSupportedLanguege>? SupportedLangueges { get; set; }
        public virtual ICollection<GameReview>? Reviews { get; set; }
    }
}
