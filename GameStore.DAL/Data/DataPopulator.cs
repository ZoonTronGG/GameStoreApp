using GameStore.DAL.Models;

namespace GameStore.DAL.Data;

public class DataPopulator
{
	public void PopulateData()
	{
		using (var context = new DataContext())
		{
			var game1 = new Game
			{
				Name = "Game 1",
				Description = "Description of game 1",
				Price = 19.99m,
				PublishDate = new DateTime(2022, 1, 1),
				AgeRating = 18,
				Publisher = new Publisher { Name = "Publisher 1" },
				SystemRequirement = new SystemRequirement
				{
					Processor = new Processor { Info = "Processor info 1" },
					Ram = new Ram { Info = "Ram info 1" },
					Videocard = new Videocard { Info = "Videocard info 1" },
					FreeSpace = 100
				},
				OperationSystems = new List<OperationSystem>
				{
					new OperationSystem { Name = "Windows" }
				},
				Genres = new List<Genre>
				{
					new Genre { Name = "Action" }
				},
				Pictures = new List<Pictire>
				{
					new Pictire { PictureUrl = "https://example.com/game1.jpg" }
				},
				Videos = new List<GameVideo>
				{
					new GameVideo { VideoUrl = "https://example.com/game1.mp4" }
				},
				Promotions = new List<Promotion>
				{
					new Promotion { Procent = 20, StartDate = new DateTime(2022, 1, 1), EndDate = new DateTime(2022, 1, 31) }
				},
				SupportedLangueges = new List<SupportedLanguege>
				{
					new SupportedLanguege { Name = "English" }
				},
				Reviews = new List<Review>
				{
					new Review { Title = "Review 1", Description = "Description of review 1" }
				}
			};
			context.Games.Add(game1);

			var game2 = new Game
			{
				Name = "Game 2",
				Description = "Description of game 2",
				Price = 29.99m,
				PublishDate = new DateTime(2022, 2, 1),
				AgeRating = 16,
				Publisher = new Publisher { Name = "Publisher 2" },
				SystemRequirement = new SystemRequirement
				{
					Processor = new Processor { Info = "Processor info 2" },
					Ram = new Ram { Info = "Ram info 2" },
					Videocard = new Videocard { Info = "Videocard info 2" },
					FreeSpace = 200
				},
				OperationSystems = new List<OperationSystem>
				{
					new OperationSystem { Name = "Windows" },
					new OperationSystem { Name = "MacOS" }
				},
				Genres = new List<Genre>
				{
					new Genre { Name = "RPG" }
				},
				Pictures = new List<Pictire>
				{
					new Pictire { PictureUrl = "https://example.com/game2.jpg" }
				},
				Videos = new List<GameVideo>
				{
					new GameVideo { VideoUrl = "https://example.com/game2.mp4" }
				},
				Promotions = new List<Promotion>
				{
					new Promotion { Procent = 15, StartDate = new DateTime(2022, 2, 1), EndDate = new DateTime(2022, 2, 28) }
				},
				SupportedLangueges = new List<SupportedLanguege>
				{
					new SupportedLanguege { Name = "English" },
					new SupportedLanguege { Name = "French" }
				},
				Reviews = new List<Review>
				{
					new Review { Title = "Review 2", Description = "Description of review 2" }
				}
			};
			context.Games.Add(game2);

			context.SaveChanges();
		}
	}
}
