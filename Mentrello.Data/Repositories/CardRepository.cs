using System;
using System.Collections.Generic;
using Mentrello.Domain.Models;
using Mentrello.Domain.Repositories;

namespace Mentrello.Data.Repositories
{
    public class CardRepository : ICardRepository
    {
        public IOutput<Card> Create(Card model)
        {
            var card = new Card
            {
                Name = "First Card",
                Description = "First Created Card",
                Owner = new Actor { FullName = "First Last" }
            };

            return new Output<Card> { IsSuccessful = true, Result = card };
        }

        public IOutput<Card> DeleteById(Guid id)
        {
            var card = new Card
            {
                Name = "First Card",
                Description = "First Deleted Card",
                Owner = new Actor { FullName = "First Last" }
            };

            return new Output<Card> { IsSuccessful = true, Result = card };
        }

        public IOutput<IEnumerable<Card>> GetAll()
        {
            var card1 = new Card
            {
                Name = "First Card",
                Description = "First Created Card",
                Owner = new Actor { FullName = "First Last" }
            };
            var card2 = new Card
            {
                Name = "Second Card",
                Description = "Second Created Card",
                Owner = new Actor { FullName = "First Last" }
            };
            var cards = new List<Card> { card1, card2};

            return new Output<IEnumerable<Card>> { IsSuccessful = true, Result = cards };
        }

        public IOutput<Card> GetById(Guid id)
        {
            var card = new Card
            {
                Name = "First Card",
                Description = "First Created Card",
                Owner = new Actor { FullName = "First Last" }
            };

            return new Output<Card> { IsSuccessful = true, Result = card };
        }

        public IOutput<Card> UpdateById(Guid id)
        {
            var card = new Card
            {
                Name = "Updated Card",
                Description = "First Updated Card",
                Owner = new Actor { FullName = "First Last" }
            };

            return new Output<Card> { IsSuccessful = true, Result = card };
        }
    }
}
