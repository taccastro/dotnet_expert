using Patterns.API.Application.Models;
using Patterns.API.Infrastructure.Payments;
using Microsoft.AspNetCore.Mvc;

namespace Patterns.API.Controllers
{
    [ApiController]
    [Route("api/orders")]
    public class OrdersController : ControllerBase
    {
        private readonly IPaymentService _paymentService;

        public OrdersController(IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }

        [HttpPost]
        public IActionResult Post(OrderInputModel model)
        {
            var result = _paymentService.Process(model);
            return Ok(result);
        }
    }
}
