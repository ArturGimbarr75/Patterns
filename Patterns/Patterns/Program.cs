using System;

namespace Patterns
{
    class Program
    {
        static void Main(string[] args)
        {           
            Creational();
        }

        static void Creational()
        {
            CreationalPatterns.AbstractFactory.EntryPoint.TestPattern();
            Console.WriteLine();
            CreationalPatterns.Singleton.EntryPoint.TestPattern();
            Console.WriteLine();
        }
    }
}
