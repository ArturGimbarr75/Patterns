using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.CreationalPatterns.Prototype
{
    class Shape : ICloneable, ICopy
    {
        public float X;
        public float Y;

        public Shape(float x, float y)
        {
            X = x;
            Y = y;
        }

        // Copy constructor
        public Shape(Shape shape)
        {
            X = shape.X;
            Y = shape.Y;
        }

        public override bool Equals(object obj)
        {
            Shape o = obj as Shape;
            if (o == null) return false;
            if (o.X != X) return false;
            if (o.Y != Y) return false;
            return true;
        }

        // C# interface
        public virtual object Clone() => new Shape(this);
        public virtual object Copy() => new Shape(this);
    }
}
