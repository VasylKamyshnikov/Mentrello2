using Mentrello.Domain.Models;
using System.Collections.Generic;

namespace Mentrello.Domain.Repositories
{
    public interface ICardRepository<KeyType>
    {
        IOutput<Card<KeyType>> CreateNewCard();
        IOutput<IEnumerable<Card<KeyType>>> GetAllCards();
        IOutput<Card<KeyType>> GetCardById(KeyType id);
        IOutput<int> UpdateCardById(KeyType id);
        IOutput<int> DeleteCardById(KeyType id);
    }
}
