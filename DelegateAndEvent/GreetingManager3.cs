using System;

namespace HeadFirstDesignPatterns.DelegateAndEvent
{
    public delegate void GreetingManager3EventHandler(string name);

    public class GreetingManager3
    {
        public event GreetingManager3EventHandler MakeGreet = delegate {};

        
       private static void EnglishGreeting(string name) {
           Console.WriteLine("Morning, " + name);
       }

       private static void ChineseGreeting(string name) {
           Console.WriteLine("早上好, " + name);
       }        

        /// <summary>
        /// 使用事件调用委托
        /// </summary>
       public static void TestStart()
       {
            GreetingManager3 gm = new GreetingManager3();
            Console.WriteLine("In TestStartGreetingManager3.GreetPeople: ");
            gm.MakeGreet += new GreetingManager3EventHandler(EnglishGreeting);
            gm.MakeGreet += new GreetingManager3EventHandler(ChineseGreeting);
            gm.MakeGreet("qwe");
       }        
    } 

}