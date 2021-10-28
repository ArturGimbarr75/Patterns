using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.CreationalPatterns.Builder
{
    class PizzaRecipeBuilder : IBuilder
    {
        string Recipe;
        public PizzaRecipeBuilder() => Reset();

        public void AddBacon() => Recipe += "add Bacon, then ";
        public void AddCheese() => Recipe += "add Cheese, then ";
        public void AddChilli() => Recipe += "add Chilli, then ";
        public void AddKetchup() => Recipe += "add Ketchup, then ";
        public void AddMayonnaise() => Recipe += "add Mayonnaise, then ";
        public void AddPepper() => Recipe += "add Pepper, then ";
        public void AddPineapple() => Recipe += "add Pineapple, then ";
        public void AddSalami() => Recipe += "add Salami, then ";
        public void Reset() => Recipe = string.Empty;

        public string GetRecipe() => Recipe.Substring(0, Recipe.Length - ", then ".Length);
    }
}
