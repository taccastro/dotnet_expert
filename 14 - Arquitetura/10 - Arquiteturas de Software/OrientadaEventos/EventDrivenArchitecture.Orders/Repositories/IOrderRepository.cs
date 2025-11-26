using EventDrivenArchitecture.Orders.Enums;

namespace EventDrivenArchitecture.Orders.Repositories
{
    public interface IOrderRepository
    {
        void UpdateOrderStatus(int id, OrderStatus status);
    }
}
