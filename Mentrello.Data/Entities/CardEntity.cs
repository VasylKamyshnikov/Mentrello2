using Mentrello.Domain.Models;

namespace Mentrello.Data.Entities
{
    public class CardEntity : Card, IEntity<int>
    {
        public int EntityId { get; set; }
    }
}
