using System;

namespace EcommerceServerless.App.Models
{
    public class PaymentReceipt
    {
        public string id { get; set; }
        public int orderId { get; set; }
        public DateTime paidAt { get; set; }
    }
}
