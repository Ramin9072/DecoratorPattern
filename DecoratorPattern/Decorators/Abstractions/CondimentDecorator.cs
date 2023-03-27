using DecoratorPattern.Component.Abstraction;

namespace DecoratorPattern.Decorator.Abstraction
{
    //Condiment چاشنی
    public abstract class CondimentDecorator : Beverage
    {
        public abstract override string Description { get; }
    }
}
