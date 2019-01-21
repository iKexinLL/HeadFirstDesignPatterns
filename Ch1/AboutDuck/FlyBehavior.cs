namespace HeadFirstDesignPatterns.AboutDuck.Ch1st
{
    public interface IFlyBehavior
    {
        void Fly();
    }

    public class FlyWithWings : IFlyBehavior
    {
        public void Fly()
        {
            System.Console.WriteLine("I am flying with wings");
        }
    }

    public class FlyNoWay : IFlyBehavior
    {
        public void Fly()
        {
            System.Console.WriteLine("I cannot fly");
        }
    }

    public class FlyLikeRocket : IFlyBehavior
    {
        public void Fly()
        {
            System.Console.WriteLine("I am flying like a rocket");
        }
    }
}