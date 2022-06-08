using DecoratorPattern.Component;
using DecoratorPattern.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.ConcreteDecorator
{
    class Navigation : CarDecorator
    {

        public Navigation(Car car) : base(car)
        {
            Description = "Navigation";
        }
        public override string GetCarDescription()
        {
            return $"{_car.GetCarDescription()}, {Description}";
        }
        public override double GetCarPrice()
        {
            return _car.GetCarPrice() + 5000;
        }
    }
}
