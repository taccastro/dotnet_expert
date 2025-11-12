using HexagonalArchitecture.Domain.Entities;

namespace HexagonalArchitecture.Domain.Repositories
{
    public interface IOrderRepository
    {
        Task<Order> GetById(int id);
        Task<List<Order>> GetAll();
        Task<int> Add(Order order);
    }
}
