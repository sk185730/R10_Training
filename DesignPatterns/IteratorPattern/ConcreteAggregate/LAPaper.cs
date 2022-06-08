using IteratorPattern.Aggregate;
using IteratorPattern.ConcreteIterator;
using IteratorPattern.Iterator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern.ConcreteAggregate
{
    class LAPaper : INewspaper
    {

        public string[] _reporters;
        public LAPaper()
        {
            _reporters = new[] {"Sri", "Tejaswini", "Alex", "Kevin" };
        }
        public IIterator CreateIterator()
        {
            return new LAPaperIterator(_reporters);
        }
    }
}
