using EventDrivenArchitecture.Orders.Enums;
using EventDrivenArchitecture.Orders.Repositories;
using Newtonsoft.Json;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Text;

namespace EventDrivenArchitecture.Orders.Subscribers
{
    public class SubscritorPedidoEnviado : BackgroundService
    {
        private readonly IConnection _connection;
        private readonly IModel _channel;
        private const string Fila = "servico-pedidos/pedido-criado"; // Mantendo a lógica original, mas traduzindo
        private const string RoutingKeyInscricao = "pedido-enviado";
        private readonly IServiceProvider _serviceProvider;
        private const string Exchange = "servico-pedidos";
        private const string ExchangeArmazem = "servico-armazem";
        public SubscritorPedidoEnviado(IServiceProvider serviceProvider)
        {
            var connectionFactory = new ConnectionFactory
            {
                HostName = "localhost"
            };

            _connection = connectionFactory.CreateConnection("servico-pedidos-consumidor-pedido-enviado");

            _channel = _connection.CreateModel();

            _channel.ExchangeDeclare(Exchange, "direct", false, true, null);
            _channel.ExchangeDeclare(ExchangeArmazem, "direct", false, true, null);

            _channel.QueueDeclare(
                queue: Fila,
                durable: false,
                exclusive: false,
                autoDelete: true,
                null);

            _channel.QueueBind(Fila, ExchangeArmazem, RoutingKeyInscricao);

            _serviceProvider = serviceProvider;
        }

        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            var consumer = new EventingBasicConsumer(_channel);

            consumer.Received += async (sender, eventArgs) =>
            {
                var contentArray = eventArgs.Body.ToArray();
                var contentString = Encoding.UTF8.GetString(contentArray);
                var eventoPedidoEnviado = JsonConvert.DeserializeObject<EventoPedidoEnviado>(contentString);

                Console.WriteLine($"Mensagem EventoPedidoEnviado recebida com Id {eventoPedidoEnviado.Id}");

                AtualizarStatusPedido(eventoPedidoEnviado);

                _channel.BasicAck(eventArgs.DeliveryTag, false);
            };

            _channel.BasicConsume(Fila, false, consumer);

            return Task.CompletedTask;
        }

        public void AtualizarStatusPedido(EventoPedidoEnviado @event)
        {
            using (var scope = _serviceProvider.CreateScope())
            {
                var repositorio = scope.ServiceProvider.GetService<IOrderRepository>();

                repositorio.UpdateOrderStatus(@event.Id, OrderStatus.Shipped);
            }
        }
    }

    // Classe DTO simples para o evento, já que não temos acesso ao projeto Warehouse aqui diretamente sem referência circular ou duplicação
    public class EventoPedidoEnviado
    {
        public int Id { get; set; }
    }
}
