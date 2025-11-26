namespace EventDrivenArchitecture.Warehouse.Events
{
    public class EventoPedidoEnviado
    {
        public EventoPedidoEnviado(int id)
        {
            Id = id;

            DataEnvio = DateTime.Now;
        }

        public int Id { get; private set; }
        public DateTime DataEnvio { get; private set; }
    }
}
