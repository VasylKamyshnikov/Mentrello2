using System;
using System.Collections.Generic;
using Mentrello.Domain.Models;
using Mentrello.Domain.Repositories;

namespace Mentrello.Data.Repositories
{
    public class CardRepository : ICardRepository
    {
        public Card CreateNewCard(Card card)
        {
            throw new NotImplementedException();
        }

        public int DeleteCardById(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Card> GetAllCards()
        {
            throw new NotImplementedException();
        }

        public Card GetCardById(Guid id)
        {
            throw new NotImplementedException();
        }

        public int UpdateCardById(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
