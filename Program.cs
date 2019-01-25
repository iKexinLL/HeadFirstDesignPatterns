using HeadFirstDesignPatterns.AboutDuck.Ch1;
using HeadFirstDesignPatterns.Ch2;
using HeadFirstDesignPatterns.Ch2.Displays;
using HeadFirstDesignPatterns.DelegateAndEvent;
using HeadFirstDesignPatterns.DelegateAndEventTwo;

namespace HeadFirstDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            // Test_1();
            // Test_2();
            // TestGreetingManager()

            DelegateAndEventTwo();
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
            WeatherData.TestStart();
        }
    
        public static void TestGreetingManager()
        {
            GreetingManager.TestStart();
            GreetingManager2.TestStart();
            GreetingManager3.TestStart();            
        }
    
        public static void DelegateAndEventTwo()
        {
            Heater.TestStart();
        }
    }
}
