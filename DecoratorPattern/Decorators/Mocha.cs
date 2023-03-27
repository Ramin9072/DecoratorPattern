using DecoratorPattern.Component.Abstraction;
using DecoratorPattern.Decorator.Abstraction;

namespace DecoratorPattern.Decorator
{
    // نوع چاشنی

    public class Mocha : CondimentDecorator
    {
        private readonly Beverage _beverage;

        public override string Description => _beverage.Description + " ** Mocha ** ";

        public Mocha(Beverage beverage)
        {
            _beverage = beverage;
        }

        public override double Cost()
        {
            return _beverage.Cost() + .20;
        }


    }
}
