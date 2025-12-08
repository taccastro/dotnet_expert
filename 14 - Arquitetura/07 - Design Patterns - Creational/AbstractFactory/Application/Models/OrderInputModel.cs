using Patterns.API.Core.Enums;

namespace Patterns.API.Application.Models
{
    public class OrderInputModel
    {
        public PaymentInfoInputModel PaymentInfo { get; set; }
        public bool? IsInternational { get; set; }
    }


    public class PaymentInfoInputModel
    {
        public PaymentMethod PaymentMethod { get; set; }
        //public string CardNumber { get; set; }
        //public string FullName { get; set; }
        //public string ExpirationDate { get; set; }
        //public string Cvv { get; set; }
    }
}