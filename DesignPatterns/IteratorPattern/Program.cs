using IteratorPattern.Aggregate;
using IteratorPattern.ConcreteAggregate;
using IteratorPattern.Iterator;
using System;

namespace IteratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            INewspaper laPaper = new LAPaper();
            INewspaper nyPaper = new NYPaper();

            IIterator laIterator = laPaper.CreateIterator();
            IIterator nyIterator = nyPaper.CreateIterator();

            Console.WriteLine("LA Paper:");
            PrintReporters(laIterator);

            Console.WriteLine("\nNY Paper:");
            PrintReporters(nyIterator);
        }

        private static void PrintReporters(IIterator iterator)
        {
            iterator.First();
            while (!iterator.IsDone())
            {
                Console.Write(iterator.Next()+" ");
            }
        }
    }
}
