using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorCleanArch.Application.Contracts
{
    public interface IWeatherForecastService
    {
        Task<IEnumerable<WeatherForecastDto>> GetForecastsAsync();
    }
}
