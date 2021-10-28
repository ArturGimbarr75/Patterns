using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.CreationalPatterns.Prototype
{
    class Circle : Shape
    {
        public float Radius;

        public Circle(float x, float y, float radius) : base(x, y)
        {
            Radius = radius;
        }

        // Copy constructor
        public Circle(Circle circle) : base(circle)
        {
            Radius = circle.Radius;
        }

        public override bool Equals(object obj)
        {
            if (!base.Equals(obj)) return false;
            Circle o = obj as Circle;
            if (o.Radius != Radius) return false;
            return true;
        }

        // C# interface
        public override object Clone() => new Circle(this);
        public override object Copy() => new Circle(this);
    }
}
