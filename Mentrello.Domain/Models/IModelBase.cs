namespace Mentrello.Domain.Models
{
    public interface IModelBase<T>
    {
        T Id { get; set; }
    }
}
