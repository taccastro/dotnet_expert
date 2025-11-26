using Microsoft.AspNetCore.Mvc;
using Patterns.API.Application.Models;
using Patterns.API.Infrastructure.Integrations;

namespace Patterns.API.Controllers
{
    [ApiController]
    [Route("api/orders")]
    public class OrdersController : ControllerBase
    {
        private readonly IAntiFraudFacade _antiFraudFacade;

        public OrdersController(IAntiFraudFacade antiFraudFacade)
        {
            _antiFraudFacade = antiFraudFacade;
        }

        [HttpPost]
        public IActionResult Post([FromBody] OrderInputModel model)
        {
            // Mapeia os dados do pedido para o modelo de antifraude
            var antiFraudModel = new AntiFraudModel(
                document: model.Customer.Document,
                totalAmount: model.TotalPrice
            );

            // Envia para o Facade
            var result = _antiFraudFacade.Check(antiFraudModel);

            if (!result.IsValid)
                return BadRequest(new { message = "Pedido reprovado pela análise antifraude." });

            return Ok(new { message = "Pedido aprovado e processado com sucesso." });
        }
    }
}
