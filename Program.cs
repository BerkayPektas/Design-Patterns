using DecoratorPattern.Beverages;
using DecoratorPattern.Condiments;

namespace DecoratorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Beverage espresso = new EspressoBeverage();
            Console.WriteLine($"Beverage: espresso");
            espresso.Size = Size.TALL;
            PrintBeverage(espresso);
            Console.WriteLine();

            Beverage doppio = new EspressoBeverage();
            Console.WriteLine($"Beverage: doppio");
            doppio.Size = Size.GRANDE;
            doppio = new Espresso(doppio);
            PrintBeverage(doppio);
            Console.WriteLine();

            Beverage lungo = new EspressoBeverage();
            Console.WriteLine($"Beverage: lungo");
            lungo.Size = Size.VENDI;
            lungo = new WaterCondiments(lungo);
            PrintBeverage(lungo);
            Console.WriteLine();

            Beverage macchiato = new EspressoBeverage();
            Console.WriteLine($"Beverage: macchiato");
            macchiato.Size = Size.TALL;
            macchiato = new MilkFoam(macchiato);
            PrintBeverage(macchiato);
            Console.WriteLine();

            Beverage corretta = new EspressoBeverage();
            Console.WriteLine($"Beverage: corretta");
            corretta.Size = Size.GRANDE;
            corretta = new Liquor(corretta);
            PrintBeverage(corretta);
            Console.WriteLine();

            Beverage conpanna = new EspressoBeverage();
            Console.WriteLine($"Beverage: conpanna");
            conpanna.Size = Size.VENDI;
            conpanna = new Whip(conpanna);
            PrintBeverage(conpanna);
            Console.WriteLine();

            Beverage cappucinno = new EspressoBeverage();
            Console.WriteLine($"Beverage: cappucinno");
            cappucinno.Size = Size.GRANDE;
            cappucinno = new SteamedMilk(cappucinno);
            cappucinno = new MilkFoam(cappucinno);
            PrintBeverage(cappucinno);
            Console.WriteLine();

            Beverage americano = new EspressoBeverage();
            Console.WriteLine($"Beverage: americano");
            americano.Size = Size.TALL;
            americano = new WaterCondiments(americano);
            americano = new WaterCondiments(americano);
            PrintBeverage(americano);
            Console.WriteLine();

            Beverage cafelatte = new EspressoBeverage();
            Console.WriteLine($"Beverage: cafelatte");
            cafelatte.Size = Size.TALL;
            cafelatte = new SteamedMilk(cafelatte);
            cafelatte = new SteamedMilk(cafelatte);
            cafelatte = new MilkFoam(cafelatte);
            PrintBeverage(cafelatte);
            Console.WriteLine();

            Beverage flatwhite = new EspressoBeverage();
            Console.WriteLine($"Beverage: flatwhite");
            flatwhite.Size = Size.VENDI;
            flatwhite = new SteamedMilk(flatwhite);
            flatwhite = new SteamedMilk(flatwhite);
            PrintBeverage(flatwhite);
            Console.WriteLine();

            Beverage romana = new EspressoBeverage();
            Console.WriteLine($"Beverage: romana");
            romana.Size = Size.GRANDE;
            romana = new Lemon(romana);
            PrintBeverage(romana);
            Console.WriteLine();

            Beverage morochinno = new EspressoBeverage();
            Console.WriteLine($"Beverage: morochinno");
            morochinno.Size = Size.TALL;
            morochinno = new Chocolade(morochinno);
            morochinno = new MilkFoam(morochinno);
            PrintBeverage(morochinno);
            Console.WriteLine();

            Beverage mocha = new EspressoBeverage();
            Console.WriteLine($"Beverage: mocha");
            mocha.Size = Size.GRANDE;
            mocha = new Chocolade(mocha);
            mocha = new SteamedMilk(mocha);
            mocha = new Whip(mocha);
            PrintBeverage(mocha);
            Console.WriteLine();

            Beverage bicerin = new EspressoBeverage();
            Console.WriteLine($"Beverage: bicerin");
            bicerin.Size = Size.VENDI;
            bicerin = new BlackChocolate(bicerin);
            bicerin = new WhiteChocolate(bicerin);
            bicerin = new Whip(bicerin);
            PrintBeverage(bicerin);
            Console.WriteLine();

            Beverage breve = new EspressoBeverage();
            Console.WriteLine($"Beverage: breve");
            breve.Size = Size.GRANDE;
            breve = new MilkFoam(breve);
            breve = new HalfMilk(breve);
            PrintBeverage(breve);
            Console.WriteLine();

            Beverage rafcoffee = new EspressoBeverage();
            Console.WriteLine($"Beverage: rafcoffee");
            rafcoffee.Size = Size.TALL;
            rafcoffee = new VanillaSugar(rafcoffee);
            rafcoffee = new Cream(rafcoffee);
            PrintBeverage(rafcoffee);
            Console.WriteLine();

            Beverage meadraf = new EspressoBeverage();
            Console.WriteLine($"Beverage: meadraf");
            meadraf.Size = Size.GRANDE;
            meadraf = new Honey(meadraf);
            meadraf = new Cream(meadraf);
            PrintBeverage(meadraf);
            Console.WriteLine();

            Beverage galeo = new EspressoBeverage();
            Console.WriteLine($"Beverage: galeo");
            galeo.Size = Size.VENDI;
            galeo = new MilkFoam(galeo);
            galeo = new MilkFoam(galeo);
            PrintBeverage(galeo);
            Console.WriteLine();

            Beverage caffeaffogato = new EspressoBeverage();
            Console.WriteLine($"Beverage: caffeaffogato");
            caffeaffogato.Size = Size.TALL;
            caffeaffogato = new Espresso(caffeaffogato);
            caffeaffogato = new IceCream(caffeaffogato);
            PrintBeverage(caffeaffogato);
            Console.WriteLine();

            Beverage viennacoffee = new EspressoBeverage();
            Console.WriteLine($"Beverage: viennacoffee");
            viennacoffee.Size = Size.GRANDE;
            viennacoffee = new Espresso(viennacoffee);
            viennacoffee = new Espresso(viennacoffee);
            viennacoffee = new Whip(viennacoffee);
            viennacoffee = new Whip(viennacoffee);
            PrintBeverage(viennacoffee);
            Console.WriteLine();

            Beverage glace = new EspressoBeverage();
            Console.WriteLine($"Beverage: glace");
            glace.Size = Size.VENDI;
            glace = new Espresso(glace);
            glace = new Espresso(glace);
            glace = new Whip(glace);
            glace = new Whip(glace);
            PrintBeverage(glace);
            Console.WriteLine();

            Beverage chocolatemilk = new ChocoladeBeverage();
            Console.WriteLine($"Beverage: chocolatemilk");
            chocolatemilk.Size = Size.TALL;
            chocolatemilk = new Milk(chocolatemilk);
            chocolatemilk = new Milk(chocolatemilk);
            PrintBeverage(chocolatemilk);
            Console.WriteLine();

            Beverage demicreme = new EspressoBeverage();
            Console.WriteLine($"Beverage: demicreme");
            demicreme.Size = Size.VENDI;
            demicreme = new Espresso(demicreme);
            demicreme = new Cream(demicreme);
            demicreme = new Cream(demicreme);
            PrintBeverage(demicreme);
            Console.WriteLine();

            Beverage lattemacchiato = new EspressoBeverage();
            Console.WriteLine($"Beverage: lattemacchiato");
            lattemacchiato.Size = Size.GRANDE;
            lattemacchiato = new SteamedMilk(lattemacchiato);
            lattemacchiato = new SteamedMilk(lattemacchiato);
            lattemacchiato = new MilkFoam(lattemacchiato);
            PrintBeverage(lattemacchiato);
            Console.WriteLine();

            Beverage freddo = new EspressoBeverage();
            Console.WriteLine($"Beverage: freddo");
            freddo.Size = Size.VENDI;
            freddo = new Liquor(freddo);
            freddo = new Ice(freddo);
            PrintBeverage(freddo);
            Console.WriteLine();

            Beverage frappuccino = new EspressoBeverage();
            Console.WriteLine($"Beverage: frappuccino");
            frappuccino.Size = Size.TALL;
            frappuccino = new Ice(frappuccino);
            frappuccino = new SteamedMilk(frappuccino);
            frappuccino = new MilkFoam(frappuccino);
            PrintBeverage(frappuccino);
            Console.WriteLine();

            Beverage caramelfrappuccino = new EspressoBeverage();
            Console.WriteLine($"Beverage: caramelfrappuccino");
            caramelfrappuccino.Size = Size.GRANDE;
            caramelfrappuccino = new Ice(caramelfrappuccino);
            caramelfrappuccino = new SteamedMilk(caramelfrappuccino);
            caramelfrappuccino = new Cream(caramelfrappuccino);
            caramelfrappuccino = new Syrup(caramelfrappuccino);
            PrintBeverage(caramelfrappuccino);
            Console.WriteLine();

            Beverage frappe = new EspressoBeverage();
            Console.WriteLine($"Beverage: frappe");
            frappe.Size = Size.TALL;
            frappe = new SteamedMilk(frappe);
            frappe = new SteamedMilk(frappe);
            frappe = new IceCream(frappe);
            PrintBeverage(frappe);
            Console.WriteLine();

            Beverage irishcoffee = new EspressoBeverage();
            Console.WriteLine($"Beverage: irishcoffee");
            irishcoffee.Size = Size.VENDI;
            irishcoffee = new Espresso(irishcoffee);
            irishcoffee = new Whiskey(irishcoffee);
            irishcoffee = new Whip(irishcoffee);
            PrintBeverage(irishcoffee);
            Console.WriteLine();
        }
    

        static void PrintBeverage(Beverage beverage)
        {
            Console.WriteLine(beverage.Size + " " + beverage.GetDescription() + " $" +   beverage.cost().ToString("#.##"));
        }
    }
}