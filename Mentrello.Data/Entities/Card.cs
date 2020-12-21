namespace Mentrello.Data.Entities
{
    public class Card : IEntity<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public string Comment { get; set; }

        public Board ParentBoard { get; set; }

        public User AssignedTo { get; set; }
        public User Owner { get; set; }
    }
}
