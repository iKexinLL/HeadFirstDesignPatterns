using System.Collections;
using HeadFirstDesignPatterns.Ch2.Interfaces;

namespace HeadFirstDesignPatterns.Ch2
{
    public class WeatherData : ISubject
    {
        private ArrayList observers;
        private float temperature;
        private float humidity; // 湿度
        private float pressure;

        public WeatherData()
        {
            observers = new ArrayList();
        }

        /// <summary>
        /// 循环通知观察者
        /// </summary>
        public void NotifyObservers()
        {
            for (int i = 0; i < observers.Count; i++)
            {
                var observser = (IObserver)observers[i];
                observser.Update(temperature, humidity, pressure);
            }
        }

        /// <summary>
        /// 添加订阅者
        /// </summary>
        /// <param name="o"></param>
        public void RegisterObserver(IObserver o)
        {
            observers.Add(o);
        }

        /// <summary>
        /// 移除订阅者
        /// </summary>
        /// <param name="o"></param>
        public void RemoveObserver(IObserver o)
        {
            var i  = observers.IndexOf(o);
            if (i >= 0)
                observers.RemoveAt(i);
        }

        // 当存在变化时,通知观察者
        public void MeasurementsChanged()
        {
            NotifyObservers();
        }

        public void SetMeasurements(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
            MeasurementsChanged();
        }
    }
}