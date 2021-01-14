namespace Mentrello.Domain.Models
{
    public class Board : Entity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public User Owner { get; set; }
    }
}
