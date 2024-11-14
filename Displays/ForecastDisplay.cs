using ObserverPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Displays
{
    internal class ForecastDisplay : Observer, DisplayElement
    {
        private float currentPressure = 1013f; 
        private float lastPressure;
        private Subject weatherData;

        public ForecastDisplay(Subject weatherData)
        {
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        public void Update(float temp, float humidity, float pressure)
        {
            lastPressure = currentPressure;
            currentPressure = pressure;
            Display();
        }

        public void Display()
        {
            Console.Write("Forecast: ");
            if (currentPressure > lastPressure)
            {
                Console.WriteLine("Mooi weer komt er aan!");
            }
            else if (currentPressure == lastPressure)
            {
                Console.WriteLine("Meer van hetzelfde.");
            }
            else
            {
                Console.WriteLine("Trek je paraplu’s uit de kast!");
            }
        }
    }
}