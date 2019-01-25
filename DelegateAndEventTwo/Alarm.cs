using System;

namespace HeadFirstDesignPatterns.DelegateAndEventTwo
{
    public class Alarm
    {
        public void MakeAlert(Heater sender, Heater.BoiledEventArgs e)
        {
            Heater heater = sender;     //这里是不是很熟悉呢？
            
            //访问 sender 中的公共字段
            // Console.WriteLine("Alarm：{0} - {1}: ", heater.Area, heater.Type);
            Console.WriteLine("Alarm: 嘀嘀嘀，水已经 {0} 度了：", e.eventTemperature);
        }
    }
}