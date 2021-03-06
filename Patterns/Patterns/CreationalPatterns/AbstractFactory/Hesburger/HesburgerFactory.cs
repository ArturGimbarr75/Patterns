using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.CreationalPatterns.AbstractFactory
{
    class HesburgerFactory : IFactory
    {
        public Food CookBurger() => new HesburgerBurger();

        public Food CookDrink() => new HesburgerDrink();

        public Food CookFrenchFries() => new HesburgerFrenchFries();
    }
}
