namespace Mentrello.Domain.Models
{
    public abstract class Card<T> : IModelBase<T>
    {
        public T Id { get; set; }
    }
}
