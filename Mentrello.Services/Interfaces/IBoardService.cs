using System;
using System.Collections.Generic;
using System.Security.Claims;
using Mentrello.Services.Models;

namespace Mentrello.Services.Interfaces
{
    public interface IBoardService
    {
        BoardModel CreateBoard(ClaimsPrincipal user, BoardModel model);
        IEnumerable<BoardModel> GetAllBoards(ClaimsPrincipal user);
        BoardModel GetBoardById(ClaimsPrincipal user, Guid id);
        bool UpdateExistingBoard(ClaimsPrincipal user, Guid id);
        bool DeleteBoardById(ClaimsPrincipal user, Guid id);
    }
}
