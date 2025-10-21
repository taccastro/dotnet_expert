namespace Patterns.API.Application.Models
{
    public class OrderInputModel
    {
        public CustomerInputModel Customer { get; set; }
        public List<OrderItemInputModel> Items { get; set; }
        public decimal TotalPrice => Items?.Sum(i => i.Price * i.Quantity) ?? 0;
    }

    public class CustomerInputModel
    {
        public Guid Id { get; set; }
        //public string FullName { get; set; }
        //public string Email { get; set; }
        public string Document { get; set; }
    }

    public class OrderItemInputModel
    {
        //public Guid ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}
