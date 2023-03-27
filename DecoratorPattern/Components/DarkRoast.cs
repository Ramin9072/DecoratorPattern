using DecoratorPattern.Component.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Components
{
    internal class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            Description = "DarkRoast";
        }
        public override double Cost()
        {
            return 2.0;
        }
    }
}
