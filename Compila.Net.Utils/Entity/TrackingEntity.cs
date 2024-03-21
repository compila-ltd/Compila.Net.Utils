using System;

namespace Compila.Net.Utils.Entity
{
    [Obsolete]
    public abstract class TrackingEntity : Entity
    {
        public long CreatedAt { get; set; }
        public long UpdatedAt { get; set; }

        public TrackingEntity() : base()
        {

        }
    }
}
