using Patterns.API.Core.Enums;
using Patterns.API.Infrastructure.Deliveries;
using Patterns.API.Infrastructure.Payments;

namespace Patterns.API.Infrastructure
{
    public class NationalOrderAbstractFactory : IOrderAbstractFactory
    {
        private readonly NationalDeliveryService _nationalDeliveryService;
        private readonly CreditCardService _creditCardService;
        private readonly PaymentSlipService _paymentSlipService;

        public NationalOrderAbstractFactory(
            NationalDeliveryService nationalDeliveryService,
            CreditCardService creditCardService,
            PaymentSlipService paymentSlipService)
        {
            _nationalDeliveryService = nationalDeliveryService;
            _creditCardService = creditCardService;
            _paymentSlipService = paymentSlipService;
        }

        public IDeliveryService GetDeliveryService()
        {
            return _nationalDeliveryService;
        }

        public IPaymentService GetPaymentService(PaymentMethod method)
        {
            return method switch
            {
                PaymentMethod.CreditCard => _creditCardService,
                PaymentMethod.PaymentSlip => _paymentSlipService,
                _ => throw new InvalidOperationException("Método de pagamento inválido.")
            };
        }
    }
}
