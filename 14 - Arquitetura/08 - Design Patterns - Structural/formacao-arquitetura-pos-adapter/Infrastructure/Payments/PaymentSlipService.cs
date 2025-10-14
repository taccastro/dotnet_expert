using AwesomeShopPatterns.API.Application.Models;
using AwesomeShopPatterns.API.Infrastructure.Payments.Adapters;

namespace AwesomeShopPatterns.API.Infrastructure.Payments
{
    public class PaymentSlipService : IPaymentService
    {
        private readonly IExternalPaymentSlipService _externalService;

        public PaymentSlipService(IExternalPaymentSlipService externalService)
        {
            _externalService = externalService;
        }

        public object Process(OrderInputModel model)
        {
            var paymentSlipServiceAdapter = new PaymentSlipServiceAdapter(_externalService);

            var paymentSlipModel = paymentSlipServiceAdapter.GeneratePaymentSlip(model);

            return "Dados do Boleto";
        }
    }
}