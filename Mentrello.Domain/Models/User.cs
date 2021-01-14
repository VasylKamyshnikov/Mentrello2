namespace Mentrello.Domain.Models
{
    public class User : Entity
    {
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName
        {
            get { return $"{FirstName} {LastName}"; }
            set { FullName = value; }
        }
        public Token Token { get; set; }
    }
}
