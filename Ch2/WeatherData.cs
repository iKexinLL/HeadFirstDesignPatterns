using System.Collections;
using System.Collections.Generic;
using HeadFirstDesignPatterns.Ch2.Interfaces;

namespace HeadFirstDesignPatterns.Ch2
{
    public class WeatherData : ISubject
    {
        private List<IObserver> observers;
        private float temperature;
        private float humidity; // 湿度
        private float pressure;

        public WeatherData()
        {
            observers = new List<IObserver>();
        }

        /// <summary>
        /// 循环通知观察者
        /// </summary>
        public void NotifyObservers()
        {
            for (int i = 0; i < observers.Count; i++)
            {
                // 这里面的i是实现IObserver的类
                // 所以实际调用的是对应的类中的update方法
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
            // 调用事件
            NotifyObservers();
        }

        // 调用事件
        public void SetMeasurements(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
            MeasurementsChanged();
        }
    }
}