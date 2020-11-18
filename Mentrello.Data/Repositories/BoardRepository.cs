using System;
using System.Collections.Generic;
using Mentrello.Domain.Models;
using Mentrello.Domain.Repositories;

namespace Mentrello.Data.Repositories
{
    public class BoardRepository : IBoardRepository
    {
        public Board CreateNewBoard(Board board)
        {
            throw new NotImplementedException();
        }

        public bool DeleteBoardById(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Board> GetAllBoards()
        {
            throw new NotImplementedException();
        }

        public Board GetBoardById(Guid id)
        {
            throw new NotImplementedException();
        }

        public bool UpdateBoardById(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
