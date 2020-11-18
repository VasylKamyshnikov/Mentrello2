using System;
using System.Collections.Generic;
using System.Security.Claims;
using Mentrello.Domain.Models;
using Mentrello.Domain.Repositories;
using Mentrello.Services.Interfaces;
using Mentrello.Services.Models;
using Mentrello.Utils.Exceptions;

namespace Mentrello.Services.Implementations
{
    public class BoardService : IBoardService
    {
        private readonly IBoardRepository _boardRepository;

        public BoardService(IBoardRepository boardRepository)
        {
            _boardRepository = boardRepository;
        }

        public BoardModel CreateBoard(ClaimsPrincipal user, BoardModel model)
        {
            //validate user
            if (user == null)
            {
                throw new InvalidUserException();
            }

            var board = new Board
            {
                BoardId = Guid.NewGuid(),
                Name = model.Name,
                Description = model.Description
            };

            var result = _boardRepository.CreateNewBoard(board);

            return new BoardModel
            {
                Name = result.Name,
                Description = result.Description,
                AssignedToId = result.AssignedToId,
                AuthorId = result.AuthorId
            };
        }

        public bool DeleteBoardById(ClaimsPrincipal user, Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<BoardModel> GetAllBoards(ClaimsPrincipal user)
        {
            throw new NotImplementedException();
        }

        public BoardModel GetBoardById(ClaimsPrincipal user, Guid id)
        {
            throw new NotImplementedException();
        }

        public bool UpdateExistingBoard(ClaimsPrincipal user, Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
