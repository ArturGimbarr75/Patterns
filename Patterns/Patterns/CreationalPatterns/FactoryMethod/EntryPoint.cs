using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.CreationalPatterns.FactoryMethod
{
    static class EntryPoint
    {
        public static void TestPattern()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Factory method\n");
            Console.ResetColor();

            IFactory mcdonalds = new McDonaldsFactory();
            IFactory hesburger = new HesburgerFactory();

            mcdonalds.CookBurger().UseFood();
            mcdonalds.CookDrink().UseFood();
            mcdonalds.CookFrenchFries().UseFood();

            Console.WriteLine();

            hesburger.CookBurger().UseFood();
            hesburger.CookDrink().UseFood();
            hesburger.CookFrenchFries().UseFood();
        }
    }
}
