using System;

namespace Mentrello.Domain.Models
{
    public interface IBoard
    {
        Guid Id { get; set; }

        string Name { get; set; }
        string Description { get; set; }

        IActor Owner { get; set; }
    }

    public class Board : IBoard
    {
        public Guid Id { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }

        public IActor Owner { get; set; }
    }
}
