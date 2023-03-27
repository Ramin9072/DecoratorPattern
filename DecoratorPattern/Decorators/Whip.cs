using DecoratorPattern.Component.Abstraction;
using DecoratorPattern.Decorator.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Decorators
{
    public class Whip : CondimentDecorator
    {
        private readonly Beverage _beverage;

        public Whip(Beverage beverage)
        {
            _beverage = beverage;
        }

        public override string Description => _beverage.Description + " ** Whip ** ";

        public override double Cost() => _beverage.Cost() + .60;
    }
}
