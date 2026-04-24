using System;

namespace BlazorCleanArch.Domain.Entities
{
    public sealed class WeatherForecast
    {
        public WeatherForecast(DateTime date, int temperatureC, string summary)
        {
            Date = date;
            TemperatureC = temperatureC;
            Summary = summary;
        }

        public DateTime Date { get; }
        public int TemperatureC { get; }
        public string Summary { get; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
    }
}
