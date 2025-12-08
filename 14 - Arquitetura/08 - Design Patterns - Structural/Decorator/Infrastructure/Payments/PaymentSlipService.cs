using Patterns.API.Application.Models;

namespace Patterns.API.Infrastructure.Payments
{
    public class PaymentSlipService : IPaymentService
    {
        public object Process(OrderInputModel model)
        {
            // Simulação de geração de boleto
            return new
            {
                Tipo = "Boleto",
                Valor = model?.TotalAmount ?? 0,
                Mensagem = "Boleto gerado com sucesso."
            };
        }
    }
}
