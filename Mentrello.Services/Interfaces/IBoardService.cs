using Mentrello.Services.Models;
using System;
using System.Collections.Generic;

namespace Mentrello.Services.Interfaces
{
    public interface IBoardService
    {
        Board CreateBoard();
        IEnumerable<Board> GetAllBoards();
        Board GetBoardById(Guid id);
        bool UpdateExistingBoard(Guid id);
        bool DeleteBoardById(Guid id);
    }
}
