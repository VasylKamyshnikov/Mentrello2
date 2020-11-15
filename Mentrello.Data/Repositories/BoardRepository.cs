using Mentrello.Domain.Models;
using Mentrello.Domain.Repositories;
using System;
using System.Collections.Generic;

namespace Mentrello.Data.Repositories
{
    public class BoardRepository : IBoardRepository<Guid>
    {
        public IOutput<Board<Guid>> CreateNewBoard()
        {
            throw new NotImplementedException();
        }

        public IOutput<bool> DeleteBoardById(Guid id)
        {
            throw new NotImplementedException();
        }

        public IOutput<IEnumerable<Board<Guid>>> GetAllBoards()
        {
            throw new NotImplementedException();
        }

        public IOutput<Board<Guid>> GetBoardById(Guid id)
        {
            throw new NotImplementedException();
        }

        public IOutput<bool> UpdateBoardById(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
