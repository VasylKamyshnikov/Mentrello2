namespace Mentrello.Data.Entities
{
    public interface IEntity<PKeyType>
    {
        PKeyType EntityId { get; set; }
    }
}
