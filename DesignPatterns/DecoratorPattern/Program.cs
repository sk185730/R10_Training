using DecoratorPattern.Component;
using DecoratorPattern.ConcreteComponent;
using DecoratorPattern.ConcreteDecorator;
using System;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Car aCar = new CompactCar();
            aCar = new LeatherSeats(aCar);
            aCar = new Navigation(aCar);
            Console.WriteLine($"Description: {aCar.GetCarDescription()}");
            Console.WriteLine($"Price: {aCar.GetCarPrice()}");
        }
    }
}
