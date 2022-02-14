using System;

namespace Order.Domain.SeedWork
{
    public abstract class BaseEntity<T>:IAggregateRoot
    {
        public T Id { get; set; } 
    }
}