using System;
using HeadFirstDesignPatterns.AboutDuck.Ch1st;

namespace HeadFirstDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Test_1();
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
    }
}
