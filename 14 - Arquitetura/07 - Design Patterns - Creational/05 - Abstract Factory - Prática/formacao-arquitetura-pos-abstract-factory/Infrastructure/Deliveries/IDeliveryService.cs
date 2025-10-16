using Patterns.API.Application.Models;

namespace Patterns.API.Infrastructure.Deliveries
{
    public interface IDeliveryService
    {
        void Deliver(OrderInputModel model);
    }
}