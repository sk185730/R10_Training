using DecoratorPattern.Decorator;
using DecoratorPattern.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.ConcreteDecorator
{
    class LeatherSeats : CarDecorator
    {
        public LeatherSeats(Car car) : base(car)
        {
            Description = "Leather seats";
        }
        public override string GetCarDescription()
        {
            return $"{_car.GetCarDescription()}, {Description}";
        }
        public override double GetCarPrice()
        {
            return _car.GetCarPrice() + 2500;
        }
    }
}
