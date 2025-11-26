using EventDrivenArchitecture.Warehouse.Events;

namespace EventDrivenArchitecture.Warehouse.Integrations
{
    public class ShippingService : IShippingService
    {
        public void ShipOrder(OrderCreatedEvent @event)
        {
            Console.WriteLine("Order is shipped");
        }
    }
}
