using DecoratorPattern.Component.Abstraction;

namespace DecoratorPattern
{
    // نوع قهوه معمولی
    public class Espresso : Beverage
    {
        public Espresso()
        {
            Description = "Espresso";
        }

        public override double Cost()
        {
            // Computed Cost for Espresso
            return 1.99;
        }
    }
}
