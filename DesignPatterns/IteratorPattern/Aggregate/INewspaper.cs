﻿using IteratorPattern.Iterator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern.Aggregate
{
    interface INewspaper
    {
        IIterator CreateIterator();

    }
}
