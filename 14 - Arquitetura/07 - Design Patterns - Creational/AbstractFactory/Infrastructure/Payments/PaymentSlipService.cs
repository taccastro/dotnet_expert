using Patterns.API.Application.Models;

namespace Patterns.API.Infrastructure.Payments
{
    public class PaymentSlipService : IPaymentService
    {
        public object Process(OrderInputModel model)
        {
            return "Dados do Boleto";
        }
    }
}