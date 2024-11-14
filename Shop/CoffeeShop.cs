using DecoratorPattern.Beverages;
using DecoratorPattern.Condiments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Shop
{
    internal class CoffeeShop : BeverageShop
    {
        protected override Beverage CreateBeverage(string name, Size size)
        {
            Beverage beverage = null;

            switch (name.ToLower())
            {
                case "espresso":
                    beverage = new EspressoBeverage();
                    beverage.Size = size;
                    break;
                case "doppio":
                    beverage = new EspressoBeverage();
                    beverage.Size = size;
                    beverage = new Espresso(beverage);
                    break;

                case "lungo":
                    beverage = new EspressoBeverage();
                    beverage.Size = size;
                    beverage = new WaterCondiments(beverage);
                    break;

                case "macchiato":
                    beverage = new EspressoBeverage();
                    beverage.Size = size;
                    beverage = new MilkFoam(beverage);
                    break;

                case "corretta":
                    beverage = new EspressoBeverage();
                    beverage.Size = size;
                    beverage = new Liquor(beverage);
                    break;

                case "conpanna":
                    beverage = new EspressoBeverage();
                    beverage.Size = size;
                    beverage = new Whip(beverage);
                    break;

                case "cappuccino":
                    beverage = new EspressoBeverage();
                    beverage.Size = size;
                    beverage = new SteamedMilk(beverage);
                    beverage = new MilkFoam(beverage);
                    break;

                case "americano":
                    beverage = new EspressoBeverage();
                    beverage.Size = size;
                    beverage = new WaterCondiments(beverage);
                    beverage = new WaterCondiments(beverage);
                    break;

                case "cafelatte":
                    beverage = new EspressoBeverage();
                    beverage.Size = size;
                    beverage = new SteamedMilk(beverage);
                    beverage = new SteamedMilk(beverage);
                    beverage = new MilkFoam(beverage);
                    break;

                case "flatwhite":
                    beverage = new EspressoBeverage();
                    beverage.Size = size;
                    beverage = new SteamedMilk(beverage);
                    beverage = new SteamedMilk(beverage);
                    break;

                case "romana":
                    beverage = new EspressoBeverage();
                    beverage.Size = size;
                    beverage = new Lemon(beverage);
                    break;

                case "morochinno":
                    beverage = new EspressoBeverage();
                    beverage.Size = size;
                    beverage = new Chocolade(beverage);
                    beverage = new MilkFoam(beverage);
                    break;

                case "mocha":
                    beverage = new EspressoBeverage();
                    beverage.Size = size;
                    beverage = new Chocolade(beverage);
                    beverage = new SteamedMilk(beverage);
                    beverage = new Whip(beverage);
                    break;

                case "bicerin":
                    beverage = new EspressoBeverage();
                    beverage.Size = size;
                    beverage = new BlackChocolate(beverage);
                    beverage = new WhiteChocolate(beverage);
                    beverage = new Whip(beverage);
                    break;

                case "breve":
                    beverage = new EspressoBeverage();
                    beverage.Size = size;
                    beverage = new MilkFoam(beverage);
                    beverage = new HalfMilk(beverage);
                    break;

                case "rafcoffee":
                    beverage = new EspressoBeverage();
                    beverage.Size = size;
                    beverage = new VanillaSugar(beverage);
                    beverage = new Cream(beverage);
                    break;

                case "meadraf":
                    beverage = new EspressoBeverage();
                    beverage.Size = size;
                    beverage = new Honey(beverage);
                    beverage = new Cream(beverage);
                    break;

                case "galeo":
                    beverage = new EspressoBeverage();
                    beverage.Size = size;
                    beverage = new MilkFoam(beverage);
                    beverage = new MilkFoam(beverage);
                    break;

                case "caffeaffogato":
                    beverage = new EspressoBeverage();
                    beverage.Size = size;
                    beverage = new Espresso(beverage);
                    beverage = new IceCream(beverage);
                    break;

                case "viennacoffee":
                    beverage = new EspressoBeverage();
                    beverage.Size = size;
                    beverage = new Espresso(beverage);
                    beverage = new Espresso(beverage);
                    beverage = new Whip(beverage);
                    beverage = new Whip(beverage);
                    break;

                case "glace":
                    beverage = new EspressoBeverage();
                    beverage.Size = size;
                    beverage = new Espresso(beverage);
                    beverage = new Espresso(beverage);
                    beverage = new Whip(beverage);
                    beverage = new Whip(beverage);
                    break;

                case "chocolademilk":
                    beverage = new ChocoladeBeverage();
                    beverage.Size = size;
                    beverage = new Milk(beverage);
                    beverage = new Milk(beverage);
                    break;

                case "demicreme":
                    beverage = new EspressoBeverage();
                    beverage.Size = size;
                    beverage = new Espresso(beverage);
                    beverage = new Cream(beverage);
                    beverage = new Cream(beverage);
                    break;

                case "lattemacchiato":
                    beverage = new EspressoBeverage();
                    beverage.Size = size;
                    beverage = new SteamedMilk(beverage);
                    beverage = new SteamedMilk(beverage);
                    beverage = new MilkFoam(beverage);
                    break;

                case "freddo":
                    beverage = new EspressoBeverage();
                    beverage.Size = size;
                    beverage = new Liquor(beverage);
                    beverage = new Ice(beverage);
                    break;

                case "frappuccino":
                    beverage = new EspressoBeverage();
                    beverage.Size = size;
                    beverage = new Ice(beverage);
                    beverage = new SteamedMilk(beverage);
                    beverage = new MilkFoam(beverage);
                    break;

                case "caramelfrappuccino":
                    beverage = new EspressoBeverage();
                    beverage.Size = size;
                    beverage = new Ice(beverage);
                    beverage = new SteamedMilk(beverage);
                    beverage = new Cream(beverage);
                    beverage = new Syrup(beverage);
                    break;

                case "frappe":
                    beverage = new EspressoBeverage();
                    beverage.Size = size;
                    beverage = new SteamedMilk(beverage);
                    beverage = new SteamedMilk(beverage);
                    beverage = new IceCream(beverage);
                    break;

                case "irishcoffee":
                    beverage = new EspressoBeverage();
                    beverage.Size = size;
                    beverage = new Espresso(beverage);
                    beverage = new Whiskey(beverage);
                    beverage = new Whip(beverage);
                    break;

                default:
                    Console.WriteLine("Beverage not found.");
                    break;

            }
            return beverage;
        }
    }
}
