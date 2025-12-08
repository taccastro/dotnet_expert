using Microsoft.AspNetCore.Mvc;
using Patterns.API.Application.Models;
using Patterns.API.Infrastructure;

namespace Patterns.API.Controllers
{
    [ApiController]
    [Route("api/orders")]
    public class OrdersController : ControllerBase
    {
        [HttpPost]
        public IActionResult Post(
        [FromServices] InternationalOrderAbstractFactory internationalOrderAbstractFactory,
        [FromServices] NationalOrderAbstractFactory nationalOrderAbstractFactory,
        OrderInputModel model
        )
        {
            IOrderAbstractFactory orderAbstractFactory;

            if (model.IsInternational != null && model.IsInternational.Value)
                orderAbstractFactory = internationalOrderAbstractFactory;
            else
                orderAbstractFactory = nationalOrderAbstractFactory;

            var paymentResult = orderAbstractFactory
                .GetPaymentService(model.PaymentInfo.PaymentMethod)
                .Process(model);

            orderAbstractFactory
                .GetDeliveryService()
                .Deliver(model);

            return NoContent();
        }
    }
}