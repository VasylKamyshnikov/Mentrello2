using System.Collections.Generic;

namespace Mentrello.Data.Entities
{
    public class Board : IEntity<int>
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }

        public User Owner { get; set; }
        public ICollection<Card> Cards { get; set; }
    }
}
