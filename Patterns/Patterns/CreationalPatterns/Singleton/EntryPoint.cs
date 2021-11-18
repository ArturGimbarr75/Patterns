using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.CreationalPatterns.Singleton
{
    class EntryPoint
    {
        public static void TestPattern()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Singleton");
            Console.ResetColor();

            GlobalSettings s1 = GlobalSettings.GetInstance();
            GlobalSettings s2 = GlobalSettings.GetInstance();

            if (s1 == s2)
                Console.WriteLine("Singleton works");
            else
                Console.WriteLine("Singleton not works");
        }
    }
}
