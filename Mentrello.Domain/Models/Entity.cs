namespace Mentrello.Domain.Models
{
    public abstract class Entity
    {
        public long Id { get; private set; }
        public object Curent => this;
        public override bool Equals(object obj)
        {
            var other = obj as Entity;

            if (other is null)
                return false;

            if (ReferenceEquals(this, other))
                return true;

            if (Curent.GetType() != other.Curent.GetType())
                return false;

            if (Id == 0 || other.Id == 0)
                return false;

            return Id == other.Id;
        }
        public static bool operator ==(Entity first, Entity second)
        {
            if (first is null && second is null)
                return true;

            if (first is null || second is null)
                return false;

            return first.Equals(second);
        }

        public static bool operator !=(Entity first, Entity second)
        {
            return !(first == second);
        }

        public override int GetHashCode()
        {
            return (Curent.GetType().ToString() + Id).GetHashCode();
        }
    }
}
