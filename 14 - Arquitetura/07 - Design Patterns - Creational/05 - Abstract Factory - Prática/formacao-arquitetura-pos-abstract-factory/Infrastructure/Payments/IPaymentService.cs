using Patterns.API.Application.Models;

namespace Patterns.API.Infrastructure.Payments
{
    public interface IPaymentService
    {
        object Process(OrderInputModel model);
    }
}