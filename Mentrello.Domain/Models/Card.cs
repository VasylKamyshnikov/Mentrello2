using System;

namespace Mentrello.Domain.Models
{
    public class Card : Entity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public User Owner { get; set; }
    }
}
