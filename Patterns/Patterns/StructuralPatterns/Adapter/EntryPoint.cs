using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.StructuralPatterns.Adapter
{
    static class EntryPoint
    {
        public static void TestPattern()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Adapter");
            Console.ResetColor();

            Vector2 pos1 = new Vector2() { X = 5, Y = 4 };
            Vector2 pos2 = new Point2DToVector2Adapter(new Point2D() { X = 4, Y = 5 });

            Console.WriteLine("Distance between 2 points: " + pos1.Distance(pos2));
        }
    }
}
