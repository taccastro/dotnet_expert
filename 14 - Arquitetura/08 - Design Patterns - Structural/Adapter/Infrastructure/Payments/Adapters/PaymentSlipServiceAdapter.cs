using AwesomeShopPatterns.API.Application.Models;
using AwesomeShopPatterns.API.Infrastructure.Payments.Models;

namespace AwesomeShopPatterns.API.Infrastructure.Payments.Adapters
{
    public class PaymentSlipServiceAdapter
    {
        private readonly IExternalPaymentSlipService _externalService;

        public PaymentSlipServiceAdapter(IExternalPaymentSlipService externalService)
        {
            _externalService = externalService;
        }

        public PaymentSlipModel GeneratePaymentSlip(OrderInputModel model)
        {
            // Chama o serviço externo e obtém o modelo de boleto externo
            var externalModel = _externalService.GeneratePaymentSlip(model);

            // Cria o modelo interno usando o Adapter
            var paymentSlipModel = new PaymentSlipModel(
                externalModel.bar_code,
                externalModel.number,
                externalModel.exp_date,
                externalModel.proc_date,
                externalModel.doc_amount,
                new Payer(
                    externalModel.payer_name,
                    externalModel.payer_doc,
                    externalModel.payer_addr
                ),
                new Receiver(
                    externalModel.receiver_name,
                    externalModel.receiver_doc,
                    externalModel.receiver_addr
                )
            );

            return paymentSlipModel;
        }
    }
}
