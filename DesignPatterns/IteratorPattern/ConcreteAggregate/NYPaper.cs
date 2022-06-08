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
    class NYPaper : INewspaper
    {

        public List<string> _reporters;
        public NYPaper()
        {
            _reporters = new List<string>{ "Ram", "Uma", "Jazz", "Rae" };
        }
        public IIterator CreateIterator()
        {
            return new NYPaperIterator(_reporters);
        }
    }
}
