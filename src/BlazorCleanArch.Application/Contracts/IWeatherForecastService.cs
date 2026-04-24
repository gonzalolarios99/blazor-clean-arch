using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorCleanArch.Application.DTOs;

namespace BlazorCleanArch.Application.Contracts
{
    public interface IWeatherForecastService
    {
        Task<IEnumerable<WeatherForecastDto>> GetForecastsAsync();
    }
}
