using System;

namespace Mentrello.Domain.Models
{
    public interface IUser
    {
        //Guid Id { get; set; }
        string FullName { get; set; }
        string Email { get; set; }
    }

    public class UserModel : IUser
    {
        //public Guid Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
    }
}
