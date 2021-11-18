using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.CreationalPatterns.Builder
{
    class EntryPoint
    {
        public static void TestPattern()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Builder");
            Console.ResetColor();

            Director director = new Director();

            PizzaBuilder pizzaBuilder = new PizzaBuilder();
            PizzaRecipeBuilder pizzaRecipeBuilder = new PizzaRecipeBuilder();

            director.CookHavanaPizza(pizzaBuilder);
            director.CookHavanaPizza(pizzaRecipeBuilder);

            var pizza = pizzaBuilder.GetPizza();
            string recipe = pizzaRecipeBuilder.GetRecipe();

            string res = "Pizza (";
            pizza.ForEach(x => res += x.ToString() + ", ");
            res = res.Substring(0, res.Length - 2) + ")";

            Console.WriteLine(res);
            Console.WriteLine("Recipe -> " + recipe);
        }
    }
}
