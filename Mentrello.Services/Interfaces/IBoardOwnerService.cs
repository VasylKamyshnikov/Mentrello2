using Mentrello.Domain.Models;

namespace Mentrello.Services.Interfaces
{
    public interface IBoardOwnerService
    {
        IBoard CreateBoard(IBoard board);
        IBoard DeleteBoard(IBoard board);
        IBoard UpdateBoard(IBoard board);
    }
}
