namespace EventDrivenArchitecture.Warehouse.Events
{
    public class OrderShippedEvent
    {
        public OrderShippedEvent(int id)
        {
            Id = id;

            DateShipped = DateTime.Now;
        }

        public int Id { get; private set; }
        public DateTime DateShipped { get; private set; }
    }
}
