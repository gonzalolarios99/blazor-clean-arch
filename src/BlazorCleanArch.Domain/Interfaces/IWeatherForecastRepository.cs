using System.Collections.Generic;
using BlazorCleanArch.Domain.Entities;

namespace BlazorCleanArch.Domain.Interfaces
{
    public interface IWeatherForecastRepository
    {
        IEnumerable<WeatherForecast> GetForecasts();
    }
}
