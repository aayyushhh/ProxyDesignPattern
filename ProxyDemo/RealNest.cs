﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyDemo
{
    internal class RealNest:INest
    {
        public void Access(string name)
        {
            Console.WriteLine($"{name} has access to the nest");
        }
    }
}
