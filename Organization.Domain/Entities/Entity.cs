using System;

namespace Organization.Domain.Entities
{
    public abstract class Entity
    {
        public Guid Id { get; private set; }
    }
}