using AwesomeShopPatterns.API.Core.Enums;
using AwesomeShopPatterns.API.Infrastructure.Integrations;
using AwesomeShopPatterns.API.Infrastructure.Payments.Decorators;

namespace AwesomeShopPatterns.API.Infrastructure.Payments
{
    public class PaymentServiceFactory : IPaymentServiceFactory
    {
        private readonly CreditCardService _creditCardService;
        private readonly PaymentSlipService _paymentSlipService;
        private readonly ICoreCrmIntegrationService _crmService;
        private readonly IAntiFraudFacade _antiFraudFacade; // <- adicionado

        public PaymentServiceFactory(
            CreditCardService creditCardService,
            PaymentSlipService paymentSlipService,
            ICoreCrmIntegrationService crmService,
            IAntiFraudFacade antiFraudFacade) // <- adicionado

        {
            _creditCardService = creditCardService;
            _paymentSlipService = paymentSlipService;
            _crmService = crmService;
            _antiFraudFacade = antiFraudFacade; // <- inicializado
        }

        public IPaymentService GetService(PaymentMethod paymentMethod)
        {
            IPaymentService paymentService;

            switch (paymentMethod)
            {
                case PaymentMethod.CreditCard:
                    paymentService = _creditCardService;

                    break;
                case PaymentMethod.PaymentSlip:
                    paymentService = _paymentSlipService;

                    break;
                default:
                    throw new InvalidOperationException();
            }

            return new PaymentServiceDecorator(paymentService, _crmService, _antiFraudFacade);
        }
    }
}