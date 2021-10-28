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
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Creational patterns\n");
            Console.ResetColor();

            CreationalPatterns.AbstractFactory.EntryPoint.TestPattern();
            Console.WriteLine();
            CreationalPatterns.Singleton.EntryPoint.TestPattern();
            Console.WriteLine();
            CreationalPatterns.Builder.EntryPoint.TestPattern();
            Console.WriteLine();
            CreationalPatterns.Prototype.EntryPoint.TestPattern();
            Console.WriteLine();
        }
    }
}
