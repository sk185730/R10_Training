using DecoratorPattern.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Decorator
{
    //gives ability to add features 
    class CarDecorator : Car
    {
        protected Car _car;
        public CarDecorator(Car car)
        {
            _car = car;
        }
        public override string GetCarDescription()
        {
            return _car.GetCarDescription();
        }
        public override double GetCarPrice()
        {
            return _car.GetCarPrice();
        }
    }
}
