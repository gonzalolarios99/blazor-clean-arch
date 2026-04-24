using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorCleanArch.Application.Contracts;
using BlazorCleanArch.Application.DTOs;
using BlazorCleanArch.Domain.Interfaces;

namespace BlazorCleanArch.Application.Services
{
    public sealed class WeatherForecastService : IWeatherForecastService
    {
        private readonly IWeatherForecastRepository _repository;

        public WeatherForecastService(IWeatherForecastRepository repository)
        {
            _repository = repository;
        }

        public Task<IEnumerable<WeatherForecastDto>> GetForecastsAsync()
        {
            var forecasts = _repository.GetForecasts()
                .Select(item => new WeatherForecastDto
                {
                    Date = item.Date,
                    TemperatureC = item.TemperatureC,
                    Summary = item.Summary
                });

            return Task.FromResult(forecasts);
        }
    }
}
