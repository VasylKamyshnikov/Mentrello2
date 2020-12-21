using System;
using Mentrello.Domain.Models;

namespace Mentrello.Domain.Repositories
{
    public interface ICardRepository : IRepository<CardModel, Guid>
    {
    }
}
