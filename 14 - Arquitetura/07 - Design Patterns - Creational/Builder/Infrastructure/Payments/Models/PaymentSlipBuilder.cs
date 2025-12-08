namespace AwesomeShopPatterns.API.Infrastructure.Payments.Models
{
    public class PaymentSlipBuilder
    {
        private readonly PaymentSlipModel _paymentSlip = new();

        public PaymentSlipBuilder WithPayer(string payer)
        {
            _paymentSlip.Payer = payer;
            return this;
        }

        public PaymentSlipBuilder WithAmount(decimal amount)
        {
            _paymentSlip.Amount = amount;
            return this;
        }

        public PaymentSlipBuilder WithDueDate(DateTime dueDate)
        {
            _paymentSlip.DueDate = dueDate;
            return this;
        }

        public PaymentSlipModel Build()
        {
            _paymentSlip.BarCode = $"34191.79001 {new Random().Next(10000, 99999)} 12345.678901 2 12340000015000";
            _paymentSlip.GeneratedAt = DateTime.Now;
            return _paymentSlip;
        }
    }
}
