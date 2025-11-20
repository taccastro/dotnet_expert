using Services.Customers.Application.Subscribers;
using Microsoft.Extensions.DependencyInjection;

namespace Services.Customers.Application
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddSubscribers(this IServiceCollection services)
        {
            services.AddHostedService<CustomerCreatedSubscriber>();

            return services;
        }
    }
}