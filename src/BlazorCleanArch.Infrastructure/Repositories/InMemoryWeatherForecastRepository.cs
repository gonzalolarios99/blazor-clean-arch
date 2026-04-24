using System;
using System.Collections.Generic;
using BlazorCleanArch.Domain.Entities;
using BlazorCleanArch.Domain.Interfaces;

namespace BlazorCleanArch.Infrastructure.Repositories
{
    public sealed class InMemoryWeatherForecastRepository : IWeatherForecastRepository
    {
        public IEnumerable<WeatherForecast> GetForecasts()
        {
            return new[]
            {
                new WeatherForecast(DateTime.Today, 18, "Parcialmente nublado"),
                new WeatherForecast(DateTime.Today.AddDays(1), 22, "Soleado"),
                new WeatherForecast(DateTime.Today.AddDays(2), 16, "Lluvias ligeras"),
            };
        }
    }
}
