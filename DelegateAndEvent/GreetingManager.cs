using System;

namespace HeadFirstDesignPatterns.DelegateAndEvent
{
    public class GreetingManager
    {
        // public delegate 

        /// <summary>
        /// 委托用于调用方法,委托使用EventHandler结尾
        /// </summary>
        /// <param name="name">传递的参数</param>
        public delegate void GreetingManagerEventHandler(string name);
        public static void GreetPeople(string name, GreetingManagerEventHandler testGreetingManager)
        {
            // TestGreetingManager test1 = new TestGreetingManager();
            testGreetingManager(name);
        }

       private static void EnglishGreeting(string name) {
           Console.WriteLine("Morning, " + name);
       }

       private static void ChineseGreeting(string name) {
           Console.WriteLine("早上好, " + name);
       }        

        /// <summary>
        /// 通过委托,调用不同的方法
        /// </summary>
       public static void TestStart()
       {
           // 展现了三种不同的调用委托的方式
            GreetPeople("Jimmy Zhang", EnglishGreeting);
            GreetPeople("张子阳", ChineseGreeting);

            GreetingManagerEventHandler testGreet1, testGreet2;
            testGreet1 = EnglishGreeting;
            testGreet2 = ChineseGreeting;
            GreetPeople("Jimmy Zhang", testGreet1);
            GreetPeople("张子阳", testGreet2);

            GreetingManagerEventHandler testGreet3;
            testGreet3 = EnglishGreeting;
            testGreet3 += ChineseGreeting;
            GreetPeople("Jimmy Zhang", testGreet3);
            
            // Console.Ready();
       }
    }
}