using AbstractFactoryPattern.Shop;
using DecoratorPattern.Beverages;
using DecoratorPattern.Condiments;

namespace DecoratorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CoffeeShop coffeeShop = new CoffeeShop();
            Beverage espresso = coffeeShop.OrderBeverage("espresso", Size.TALL);
            Console.WriteLine($"Beverage: Espresso");
            PrintBeverage(espresso);
            Console.WriteLine();

            Beverage doppio = coffeeShop.OrderBeverage("doppio", Size.GRANDE);
            Console.WriteLine($"Beverage: Doppio");
            PrintBeverage(doppio);
            Console.WriteLine();

            Beverage lungo = coffeeShop.OrderBeverage("lungo", Size.VENDI);
            Console.WriteLine($"Beverage: Lungo");
            PrintBeverage(lungo);
            Console.WriteLine();
;
            Beverage macchiato = coffeeShop.OrderBeverage("macchiato", Size.TALL);
            Console.WriteLine($"Beverage: Macchiato");
            PrintBeverage(macchiato);
            Console.WriteLine();

            Beverage corretta = coffeeShop.OrderBeverage("corretta", Size.GRANDE);
            Console.WriteLine($"Beverage: Corretta");
            PrintBeverage(corretta);
            Console.WriteLine();

            Beverage conpanna = coffeeShop.OrderBeverage("conpanna", Size.VENDI);
            Console.WriteLine($"Beverage: Conpanna");
            PrintBeverage(conpanna);
            Console.WriteLine();

            Beverage cappuccino = coffeeShop.OrderBeverage("cappuccino", Size.GRANDE);
            Console.WriteLine($"Beverage: Cappuccino");
            PrintBeverage(cappuccino);
            Console.WriteLine();

            Beverage americano = coffeeShop.OrderBeverage("americano", Size.TALL);
            Console.WriteLine($"Beverage: Americano");
            PrintBeverage(americano);
            Console.WriteLine();

            Beverage cafeLatte = coffeeShop.OrderBeverage("cafelatte", Size.TALL);
            Console.WriteLine($"Beverage: CafeLatte");
            PrintBeverage(cafeLatte);
            Console.WriteLine();

            Beverage flatwhite = coffeeShop.OrderBeverage("flatwhite", Size.VENDI);
            Console.WriteLine($"Beverage: Flatwhite");
            PrintBeverage(flatwhite);
            Console.WriteLine();

            Beverage romana = coffeeShop.OrderBeverage("romana", Size.GRANDE);
            Console.WriteLine($"Beverage: Romana");
            PrintBeverage(romana);
            Console.WriteLine();

            Beverage morochinno = coffeeShop.OrderBeverage("morochinno", Size.TALL);
            Console.WriteLine($"Beverage: Morochinno");
            PrintBeverage(morochinno);
            Console.WriteLine();

            Beverage mocha = coffeeShop.OrderBeverage("mocha", Size.GRANDE);
            Console.WriteLine($"Beverage: Mocha");
            PrintBeverage(mocha);
            Console.WriteLine();

            Beverage bicerin = coffeeShop.OrderBeverage("bicerin", Size.VENDI);
            Console.WriteLine($"Beverage: Bicerin");
            PrintBeverage(bicerin);
            Console.WriteLine();

            Beverage breve = coffeeShop.OrderBeverage("breve", Size.GRANDE);
            Console.WriteLine($"Beverage: Breve");
            PrintBeverage(breve);
            Console.WriteLine();

            Beverage rafcoffee = coffeeShop.OrderBeverage("rafcoffee", Size.TALL);
            Console.WriteLine($"Beverage: Rafcoffee");
            PrintBeverage(rafcoffee);
            Console.WriteLine();

            Beverage meadraf = coffeeShop.OrderBeverage("meadraf", Size.GRANDE);
            Console.WriteLine($"Beverage: Meadraf");
            PrintBeverage(meadraf);
            Console.WriteLine();

            Beverage galeo = coffeeShop.OrderBeverage("galeo", Size.VENDI);
            Console.WriteLine($"Beverage: Galeo");
            PrintBeverage(galeo);
            Console.WriteLine();

            Beverage caffeaffogato = coffeeShop.OrderBeverage("caffeaffogato", Size.TALL);
            Console.WriteLine($"Beverage: Caffeaffogato");
            PrintBeverage(caffeaffogato);
            Console.WriteLine();

            Beverage viennacoffee = coffeeShop.OrderBeverage("viennacoffee", Size.GRANDE);
            Console.WriteLine($"Beverage: Viennacoffee");
            PrintBeverage(viennacoffee);
            Console.WriteLine();

            Beverage glace = coffeeShop.OrderBeverage("glace", Size.VENDI);
            Console.WriteLine($"Beverage: Glace");
            PrintBeverage(glace);
            Console.WriteLine();

            Beverage chocolademilk = coffeeShop.OrderBeverage("chocolademilk", Size.TALL);
            Console.WriteLine($"Beverage: Chocolademilk");
            PrintBeverage(chocolademilk);
            Console.WriteLine();

            Beverage demicreme = coffeeShop.OrderBeverage("demicreme", Size.VENDI);
            Console.WriteLine($"Beverage: Demicreme");
            PrintBeverage(demicreme);
            Console.WriteLine();

            Beverage lattemacchiato = coffeeShop.OrderBeverage("lattemacchiato", Size.GRANDE);
            Console.WriteLine($"Beverage: Lattemacchiato");
            PrintBeverage(lattemacchiato);
            Console.WriteLine();

            Beverage freddo = coffeeShop.OrderBeverage("freddo", Size.VENDI);
            Console.WriteLine($"Beverage: Freddo");
            PrintBeverage(freddo);
            Console.WriteLine();

            Beverage frappuccino = coffeeShop.OrderBeverage("frappuccino", Size.TALL);
            Console.WriteLine($"Beverage: Frappuccino");
            PrintBeverage(frappuccino);
            Console.WriteLine();

            Beverage caramelfrappuccino = coffeeShop.OrderBeverage("caramelfrappuccino", Size.GRANDE);
            Console.WriteLine($"Beverage: Caramelfrappuccino");
            PrintBeverage(caramelfrappuccino);
            Console.WriteLine();

            Beverage frappe = coffeeShop.OrderBeverage("frappe", Size.TALL);
            Console.WriteLine($"Beverage: Frappe");
            PrintBeverage(frappe);
            Console.WriteLine();

            Beverage irishcoffee = coffeeShop.OrderBeverage("irishcoffee", Size.VENDI);
            Console.WriteLine($"Beverage: Irishcoffee");
            PrintBeverage(irishcoffee);
            Console.WriteLine();

        }
    
        static void PrintBeverage(Beverage beverage)
        {
            Console.WriteLine(beverage.Size + " " + beverage.GetDescription() + " $" +   beverage.cost().ToString("#.##"));
        }
    }
}