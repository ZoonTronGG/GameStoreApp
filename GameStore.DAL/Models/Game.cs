using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.DAL.Models
{
    internal class Game
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public DateTime PublishDate { get; set; }
        public int AgeRating { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; } = null!;

        public int PublisherId { get; set; }
        public List<int> GenreId { get; set; }
        public int SystemRequirementId { get; set; }
        public List<int> PictureId { get; set; }
        public List<int> VideoId { get; set; }
        public List<int> PromotionId { get; set; }
        public List<int> SupportedLanguegeId { get; set; }
        public List<int> GameOperationSystemId { get; set; }
        public List<int> ReviewId { get; set; }
    }
}
