using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.CreationalPatterns.Builder
{
    class PizzaBuilder : IBuilder
    {
        List<Ingredients> Pizza;
        public PizzaBuilder() => Reset();

        public void AddBacon() => Pizza.Add(Ingredients.Bacon);
        public void AddCheese() => Pizza.Add(Ingredients.Cheese);
        public void AddChilli() => Pizza.Add(Ingredients.Chilli);
        public void AddKetchup() => Pizza.Add(Ingredients.Ketchup);
        public void AddMayonnaise() => Pizza.Add(Ingredients.Mayonnaise);
        public void AddPepper() => Pizza.Add(Ingredients.Pepper);
        public void AddPineapple() => Pizza.Add(Ingredients.Pineapple);
        public void AddSalami() => Pizza.Add(Ingredients.Salami);
        public void Reset() => Pizza = new List<Ingredients>();

        public List<Ingredients> GetPizza() => Pizza;
    }
}
