﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    interface IConsoleWriter
    {
        void LogMessage(string message);
    }
}
