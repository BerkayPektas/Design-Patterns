﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Beverages
{
    internal class ChocoladeBeverage : Beverage
    {
        public ChocoladeBeverage(Beverage beverage = null)
        {
            description = "Chocolade";
            this.baseBeverage = beverage;

        }
        public override string GetDescription()
        {
            if (baseBeverage != null)
            {
                return baseBeverage.GetDescription() + ", " + description;
            }
            return description;
        }
        public override double cost()
        {
            if (baseBeverage != null)
            {
                return 1.99 + baseBeverage.cost();
            }
            return 1.99;
        }
    }
}