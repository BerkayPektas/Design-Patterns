﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Interfaces.FlyBehavior
{
    internal class FlyWithWIngs : FlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I'm flying using my wings");
        }
    }
}
