using System.Security.Claims;
using Mentrello.Domain.Models;
using Mentrello.Domain.Repositories;
using Mentrello.Services.Implementations;
using Mentrello.Services.Interfaces;
using Mentrello.Services.Models;
using Mentrello.Utils.Exceptions;
using Moq;
using NUnit.Framework;

namespace Mentrello.Tests.Services
{
    public class BoardServiceTests
    {
        private Mock<IBoardRepository> _boardRepositoryMock;
        private IBoardService BoardService { get; set; }

        [SetUp]
        public void BoardServiceTests_Setup()
        {
            _boardRepositoryMock = new Mock<IBoardRepository>();

            BoardService = new BoardService(_boardRepositoryMock.Object);
        }

        [Test]
        public void CreateBoard_WithNullUser_InvalidUserExceptionThrown()
        {
            var board = new BoardModel
            {
                Name = "First Board",
                Description = "First board without assignee for test"
            };

            Assert.Throws<InvalidUserException>(() => BoardService.CreateBoard(null, board));
        }

        [Test]
        public void CreateBoard_MadeCallToRepository_Successfully()
        {
            var user = new ClaimsPrincipal();
            var board = new BoardModel
            {
                Name = "First Board",
                Description = "First board without assignee for test"
            };
            _boardRepositoryMock.Setup(x => x.CreateNewBoard(It.IsAny<Board>())).Returns(new Board());

            BoardService.CreateBoard(user, board);

            _boardRepositoryMock.Verify(x => x.CreateNewBoard(It.IsAny<Board>()), Times.Once());
        }
    }
}
