using EventDrivenArchitecture.Orders.Enums;

namespace EventDrivenArchitecture.Orders.Repositories
{
    public class RepositorioPedido : IOrderRepository
    {
        public void UpdateOrderStatus(int id, OrderStatus status)
        {
            // Status do Pedido Atualizado
            Console.WriteLine($"Status do pedido {id} atualizado para {status}");
        }
    }
}
