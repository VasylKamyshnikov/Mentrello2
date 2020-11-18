using System;
using System.Collections.Generic;
using Mentrello.Domain.Models;

namespace Mentrello.Domain.Repositories
{
    public interface IBoardRepository
    {
        Board CreateNewBoard(Board board);
        IEnumerable<Board> GetAllBoards();
        Board GetBoardById(Guid id);
        //return Board
        bool UpdateBoardById(Guid id);
        //return Board
        bool DeleteBoardById(Guid id);
    }
}
