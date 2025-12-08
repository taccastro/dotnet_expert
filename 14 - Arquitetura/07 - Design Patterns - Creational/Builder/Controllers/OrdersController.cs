using AwesomeShopPatterns.API.Application.Models;
using AwesomeShopPatterns.API.Infrastructure.Payments.Models;
using Microsoft.AspNetCore.Mvc;

namespace AwesomeShopPatterns.API.Controllers
{
    [ApiController]
    [Route("api/orders")]
    public class OrdersController : ControllerBase
    {
        [HttpPost]
        public IActionResult Post(OrderInputModel model)
        {
            // Exemplo de uso do padrão Builder
            var paymentSlip = new PaymentSlipBuilder()
                .WithPayer(model.CustomerName ?? "Cliente Desconhecido")
                .WithAmount(model.TotalAmount)
                .WithDueDate(DateTime.Now.AddDays(5))
                .Build();

            return Ok(paymentSlip);
        }

        [HttpGet("example")]
        public IActionResult Example()
        {
            // Endpoint simples para testar o Builder sem enviar nada
            var paymentSlip = new PaymentSlipBuilder()
                .WithPayer("Tiago Castro")
                .WithAmount(150.00m)
                .WithDueDate(DateTime.Now.AddDays(5))
                .Build();

            return Ok(paymentSlip);
        }
    }
}
