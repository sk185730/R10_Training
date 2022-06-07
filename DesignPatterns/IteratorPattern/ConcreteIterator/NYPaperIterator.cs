using IteratorPattern.Iterator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern.ConcreteIterator
{
    class NYPaperIterator : IIterator
    {
        private List<string> _reporters;
        private int _currentIndex = 0;

        public NYPaperIterator(List<string> reporters)
        {
            this._reporters = reporters;
            //_current = 0;
        }

        public string CurrentItem()
        {
            return _reporters.ElementAt(_currentIndex);
        }

        public void First()
        {
            _currentIndex = 0;
        }

        public bool IsDone()
        {
            return _currentIndex >= _reporters.Count;
        }

        public string Next()
        {
            return _reporters.ElementAt(_currentIndex++);
        }
    }
}
