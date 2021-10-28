using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.CreationalPatterns.Builder
{
    class Director
    {
        public void CookPepperoniPizza(IBuilder builder)
        {
            builder.Reset();
            builder.AddKetchup();
            builder.AddMayonnaise();
            builder.AddCheese();
            builder.AddSalami();
        }

        public void CookHavanaPizza(IBuilder builder)
        {
            builder.Reset();
            builder.AddKetchup();
            builder.AddCheese();
            builder.AddBacon();
            builder.AddPineapple();
        }
    }
}
