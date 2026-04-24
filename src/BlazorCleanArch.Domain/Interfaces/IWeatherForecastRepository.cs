using System.Collections.Generic;

namespace BlazorCleanArch.Domain.Interfaces
{
    public interface IWeatherForecastRepository
    {
        IEnumerable<WeatherForecast> GetForecasts();
    }
}
