using EventDrivenArchitecture.Orders.Events;
using EventDrivenArchitecture.Orders.MessageBus;
using EventDrivenArchitecture.Orders.Models;
using Microsoft.AspNetCore.Mvc;

namespace EventDrivenArchitecture.Orders.Controllers
{
    [ApiController]
    [Route("api/pedidos")]
    public class PedidosController : ControllerBase
    {
        private readonly IMessageBusService _busService;

        public PedidosController(IMessageBusService busService)
        {
            _busService = busService;
        }

        [HttpPost]
        public IActionResult Post(ModeloEntradaPedido modelo)
        {
            var id = new Random().Next(1, 10000); // Poderia ser chamada de um Repositório, por exemplo.

            var evento = new EventoPedidoCriado(id, modelo);

            _busService.Publish(evento, "pedido-criado");

            return Accepted();
        }
    }
}
