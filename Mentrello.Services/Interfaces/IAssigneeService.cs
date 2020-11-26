using Mentrello.Domain.Models;

namespace Mentrello.Services.Interfaces
{
    public interface IAssigneeService : IGuestService
    {
        ICard AssignCardTo(ICard card, IActor actor);
        ICard AddCommentToCard(ICard card, IActor actor);
        ICard ChangeCardStatus(ICard card, IActor actor);
    }
}
