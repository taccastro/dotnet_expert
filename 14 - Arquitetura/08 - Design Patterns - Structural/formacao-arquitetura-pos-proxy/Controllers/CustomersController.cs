using AwesomeShopPatterns.API.Infrastructure;
using Microsoft.AspNetCore.Mvc;

namespace AwesomeShopPatterns.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomersController(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        [HttpGet("blocked")]
        public IActionResult GetBlockedCustomers()
        {
            var blockedCustomers = _customerRepository.GetBlockedCustomers();

            if (blockedCustomers == null || !blockedCustomers.Any())
                return NotFound("Nenhum cliente bloqueado encontrado.");

            return Ok(blockedCustomers);
        }
    }
}
