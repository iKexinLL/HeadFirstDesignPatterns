using HeadFirstDesignPatterns.Ch2.Interfaces;

namespace HeadFirstDesignPatterns.Ch2.Displays
{
    public class CurrentConditionDisplay : IDisplayElement, IObserver
    {
        private float temperature;
        private float humidity;

        private ISubject weatherData;

        public CurrentConditionDisplay(ISubject weatherData)
        {
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        public void Display()
        {
            System.Console.WriteLine($"Current conditions: {temperature}℃ and humidity is {humidity}" );
        }

        public void Update(float temp, float humidity, float pressure)
        {
            this.temperature = temp;
            this.humidity = humidity;
            Display();
        }
    }
}