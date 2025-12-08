using Patterns.API.Application.Models;

namespace Patterns.API.Infrastructure.Payments.Decorators
{
    public class PaymentServiceDecorator : IPaymentService
    {
        private readonly IPaymentService _paymentService;

        public PaymentServiceDecorator(IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }

        public object Process(OrderInputModel model)
        {
            // comportamento adicional (antes)
            Console.WriteLine("Iniciando processamento do pagamento...");

            var result = _paymentService.Process(model);

            // comportamento adicional (depois)
            Console.WriteLine("Pagamento concluído com sucesso.");

            return result;
        }
    }
}
