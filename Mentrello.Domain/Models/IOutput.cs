namespace Mentrello.Domain.Models
{
    public interface IOutput<TResult>
    {
        bool IsSuccess { get; set; }
        TResult Result { get; set; }
    }

    public class Output<TResult> : IOutput<TResult>
    {
        public bool IsSuccess { get; set; }
        public TResult Result { get; set; }
    }
}
