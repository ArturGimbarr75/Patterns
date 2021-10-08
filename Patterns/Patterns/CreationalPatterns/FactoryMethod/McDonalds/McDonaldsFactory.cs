﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.CreationalPatterns.FactoryMethod
{
    class McDonaldsFactory : IFactory
    {
        public Food CookBurger() => new McDonaldsBurger();

        public Food CookDrink() => new McDonaldsDrink();

        public Food CookFrenchFries() => new McDonaldsFrenchFries();
    }
}
