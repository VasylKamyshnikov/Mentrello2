using Mentrello.Domain.Models;

namespace Mentrello.Data.Entities
{
    public class BoardEntity : Board, IEntity<int>
    {
        public int EntityId { get; set; }
    }
}
