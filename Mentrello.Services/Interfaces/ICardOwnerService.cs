using Mentrello.Domain.Models;

namespace Mentrello.Services.Interfaces
{
    public interface ICardOwnerService
    {
        ICard CreateCard(ICard card, IActor actor);
        ICard DeleteCard(ICard card, IActor actor);
        ICard UpdateCard(ICard card, IActor actor);
    }
}
