using System;

namespace HeadFirstDesignPatterns.DelegateAndEvent
{
    public delegate void GreetingManager2EventHandler(string name);

    public class GreetingManager2
    {
        public GreetingManager2EventHandler delgeate1;
        public void GreetPeople(string name, GreetingManager2EventHandler onGreetingManager2)
        {
            onGreetingManager2(name);
        }

        public void GreetPeople2(string name)
        {
            if (delgeate1 != null)
                delgeate1(name);
        }
    }

    public class GreetingManager2
    {
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
            GreetingManager2 gm = new GreetingManager2();
            Console.WriteLine("In TestStartGreetingManager2.GreetPeople: ");
            gm.GreetPeople("Jimmy Zhang", EnglishGreeting);
            gm.GreetPeople("张子阳", ChineseGreeting);
            Console.WriteLine("In TestStartGreetingManager2.GreetPeople2: ");
            gm.delgeate1 += EnglishGreeting;
            gm.delgeate1 += ChineseGreeting;
            gm.GreetPeople2("QWE");
            // Console.Ready();
       }        
    } 

}