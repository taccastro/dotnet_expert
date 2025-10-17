namespace AwesomeShopPatterns.API.Infrastructure.Payments.Models
{
    public class PaymentSlipModel
    {
        public string Payer { get; set; }
        public decimal Amount { get; set; }
        public DateTime DueDate { get; set; }
        public string BarCode { get; set; }
        public DateTime GeneratedAt { get; set; }
    }
}
