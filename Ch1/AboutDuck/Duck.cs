using System;

namespace HeadFirstDesignPatterns.AboutDuck.Ch1st
{
    public abstract class Duck
    {
        
        // 以下为扩展属性

        // 添加飞行的属性,默认访问属性为 internal,所以需要修改为 protected
        protected IFlyBehavior flyBehavior;
        
        protected IQuackBehavior quackBehavior;

        public void SetFlyBehavior(IFlyBehavior flyBehavior)
        {
            this.flyBehavior = flyBehavior;
        }

        //  以下为共有属性
        public void Quack() { }        

        public void Swim() { }

        public abstract void Display();

        public void PerformFly()
        {
            flyBehavior.Fly();
        }

        public void PerformQuack()
        {
            quackBehavior.Quack();
        }
    }
}