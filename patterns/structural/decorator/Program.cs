using System;

namespace decorator
{
    abstract class Component
    {
        public abstract string Operation();
    }

    class RealComponent : Component
    {
        public override string Operation()
        {
            return "hello";
        }
    }

    abstract class Decorator : Component
    {
        protected Component component;
        public void SetComponent(Component component)
        {
            this.component = component;
        }
        public override string Operation()
        {
            if (component != null) {
                return component.Operation();
            }
            return "";
        }
    }

    class DecoratorDiv : Decorator
    {
        public override string Operation()
        {
            return "<div>" + base.Operation() + "</div>";
        }
    }

    class DecoratorBold : Decorator
    {
        public override string Operation()
        {
            return "<b>" + base.Operation() + "</b>";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            RealComponent realComponent = new RealComponent();
            DecoratorDiv decorateDiv = new DecoratorDiv();
            DecoratorBold decorateBold = new DecoratorBold();
            decorateDiv.SetComponent(realComponent);
            decorateBold.SetComponent(realComponent);
            Console.WriteLine(decorateDiv.Operation());
            Console.WriteLine(decorateBold.Operation());
        }
    }
}
