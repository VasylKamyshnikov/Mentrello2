using System;
using Mentrello.Domain.Models;

namespace Mentrello.Services.Models
{
    public class CardModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Actor AssignedUser { get; set; }
        public Actor Author { get; set; }
    }
}
