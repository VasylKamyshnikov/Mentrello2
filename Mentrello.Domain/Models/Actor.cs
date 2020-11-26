using System;

namespace Mentrello.Domain.Models
{
    public interface IActor
    {
        Guid Id { get; set; }
        string FullName { get; set; }
        string Username { get; set; }
    }

    public class Actor : IActor
    {
        public Guid Id { get; set; }
        public string FullName { get; set; }
        public string Username { get; set; }
    }
}
