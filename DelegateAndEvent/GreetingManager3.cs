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
        /// 通过委托,调用不同的方法
        /// </summary>
       public static void TestStart()
       {
            GreetingManager3 gm = new GreetingManager3();
            Console.WriteLine("In TestStartGreetingManager3.GreetPeople: ");
            gm.MakeGreet += EnglishGreeting(qwe);
            gm.GreetPeople("张子阳", ChineseGreeting);
            Console.WriteLine("In TestStartGreetingManager3.GreetPeople2: ");
            gm.delgeate1 += EnglishGreeting;
            gm.delgeate1 += ChineseGreeting;
            gm.GreetPeople2("QWE");
            // Console.Ready();
       }        
    } 

}