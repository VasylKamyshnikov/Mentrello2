using System;
using System.Collections.Generic;
using Mentrello.Domain.Models;
using Mentrello.Domain.Repositories;

namespace Mentrello.Data.Repositories
{
    public class BoardRepository : IBoardRepository
    {
        public IOutput<Board> Create(Board model)
        {
            var board = new Board
            {
                Name = "First Board",
                Description = "First Created Board",
                Owner = new Actor { FullName = "First Last" }
            };

            return new Output<Board> { IsSuccessful = true, Result = board };
        }

        public IOutput<Board> DeleteById(Guid id)
        {
            var board = new Board
            {
                Name = "First Board",
                Description = "First Deleted Board",
                Owner = new Actor { FullName = "First Last" }
            };

            return new Output<Board> { IsSuccessful = true, Result = board };
        }

        public IOutput<IEnumerable<Board>> GetAll()
        {
            var board1 = new Board
            {
                Name = "First Board",
                Description = "First Created Board",
                Owner = new Actor { FullName = "First Last" }
            };
            var board2 = new Board
            {
                Name = "Second Board",
                Description = "Second Created Board",
                Owner = new Actor { FullName = "First Last" }
            };
            var cards = new List<Board> { board1, board2 };

            return new Output<IEnumerable<Board>> { IsSuccessful = true, Result = cards };
        }

        public IOutput<Board> GetById(Guid id)
        {
            var board = new Board
            {
                Name = "First Board",
                Description = "First Created Board",
                Owner = new Actor { FullName = "First Last" }
            };

            return new Output<Board> { IsSuccessful = true, Result = board };
        }

        public IOutput<Board> UpdateById(Guid id)
        {
            var board = new Board
            {
                Name = "First Board",
                Description = "First Updated Board",
                Owner = new Actor { FullName = "First Last" }
            };

            return new Output<Board> { IsSuccessful = true, Result = board };
        }
    }
}
