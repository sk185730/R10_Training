using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Component
{
    abstract class Car
    {

        public string Description { get; set; }
        public double Price { get; set; }
        public abstract string GetCarDescription();
        public abstract double GetCarPrice();
    }
}
