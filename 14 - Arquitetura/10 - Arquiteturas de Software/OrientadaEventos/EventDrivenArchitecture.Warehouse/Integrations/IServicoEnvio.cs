using EventDrivenArchitecture.Warehouse.Events;

namespace EventDrivenArchitecture.Warehouse.Integrations
{
    public interface IServicoEnvio
    {
        void EnviarPedido(EventoPedidoCriado @event);
    }
}
