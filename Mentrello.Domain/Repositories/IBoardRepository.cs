using Mentrello.Domain.Models;
using System.Collections.Generic;

namespace Mentrello.Domain.Repositories
{
    public interface IBoardRepository<KeyType>
    {
        IOutput<Board<KeyType>> CreateNewBoard();
        IOutput<IEnumerable<Board<KeyType>>> GetAllBoards();
        IOutput<Board<KeyType>> GetBoardById(KeyType id);
        IOutput<bool> UpdateBoardById(KeyType id);
        IOutput<bool> DeleteBoardById(KeyType id);
    }
}
