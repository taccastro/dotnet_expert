using Services.Customers.Core.Entities;
using System;
using System.Threading.Tasks;

namespace Services.Customers.Core.Repositories
{
    public interface ICustomerRepository
    {
        Task<Customer> GetByIdAsync(Guid id);
        Task AddAsync(Customer customer);
        Task UpdateAsync(Customer customer);
    }
}