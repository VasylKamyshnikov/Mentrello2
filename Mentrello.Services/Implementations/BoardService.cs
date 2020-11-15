using Mentrello.Domain.Repositories;
using Mentrello.Services.Interfaces;
using Mentrello.Services.Models;
using System;
using System.Collections.Generic;

namespace Mentrello.Services.Implementations
{
    public class BoardService : IBoardService
    {
        private readonly IBoardRepository<Guid> _boardRepository;

        public BoardService(IBoardRepository<Guid> boardRepository)
        {
            _boardRepository = boardRepository;
        }

        public Board CreateBoard()
        {
            var repoResult = _boardRepository.CreateNewBoard();
            if (repoResult.IsSuccess)
            {
                var board = new Board
                {
                    Id = repoResult.Result.Id,
                    Description = "I am new Board!"
                };

                return board;
            }

            return null;
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

        public bool UpdateExistingBoard(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
