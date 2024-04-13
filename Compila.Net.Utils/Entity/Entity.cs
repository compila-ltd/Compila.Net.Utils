namespace Compila.Net.Utils.Entity
{
    public interface IEntity { }

    public abstract class Entity : IEntity
    {
        public Guid Id { get; set; }

        public Entity()
        {
            Id = Guid.NewGuid();
        }
    }
}
