using Mentrello.Domain.Models;
using Mentrello.Domain.Repositories;
using System;
using System.Collections.Generic;

namespace Mentrello.Data.Repositories
{
    public class CardRepository : ICardRepository<Guid>
    {
        public IOutput<Card<Guid>> CreateNewCard()
        {
            throw new NotImplementedException();
        }

        public IOutput<int> DeleteCardById(Guid id)
        {
            throw new NotImplementedException();
        }

        public IOutput<IEnumerable<Card<Guid>>> GetAllCards()
        {
            throw new NotImplementedException();
        }

        public IOutput<Card<Guid>> GetCardById(Guid id)
        {
            throw new NotImplementedException();
        }

        public IOutput<int> UpdateCardById(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
