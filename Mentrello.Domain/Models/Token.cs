using System;

namespace Mentrello.Domain.Models
{
    public class Token : Entity
    {
        public string UserId { get; set; }
        public string TokenString { get; set; }
        public DateTime ExpirationDate { get; set; }
    }
}
