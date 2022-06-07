using DecoratorPattern.Component;
using DecoratorPattern.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.ConcreteDecorator
{
    class Sunroof : CarDecorator
    {
        public Sunroof(Car car) : base(car)
        {
            Description = "Sunroof";
        }
        public override string GetCarDescription()
        {
            return $"{_car.GetCarDescription()}, {Description}";
        }
        public override double GetCarPrice()
        {
            return _car.GetCarPrice() + 6000;
        }
    }
}
