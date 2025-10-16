using Patterns.API.Core.Enums;
using Patterns.API.Infrastructure.Deliveries;
using Patterns.API.Infrastructure.Payments;

namespace Patterns.API.Infrastructure
{
    public interface IOrderAbstractFactory
    {
        IPaymentService GetPaymentService(PaymentMethod method);
        IDeliveryService GetDeliveryService();
    }
}