namespace Mentrello.Data.Entities
{
    public class User : IEntity<int>
    {
        public int Id { get; set; }
        public string UserName { get; set; }
    }
}
