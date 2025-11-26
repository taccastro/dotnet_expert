using Newtonsoft.Json;
using RabbitMQ.Client;
using System.Text;

namespace EventDrivenArchitecture.Orders.MessageBus
{
    public class RabbitMqService : IMessageBusService
    {
        private readonly IConnection _connection;
        private readonly IModel _channel;
        private const string Exchange = "servico-pedidos";
        public RabbitMqService()
        {
            var connectionFactory = new ConnectionFactory
            {
                HostName = "localhost"
            };

            _connection = connectionFactory.CreateConnection("servico-pedidos-publicador");

            _channel = _connection.CreateModel();
        }

        public void Publish(object data, string routingKey)
        {
            var type = data.GetType();

            var payload = JsonConvert.SerializeObject(data);
            var byteArray = Encoding.UTF8.GetBytes(payload);

            Console.WriteLine($"{type.Name} Publicado");

            _channel.BasicPublish(Exchange, routingKey, null, byteArray);
        }
    }
}
