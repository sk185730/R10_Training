using DecoratorPattern.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.ConcreteComponent
{
    class FullSizeCar : Car
    {
        public FullSizeCar()
        {
            Description = "Full size car";
            Price = 30000;
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
