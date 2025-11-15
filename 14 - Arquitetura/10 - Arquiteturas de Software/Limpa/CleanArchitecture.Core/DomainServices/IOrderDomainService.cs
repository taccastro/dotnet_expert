using CleanArchitecture.Core.Entities;

namespace CleanArchitecture.Core.DomainServices
{
    public interface IOrderDomainService
    {
        bool Validate(Customer customer, Order order);
    }
}