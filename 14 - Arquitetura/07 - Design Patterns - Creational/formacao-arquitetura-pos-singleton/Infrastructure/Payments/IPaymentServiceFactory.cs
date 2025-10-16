using AwesomeShopPatterns.API.Core.Enums;

namespace AwesomeShopPatterns.API.Infrastructure.Payments
{
    public interface IPaymentServiceFactory
    {
        IPaymentService GetService(PaymentMethod paymentMethod);
    }
}