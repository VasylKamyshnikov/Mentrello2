using Mentrello.Domain.Models;
using Mentrello.Domain.Repositories;
using Mentrello.Tests.Mocks.Entities;
using System;
using System.Collections.Generic;

namespace Mentrello.Tests.Mocks.Repositories
{
    public class IBoardRepositoryMock : IBoardRepository<Guid>
    {
        public IOutput<Board<Guid>> CreateNewBoard()
        {
            var result = new BoardMock();
            var repoResult = new Output<Board<Guid>>
            {
                IsSuccess = true,
                Result = result
            };

            return repoResult;
        }

        public IOutput<bool> DeleteBoardById(Guid id)
        {
            var repoResult = new Output<bool>
            {
                IsSuccess = true,
                Result = true
            };

            return repoResult;
        }

        public IOutput<IEnumerable<Board<Guid>>> GetAllBoards()
        {
            var result = new List<BoardMock> { new BoardMock() };
            var repoResult = new Output<List<Board<Guid>>>
            {
                IsSuccess = true,
                Result = result
            };

            return repoResult;
        }

        public IOutput<Board<Guid>> GetBoardById(Guid id)
        {
            var result = new BoardMock();
            var repoResult = new Output<Board<Guid>>
            {
                IsSuccess = true,
                Result = result
            };

            return repoResult;
        }

        public IOutput<bool> UpdateBoardById(Guid id)
        {
            var repoResult = new Output<bool>
            {
                IsSuccess = true,
                Result = true
            };

            return repoResult;
        }
    }
}
