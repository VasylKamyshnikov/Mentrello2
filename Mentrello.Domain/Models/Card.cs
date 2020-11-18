using System;

namespace Mentrello.Domain.Models
{
    public class Card
    {
        public Guid CardId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
