using DecoratorPattern.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.ConcreteComponent
{
    class CompactCar: Car
    {
        public CompactCar()
        {
            Description = "Compact car";
            Price = 10000;
        }
        public override string GetCarDescription()
        {
            return Description;
        }
        public override double GetCarPrice()
        {
            return Price;
        }
    }
}
