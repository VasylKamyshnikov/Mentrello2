using System;
using System.Collections.Generic;
using Mentrello.Domain.Models;
using Mentrello.Domain.Repositories;

namespace Mentrello.Data.Repositories
{
    public class CardRepository : ICardRepository
    {
        public IOutput<CardModel> Create(CardModel model)
        {
            var card = new CardModel
            {
                Name = "First Card",
                Description = "First Created Card",
                Owner = new UserModel { FullName = "First Last" }
            };

            return new Output<CardModel> { Succeeded = true, Result = card };
        }

        public IOutput<CardModel> DeleteById(Guid id)
        {
            var card = new CardModel
            {
                Name = "First Card",
                Description = "First Deleted Card",
                Owner = new UserModel { FullName = "First Last" }
            };

            return new Output<CardModel> { Succeeded = true, Result = card };
        }

        public IOutput<IEnumerable<CardModel>> GetAll()
        {
            var card1 = new CardModel
            {
                Name = "First Card",
                Description = "First Created Card",
                Owner = new UserModel { FullName = "First Last" }
            };
            var card2 = new CardModel
            {
                Name = "Second Card",
                Description = "Second Created Card",
                Owner = new UserModel { FullName = "First Last" }
            };
            var cards = new List<CardModel> { card1, card2};

            return new Output<IEnumerable<CardModel>> { Succeeded = true, Result = cards };
        }

        public IOutput<CardModel> GetById(Guid id)
        {
            var card = new CardModel
            {
                Name = "First Card",
                Description = "First Created Card",
                Owner = new UserModel { FullName = "First Last" }
            };

            return new Output<CardModel> { Succeeded = true, Result = card };
        }

        public IOutput<CardModel> UpdateById(Guid id)
        {
            var card = new CardModel
            {
                Name = "Updated Card",
                Description = "First Updated Card",
                Owner = new UserModel { FullName = "First Last" }
            };

            return new Output<CardModel> { Succeeded = true, Result = card };
        }
    }
}
