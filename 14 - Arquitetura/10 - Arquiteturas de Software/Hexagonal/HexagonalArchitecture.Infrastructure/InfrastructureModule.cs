using HexagonalArchitecture.Domain.Repositories;
using HexagonalArchitecture.Infrastructure.Persistence.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace HexagonalArchitecture.Infrastructure
{
    public static class InfrastructureModule
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services
                .AddRepositories();

            return services;
        }

        private static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            // Registra a implementação concreta do adapter de persistência
            services.AddScoped<IOrderRepository, OrderRepository>();

            return services;
        }
    }
}
