using Patterns.API.Application.Models;

namespace Patterns.API.Infrastructure.Payments
{
    public class CreditCardService : IPaymentService
    {
        public object Process(OrderInputModel model)
        {
            return "Transação aprovada";
        }
    }
}