namespace Mentrello.Domain.Models
{
    public abstract class Board<T> : IModelBase<T>
    {
        public T Id { get; set; }
    }
}
