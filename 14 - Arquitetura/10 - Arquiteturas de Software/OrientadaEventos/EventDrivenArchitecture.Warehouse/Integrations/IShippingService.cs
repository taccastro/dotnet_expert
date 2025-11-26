using EventDrivenArchitecture.Warehouse.Events;

namespace EventDrivenArchitecture.Warehouse.Integrations
{
    public interface IShippingService
    {
        void ShipOrder(OrderCreatedEvent @event);
    }
}
