using System;

namespace Mentrello.Domain.Models
{
    public interface ICard
    {
        //Guid Id { get; set; }

        string Name { get; set; }
        string Description { get; set; }
        string Status { get; set; }
        string Comment { get; set; }

        IBoard ParentBoard { get; set; }

        IUser AssignedTo { get; set; }
        IUser Owner { get; set; }
    }
    public class CardModel : ICard
    {
        //public Guid Id { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public string Comment { get; set; }

        public IBoard ParentBoard { get; set; }

        public IUser AssignedTo { get; set; }
        public IUser Owner { get; set; }
    }
}
