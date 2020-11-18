namespace Mentrello.Data.Entities
{
    public interface IEntity<PrimaryKey>
    {
        PrimaryKey Id { get; set; }
    }
}
