using Mentrello.Domain.Models;
using System;

namespace Mentrello.Services.Models
{
    public class Board : Board<Guid>
    {
        public string Description { get; set; }
    }
}
