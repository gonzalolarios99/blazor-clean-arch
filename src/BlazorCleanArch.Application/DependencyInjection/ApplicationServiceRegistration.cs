using BlazorCleanArch.Application.Contracts;
using BlazorCleanArch.Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace BlazorCleanArch.Application.DependencyInjection
{
    public static class ApplicationServiceRegistration
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IWeatherForecastService, WeatherForecastService>();
            return services;
        }
    }
}
