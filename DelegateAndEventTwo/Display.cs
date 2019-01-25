using System;

namespace HeadFirstDesignPatterns.DelegateAndEventTwo
{
    public class Display
    {
        public static void ShowMsg(Heater sender, Heater.BoiledEventArgs e)
        {   
            //静态方法
            Heater heater = sender;
            // Console.WriteLine("Display：{0} - {1}: ", heater.Area, heater.Type);
            Console.WriteLine("Display：水快烧开了，当前温度：{0}度。", e.eventTemperature);
        }
    }
}