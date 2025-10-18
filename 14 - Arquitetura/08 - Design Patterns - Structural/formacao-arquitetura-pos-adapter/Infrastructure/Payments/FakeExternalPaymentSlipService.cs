using AwesomeShopPatterns.API.Application.Models;
using AwesomeShopPatterns.API.Infrastructure.Payments.Models;
using System;

namespace AwesomeShopPatterns.API.Infrastructure.Payments
{
    public class FakeExternalPaymentSlipService : IExternalPaymentSlipService
    {
        public ExternalPaymentSlipModel GeneratePaymentSlip(OrderInputModel model)
        {
            return new ExternalPaymentSlipModel
            {
                bar_code = "123456789",
                number = "0001",
                exp_date = DateTime.Now.AddDays(7),
                proc_date = DateTime.Now,
                doc_amount = 150.75m,
                payer_name = model.CustomerName,
                payer_doc = model.CustomerDocument,
                payer_addr = model.CustomerAddress,
                receiver_name = "Loja AwesomeShop",
                receiver_doc = "99999999999",
                receiver_addr = "Rua Central, 1000"
            };
        }
    }
}
