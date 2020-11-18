using System;
using System.Collections.Generic;
using Mentrello.Domain.Models;

namespace Mentrello.Domain.Repositories
{
    public interface ICardRepository
    {
        Card CreateNewCard(Card card);
        IEnumerable<Card> GetAllCards();
        Card GetCardById(Guid id);
        int UpdateCardById(Guid id);
        int DeleteCardById(Guid id);
    }
}
