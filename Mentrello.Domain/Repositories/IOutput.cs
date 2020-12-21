namespace Mentrello.Domain.Repositories
{
    public interface IOutput<T>
    {
        bool Succeeded { get; set; }
        T Result { get; set; }
    }

    public class Output<T> : IOutput<T>
    {
        public bool Succeeded { get; set; }
        public T Result { get; set; }
    }
}
