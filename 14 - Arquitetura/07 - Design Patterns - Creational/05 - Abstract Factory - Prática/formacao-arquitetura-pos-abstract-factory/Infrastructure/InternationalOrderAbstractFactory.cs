using Patterns.API.Core.Enums;
using Patterns.API.Infrastructure.Deliveries;
using Patterns.API.Infrastructure.Payments;

namespace Patterns.API.Infrastructure
{
    public class InternationalOrderAbstractFactory : IOrderAbstractFactory
    {
        private readonly InternationalDeliveryService _internationalDeliveryService;
        private readonly CreditCardService _creditCardService;

        public InternationalOrderAbstractFactory(
            InternationalDeliveryService internationalDeliveryService,
            CreditCardService creditCardService)
        {
            _internationalDeliveryService = internationalDeliveryService;
            _creditCardService = creditCardService;
        }

        public IDeliveryService GetDeliveryService()
        {
            return _internationalDeliveryService;
        }

        public IPaymentService GetPaymentService(PaymentMethod method)
        {
            if (method != PaymentMethod.CreditCard)
                throw new InvalidOperationException("Somente cartão de crédito é aceito para pedidos internacionais.");

            return _creditCardService;
        }
    }
}
