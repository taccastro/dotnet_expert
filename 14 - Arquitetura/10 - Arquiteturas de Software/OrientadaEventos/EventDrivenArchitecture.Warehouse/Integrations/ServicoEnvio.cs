using EventDrivenArchitecture.Warehouse.Events;

namespace EventDrivenArchitecture.Warehouse.Integrations
{
    public class ServicoEnvio : IServicoEnvio
    {
        public void EnviarPedido(EventoPedidoCriado @event)
        {
            Console.WriteLine("Pedido enviado");
        }
    }
}
