using System;

namespace Compila.Net.Utils.Entity
{
    [Obsolete]
    public abstract class Entity
    {
        public Guid Id { get; set; }

        public Entity()
        {
            Id = Guid.NewGuid();
        }
    }
}
