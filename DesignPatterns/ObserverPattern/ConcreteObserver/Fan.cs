using ObserverPattern.Observer;
using ObserverPattern.Subject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.ConcreteObserver
{
    class Fan : IFan
    {
        public void Update(ICelebrity celebrity)
        {
            Console.WriteLine($"Fan notified \n Celebrity: {celebrity.FullName} \n Tweet: {celebrity.Tweet}");
        }
    }
}
