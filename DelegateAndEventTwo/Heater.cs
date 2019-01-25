using System;

namespace HeadFirstDesignPatterns.DelegateAndEventTwo
{
    public class Heater
    {
        private string type = "RealFire 001";
        private string area = "Cc";
        private int temperature;

        private bool showAreaAndType = true;

        public string Type { get => type;}
        public string Area { get => area;}

        // 声明委托
        public delegate void BoiledEventHandler(Heater sender, BoiledEventArgs e);
        public event BoiledEventHandler Boiled;

        // 定义BoiledEventArgs类，传递给Observer所感兴趣的信息
        public class BoiledEventArgs: EventArgs
        {
            public readonly int eventTemperature;
            public BoiledEventArgs(int temperature)
            {
                this.eventTemperature = temperature;
            }
        }

        // 可以供继承自 Heater 的类重写，以便继承类拒绝其他对象对它的监视
        protected virtual void OnBoiled(BoiledEventArgs e) 
        {
            if (showAreaAndType)
            {
                Console.WriteLine("Display：{0} - {1}: ", Area, Type);
                showAreaAndType = false;
            }

            if (Boiled != null)   // 如果有对象注册
                Boiled(this, e);  // 调用所有注册对象的方法
        }

        public void BoiledWater()
        {
            for (int i = 0; i < 100; i++)
            {
                temperature = i;
                if (temperature > 95)
                {
                    BoiledEventArgs e = new BoiledEventArgs(temperature);
                    OnBoiled(e);
                    Console.WriteLine();
                }
            }
        }

        public static void TestStart()
        {
           Heater heater = new Heater();
           Alarm alarm = new Alarm();

           heater.Boiled += alarm.MakeAlert;
           heater.Boiled += Display.ShowMsg;

           heater.BoiledWater();   //烧水，会自动调用注册过对象的方法            
        }
    }
}