using HeadFirstDesignPatterns.Ch2.Interfaces;

namespace HeadFirstDesignPatterns.Ch2.Displays
{
    public class ThirdPartyDisplay : IDisplayElement, IObserver
    {
        private float temperature;
        private float humidity;
        private float pressure;

        private ISubject weatherData;

        public ThirdPartyDisplay(ISubject weatherData)
        {
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        public void Display()
        {
            System.Console.WriteLine($"Current conditions: {temperature}℃ and humidity is {humidity}" + 
                                    $" and pressure is {pressure}" );
        }

        public void Update(float temp, float humidity, float pressure)
        {
            this.temperature = temp;
            this.humidity = humidity;
            this.pressure = pressure;
            Display();
        }
    }
}