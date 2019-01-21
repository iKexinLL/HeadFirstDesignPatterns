using System;
using HeadFirstDesignPatterns.AboutDuck.Ch1;
using HeadFirstDesignPatterns.Ch2;
using HeadFirstDesignPatterns.Ch2.Displays;

namespace HeadFirstDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            // Test_1();
            Test_2();
        }

        public static void Test_1()
        {
            var mallardDuck = new MallardDuck();
            mallardDuck.Display();
            mallardDuck.PerformFly();
            mallardDuck.SetFlyBehavior(new FlyNoWay());
            mallardDuck.PerformFly();
            mallardDuck.PerformQuack();
            mallardDuck.SetFlyBehavior(new FlyLikeRocket());
            mallardDuck.PerformFly();
        }
    
        public static void Test_2()
        {
            var wd = new WeatherData();
            var currentConditionDisplay = new CurrentConditionDisplay(wd);

            wd.SetMeasurements(20, 30, 40);
            wd.SetMeasurements(50, 60, 80);
            wd.SetMeasurements(20, 30, 40);



        }
    }
}
