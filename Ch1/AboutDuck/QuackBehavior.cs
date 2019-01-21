namespace HeadFirstDesignPatterns.AboutDuck.Ch1st
{
    public interface IQuackBehavior
    {
         void Quack();
    }

    public class QuackNormal : IQuackBehavior
    {
        public void Quack()
        {
            System.Console.WriteLine("Quack,Quack!");
        }
    }

    public class MuteQuack : IQuackBehavior
    {
        public void Quack()
        {
            System.Console.WriteLine("Gua,Gua!");
        }
    }

}