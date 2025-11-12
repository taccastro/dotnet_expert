using HexagonalArchitecture.Application.UseCases;
using HexagonalArchitecture.Application.UseCases.AddOrder;
using HexagonalArchitecture.Application.UseCases.GetAllOrders;
using HexagonalArchitecture.Application.UseCases.GetOrderById;
using Microsoft.Extensions.DependencyInjection;

namespace HexagonalArchitecture.Application
{
    public static class ApplicationModule
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services
                .AddUseCases();

            return services;
        }

        private static IServiceCollection AddUseCases(this IServiceCollection services)
        {
            services.AddScoped<IUseCase<NoInput, UseCaseResult<GetAllOrdersOutput>>, GetAllOrdersUseCase>();
            services.AddScoped<IUseCase<int, UseCaseResult<GetOrderByIdOutput>>, GetOrderByIdUseCase>();
            services.AddScoped<IAddOrderUseCase, AddOrderUseCase>();

            return services;
        }
    }
}
