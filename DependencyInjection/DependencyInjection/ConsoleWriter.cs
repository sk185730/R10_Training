using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    class ConsoleWriter : IConsoleWriter
    {
        readonly ISingletonDemo singletonDemo;
        public ConsoleWriter(ISingletonDemo singletonDemo)
        {
            this.singletonDemo = singletonDemo;
        }
        public void LogMessage(string message)
        {
            Console.WriteLine($"ConsoleWriter.LogMessage:  singletonDemo.ObjectId={singletonDemo.ObjectId}");
            Console.WriteLine(message);
        }
    }
}
