using AwesomeShopPatterns.API.Application.Models;
using Microsoft.AspNetCore.Mvc;

namespace AwesomeShopPatterns.API.Controllers
{
    [ApiController]
    [Route("api/orders")]
    public class OrdersController : ControllerBase
    {
        [HttpPost]
        public IActionResult Post(
            OrderInputModel model
            )
        {
            var customerData = model.Customer.ReturnDataAsString();

            var customerCopy = model.Customer.Clone();
            var customerCopyData = (customerCopy as CustomerInputModel).ReturnDataAsString();

            return Ok(new { customerData, customerCopyData });
        }
    }
}