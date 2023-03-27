namespace LibraryDecorator.Decorators
{
    public class ConcreteDecoratorA : Decorator
    {
        public override void Operation()
        {
            base.Operation();
            Console.WriteLine("ConcreteDecoratorA.Operation()");
        }
    }

    public class ConcreteDecoratorB : Decorator {

        public override void Operation()
        {
            base.Operation();
            Console.WriteLine("ConcreteDecorator2.Operation()");

            void AddedBehavior()
            {
            }
        }
    }
}
