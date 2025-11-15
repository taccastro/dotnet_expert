using CleanArchitecture.Core.Entities;

namespace CleanArchitecture.Core.Repositories
{
    public interface IOrderRepository
    {
        Task<Order> GetById(int id);
        Task<List<Order>> GetAll();
        Task<int> Add(Order order);
    }
}
