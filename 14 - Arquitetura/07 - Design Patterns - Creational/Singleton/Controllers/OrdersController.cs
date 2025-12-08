using AwesomeShopPatterns.API.Application.Configurations;
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
            return Ok(BusinessHours.GetInstance());
        }
    }
}