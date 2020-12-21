using System.Collections.Generic;
using System.Linq;
using Mentrello.Data.Entities;

namespace Mentrello.Data
{
    public static class DbInitializer
    {
        public static void Initialize(MentrelloContext context)
        {
            context.Database.EnsureCreated();

            if (context.Boards.Any())
                return;
            var boards = new List<Board>
            {
                new Board { Name = "First Board", Description = "First Board Description" },
                new Board { Name = "Second Board", Description = "Second Board Description" },
                new Board { Name = "Third Board", Description = "Third Board Description" }
            };
            context.Boards.AddRange(boards);
            context.SaveChanges();

            var cards = new List<Card>
            {
                new Card { Name = "First Card", Description = "First Card Description" },
                new Card { Name = "Second Card", Description = "Second Card Description" },
                new Card { Name = "Third Card", Description = "Third Card Description" }
            };
            context.Cards.AddRange(cards);
            context.SaveChanges();
        }
    }
}
