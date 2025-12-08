using AwesomeShopPatterns.API.Application.Models;
using AwesomeShopPatterns.API.Infrastructure.Payments;
using AwesomeShopPatterns.API.Infrastructure.Payments.Adapters;
using Microsoft.AspNetCore.Mvc;

namespace AwesomeShopPatterns.API.Controllers
{
    [ApiController]
    [Route("api/payment")]
    public class PaymentController : ControllerBase
    {
        private readonly IExternalPaymentSlipService _externalService;

        public PaymentController(IExternalPaymentSlipService externalService)
        {
            _externalService = externalService;
        }

        [HttpPost("slip")]
        public IActionResult GeneratePaymentSlip(OrderInputModel model)
        {
            var adapter = new PaymentSlipServiceAdapter(_externalService);
            var slip = adapter.GeneratePaymentSlip(model);
            return Ok(slip);
        }
    }
}
