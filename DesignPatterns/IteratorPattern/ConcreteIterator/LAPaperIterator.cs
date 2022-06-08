using IteratorPattern.Iterator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern.ConcreteIterator
{
    class LAPaperIterator : IIterator
    {

        private string[] _reporters;
        private int _currentIndex;
        public LAPaperIterator(string[] reporters)
        {
            this._reporters = reporters;
            //_current = 0;
        }

        public string CurrentItem()
        {
            return _reporters[_currentIndex];
        }

        public void First()
        {
            _currentIndex = 0;
        }

        public bool IsDone()
        {
            return _currentIndex >= _reporters.Length;
        }

        public string Next()
        {
            return _reporters[_currentIndex++];
        }
    }
}
