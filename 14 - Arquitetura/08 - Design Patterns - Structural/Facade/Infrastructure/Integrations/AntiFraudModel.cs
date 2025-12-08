namespace Patterns.API.Infrastructure.Integrations
{
    public class AntiFraudModel
    {
        public string Document { get; set; }
        public decimal TotalAmount { get; set; }

        public AntiFraudModel(string document, decimal totalAmount)
        {
            Document = document;
            TotalAmount = totalAmount;
        }
    }
}
