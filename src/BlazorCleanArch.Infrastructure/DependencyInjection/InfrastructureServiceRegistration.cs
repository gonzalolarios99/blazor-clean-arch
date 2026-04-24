using BlazorCleanArch.Domain.Interfaces;
using BlazorCleanArch.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace BlazorCleanArch.Infrastructure.DependencyInjection
{
    public static class InfrastructureServiceRegistration
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
        {
            services.AddSingleton<IWeatherForecastRepository, InMemoryWeatherForecastRepository>();
            return services;
        }
    }
}
