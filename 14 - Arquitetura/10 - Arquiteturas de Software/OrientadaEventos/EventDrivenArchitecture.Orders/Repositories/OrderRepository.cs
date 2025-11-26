using EventDrivenArchitecture.Orders.Enums;

namespace EventDrivenArchitecture.Orders.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        public void UpdateOrderStatus(int id, OrderStatus status)
        {
            // Order Status Updated
        }
    }
}
