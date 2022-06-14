﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    class SingletonDemo : ISingletonDemo
    {
        public SingletonDemo()
        {
            ObjectId = Guid.NewGuid();
        }
        public Guid ObjectId { get; }
    }
}
