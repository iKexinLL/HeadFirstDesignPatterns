namespace HeadFirstDesignPatterns.AboutDuck.Ch1
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            flyBehavior = new FlyWithWings();
            quackBehavior = new MuteQuack();
        }

        /// <summary>
        /// 实现父类的abstract方法
        /// </summary>
        public override void Display()
        {
            System.Console.WriteLine("I am MallardDuck");
        }
    }
}