using EventDrivenArchitecture.Warehouse.Events;
using EventDrivenArchitecture.Warehouse.Integrations;
using Newtonsoft.Json;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Text;

namespace EventDrivenArchitecture.Warehouse.Subscribers
{
    public class SubscritorPedidoCriado : BackgroundService
    {
        private readonly IConnection _connection;
        private readonly IModel _channel;
        private const string Fila = "servico-armazem/pedido-criado";
        private const string RoutingKeyInscricao = "pedido-criado";
        private const string RoutingKeyPublicacao = "pedido-enviado";
        private readonly IServiceProvider _serviceProvider;
        private const string Exchange = "servico-armazem";
        private const string ExchangePedidos = "servico-pedidos";
        public SubscritorPedidoCriado(IServiceProvider serviceProvider)
        {
            var connectionFactory = new ConnectionFactory
            {
                HostName = "localhost"
            };

            _connection = connectionFactory.CreateConnection("servico-armazem-consumidor-pedido-criado");

            _channel = _connection.CreateModel();

            _channel.QueueDeclare(
                queue: Fila,
                durable: false,
                exclusive: false,
                autoDelete: true,
                null);

            _channel.QueueBind(Fila, ExchangePedidos, RoutingKeyInscricao);

            _serviceProvider = serviceProvider;
        }

        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            var consumer = new EventingBasicConsumer(_channel);

            consumer.Received += async (sender, eventArgs) =>
            {
                var contentArray = eventArgs.Body.ToArray();
                var contentString = Encoding.UTF8.GetString(contentArray);
                var eventoPedidoCriado = JsonConvert.DeserializeObject<EventoPedidoCriado>(contentString);

                Console.WriteLine($"Mensagem EventoPedidoCriado recebida com Id {eventoPedidoCriado.Id}");

                EnviarPedido(eventoPedidoCriado);

                _channel.BasicAck(eventArgs.DeliveryTag, false);

                var pedidoEnviado = new EventoPedidoEnviado(eventoPedidoCriado.Id);
                var jsonBytes = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(pedidoEnviado));

                _channel.BasicPublish(Exchange, RoutingKeyPublicacao, null, jsonBytes);
            };

            _channel.BasicConsume(Fila, false, consumer);

            return Task.CompletedTask;
        }

        public void EnviarPedido(EventoPedidoCriado @event)
        {
            using (var scope = _serviceProvider.CreateScope())
            {
                var servicoEnvio = scope.ServiceProvider.GetService<IServicoEnvio>();

                servicoEnvio.EnviarPedido(@event);
            }
        }
    }
}
