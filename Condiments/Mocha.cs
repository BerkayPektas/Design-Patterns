﻿using DecoratorPattern.Beverages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Condiments
{
    internal class Mocha : CondimentDecorator
    {
        Beverage beverage;

        public Mocha(Beverage beverage)
        {
            this.beverage = beverage;
            this.Size = beverage.Size;
        }

        public override double cost()
        {
            double extraCost = 0.0;

            switch (beverage.Size)
            {
                case Size.TALL:
                    extraCost = 0.55;
                    break;
                case Size.GRANDE:
                    extraCost = 0.60;
                    break;
                case Size.VENDI:
                    extraCost = 0.65;
                    break;
            }

            return extraCost + beverage.cost();
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", Mocha";
        }
    }
}
