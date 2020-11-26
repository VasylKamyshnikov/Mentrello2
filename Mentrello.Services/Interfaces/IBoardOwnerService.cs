using Mentrello.Domain.Models;

namespace Mentrello.Services.Interfaces
{
    public interface IBoardOwnerService
    {
        IBoard CreateBoard(IBoard board, IActor actor);
        IBoard DeleteBoard(IBoard board, IActor actor);
        IBoard UpdateBoard(IBoard board, IActor actor);
    }
}
