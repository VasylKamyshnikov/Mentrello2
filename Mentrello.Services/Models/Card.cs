using Mentrello.Domain.Models;
using System;

namespace Mentrello.Services.Models
{
    public class Card : Card<Guid>
    {
        public string Description { get; set; }
    }
}
