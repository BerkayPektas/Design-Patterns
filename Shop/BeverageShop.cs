using DecoratorPattern.Beverages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Shop
{
    internal abstract class BeverageShop
    {
        public virtual Beverage OrderBeverage(string name, Size size)
        {
            Beverage beverage = CreateBeverage(name, size);

            if (beverage == null)
            {
                Console.WriteLine($"Error: Beverage '{name}' is not available.");
                return null;
            }

            return beverage;
        }


        protected abstract Beverage CreateBeverage(string type, Size size);
    }
}

