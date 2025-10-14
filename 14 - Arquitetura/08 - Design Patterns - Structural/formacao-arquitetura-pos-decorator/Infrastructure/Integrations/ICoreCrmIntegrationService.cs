using AwesomeShopPatterns.API.Application.Models;

namespace AwesomeShopPatterns.API.Infrastructure.Integrations
{
    public interface ICoreCrmIntegrationService
    {
        void Sync(OrderInputModel model);
    }
}