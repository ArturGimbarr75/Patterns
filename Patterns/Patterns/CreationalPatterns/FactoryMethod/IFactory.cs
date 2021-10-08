using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.CreationalPatterns.FactoryMethod
{
    interface IFactory
    {
        public Food CookBurger();
        public Food CookDrink();
        public Food CookFrenchFries();
    }
}
 