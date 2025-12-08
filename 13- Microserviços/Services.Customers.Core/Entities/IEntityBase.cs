using System;

namespace Services.Customers.Core.Entities
{
    public interface IEntityBase
    {
        Guid Id { get; }
    }
}