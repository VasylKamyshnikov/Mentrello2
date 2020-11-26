namespace Mentrello.Domain.Repositories
{
    public interface IOutput<T>
    {
        bool IsSuccessful { get; set; }
        T Result { get; set; }
    }

    public class Output<T> : IOutput<T>
    {
        public bool IsSuccessful { get; set; }
        public T Result { get; set; }
    }
}
