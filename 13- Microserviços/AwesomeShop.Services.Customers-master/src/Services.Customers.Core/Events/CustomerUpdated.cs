using Services.Customers.Core.ValueObjects;
using System;

namespace Services.Customers.Core.Events
{
    public class CustomerUpdated : IDomainEvent
    {
        public CustomerUpdated(Guid id, string phoneNumber, Address address)
        {
            Id = id;
            Address = address;
        }

        public Guid Id { get; private set; }
        public Address Address { get; private set; }
    }
}