using Microsoft.Extensions.DependencyInjection;
using Services.Customers.Application.Subscribers;

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