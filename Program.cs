using ObserverPattern.Displays;

namespace ObserverPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WeatherData weatherData = new WeatherData();

            CurrentConditionDisplay currentDisplay = new CurrentConditionDisplay(weatherData);
            ForecastDisplay forecastDisplay = new ForecastDisplay(weatherData);
            StatisticsDisplay statisticsDisplay = new StatisticsDisplay(weatherData);

            weatherData.SetMeasurements(26.6f, 65, 1013.1f);
            weatherData.SetMeasurements(27.2f, 70, 1012.5f);
            weatherData.SetMeasurements(28.4f, 90, 1011.3f);

            weatherData.RemoveObserver(currentDisplay);
            weatherData.SetMeasurements(25.3f, 60, 1010.5f);
        }
    }
}