using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern.Iterator
{
    interface IIterator
    {
        public void First(); //sets current index to first index
        public string Next(); //Advances current to next element
        public bool IsDone(); //Checks if end of collection is reached
        public string CurrentItem(); //Returns current element
    }
}
