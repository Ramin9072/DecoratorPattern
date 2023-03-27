using DecoratorPattern.Component.Abstraction;

namespace DecoratorPattern
{
    public class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            Description = "House Blend Coffe";
        }
        public override double Cost()
        {
            // Computed Cost for Espresso
            return 0.80;
        }
    }
}
