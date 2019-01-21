namespace HeadFirstDesignPatterns.AboutDuck.Ch1
{
    public class ReadHeadDuck : Duck
    {
        /// <summary>
        /// 实现父类的abstract方法
        /// </summary>
        public override void Display()
        {
            System.Console.WriteLine("I am ReadHeadDuck");
        }
    }
}