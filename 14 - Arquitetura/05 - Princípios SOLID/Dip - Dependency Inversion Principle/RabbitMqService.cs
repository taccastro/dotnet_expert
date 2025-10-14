namespace SolidPrinciples.Dip
{
    public interface IMessageBusService
    {
        void Publish(string queue, object data);
    }

    public class RabbitMqService : IMessageBusService
    {
        public void Publish(string queue, object data)
        {
            throw new NotImplementedException();
        }
    }
}