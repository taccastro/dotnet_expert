using HexagonalArchitecture.Domain.Entities;

namespace HexagonalArchitecture.Application.UseCases.AddOrder
{
    public class AddOrderInput
    {
        public string OrderCode { get; set; }
        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }
        public List<OrderItemInput> Items { get; set; }

        public Order ToEntity()
        {
            return new Order(OrderCode, CustomerName, CustomerEmail, Items.Select(i => new OrderItem(i.ProductId, i.ProductName, i.UnitPrice, i.Quantity)).ToList());
        }
    }

    public class OrderItemInput
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
    }
}
