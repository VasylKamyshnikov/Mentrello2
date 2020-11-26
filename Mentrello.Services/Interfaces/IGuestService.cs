using System;
using System.Collections.Generic;
using Mentrello.Domain.Models;

namespace Mentrello.Services.Interfaces
{
    public interface IGuestService
    {
        IEnumerable<IBoard> ReadAllBoards();
        IEnumerable<ICard> ReadAllCards();
        IBoard ReadBoard(Guid boardId, IActor actor);
        ICard ReadCard(Guid cardId, IActor actor);
    }
}
