namespace Mentrello.Data.Entities
{
    public interface IEntity<PKeyType>
    {
        PKeyType Id { get; set; }
    }
}
