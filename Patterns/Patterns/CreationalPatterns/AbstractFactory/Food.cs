using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.CreationalPatterns.AbstractFactory
{
    class Food
    {
        public void UseFood() => Console.WriteLine(@"Used {0}", this.GetType().Name);
    }
}
