using LibraryDecorator.Components.Abstracts;


namespace LibraryDecorator.Components
{
    internal class ConcreteComponent : Component
    {
        public override void Operation() => Console.WriteLine("ConcreteComponent.Operation()");
    }
}
