using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.CreationalPatterns.Prototype
{
    class EntryPoint
    {
        public static void TestPattern()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Prototype");
            Console.ResetColor();

            Circle circle = new Circle(0, 1, 5);
            Rectangle rectangle = new Rectangle(-5, 4, 15, 25);

            Circle circle2 = circle.Copy() as Circle;
            Rectangle rectangle2 = rectangle.Clone() as Rectangle;

            Console.WriteLine($"circle == circle2 -> {circle.Equals(circle2)}");
            Console.WriteLine($"rectangle2 == rectangle -> {rectangle2.Equals(rectangle)}");
        }
    }
}
