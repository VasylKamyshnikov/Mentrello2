using System;
using Mentrello.Domain.Models;

namespace Mentrello.Domain.Repositories
{
    public interface IBoardRepository : IRepository<Board, Guid>
    {
    }
}
