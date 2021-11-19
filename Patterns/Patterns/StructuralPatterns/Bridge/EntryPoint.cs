using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.StructuralPatterns.Bridge
{
    static class EntryPoint
    {
        public static void TestPattern()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Bridge");
            Console.ResetColor();

            Remote r1 = new Remote(new TV());
            Remote r2 = new SuperRemote(new Radio());

            UseRemote(r1);
            UseRemote(r2);
        }

        private static void UseRemote(Remote remote) => remote.SetVolume(50);
    }
}
