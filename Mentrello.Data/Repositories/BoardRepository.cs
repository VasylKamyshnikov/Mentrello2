using System;
using System.Collections.Generic;
using Mentrello.Domain.Models;
using Mentrello.Domain.Repositories;

namespace Mentrello.Data.Repositories
{
    public class BoardRepository : IBoardRepository
    {
        public IOutput<BoardModel> Create(BoardModel model)
        {
            var board = new BoardModel
            {
                Name = "First Board",
                Description = "First Created Board",
                Owner = new UserModel { FullName = "First Last" }
            };

            return new Output<BoardModel> { Succeeded = true, Result = board };
        }

        public IOutput<BoardModel> DeleteById(Guid id)
        {
            var board = new BoardModel
            {
                Name = "First Board",
                Description = "First Deleted Board",
                Owner = new UserModel { FullName = "First Last" }
            };

            return new Output<BoardModel> { Succeeded = true, Result = board };
        }

        public IOutput<IEnumerable<BoardModel>> GetAll()
        {
            var board1 = new BoardModel
            {
                Name = "First Board",
                Description = "First Created Board",
                Owner = new UserModel { FullName = "First Last" }
            };
            var board2 = new BoardModel
            {
                Name = "Second Board",
                Description = "Second Created Board",
                Owner = new UserModel { FullName = "First Last" }
            };
            var cards = new List<BoardModel> { board1, board2 };

            return new Output<IEnumerable<BoardModel>> { Succeeded = true, Result = cards };
        }

        public IOutput<BoardModel> GetById(Guid id)
        {
            var board = new BoardModel
            {
                Name = "First Board",
                Description = "First Created Board",
                Owner = new UserModel { FullName = "First Last" }
            };

            return new Output<BoardModel> { Succeeded = true, Result = board };
        }

        public IOutput<BoardModel> UpdateById(Guid id)
        {
            var board = new BoardModel
            {
                Name = "First Board",
                Description = "First Updated Board",
                Owner = new UserModel { FullName = "First Last" }
            };

            return new Output<BoardModel> { Succeeded = true, Result = board };
        }
    }
}
