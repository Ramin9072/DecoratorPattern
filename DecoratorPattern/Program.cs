
using DecoratorPattern;
using DecoratorPattern.Component.Abstraction;
using DecoratorPattern.Components;
using DecoratorPattern.Decorator;
using DecoratorPattern.Decorators;

internal class Program
{
    private static void Main(string[] args)
    {
        Beverage espresso = new Espresso();
        Console.WriteLine(espresso.Description + " Your Cost" + espresso.Cost() + "$") ;

        Beverage beverage2 = new HouseBlend();
        beverage2 = new Mocha(beverage2);
        beverage2 = new Soy(beverage2);
        beverage2 = new Whip(beverage2);

        Beverage beverage3 = new DarkRoast();
        beverage3 = new Mocha(beverage3);
        beverage3 = new Whip(beverage3);

        Console.WriteLine("------------------------------");
        Console.WriteLine(beverage2.Description + " Your Cost" + beverage2.Cost() + "$");
        Console.WriteLine("------------------------------");
        Console.WriteLine(beverage3.Description + " Your Cost" + beverage3.Cost() + "$");

       Console.ReadLine();
    }
}