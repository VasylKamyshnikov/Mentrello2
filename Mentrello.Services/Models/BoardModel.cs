using System;

namespace Mentrello.Services.Models
{
    public class BoardModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string AssignedTo { get; set; }
        public string Author { get; set; }
        public Guid AssignedToId { get; set; }
        public Guid AuthorId { get; set; }
    }
}
