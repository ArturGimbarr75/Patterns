using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.CreationalPatterns.Prototype
{
    class Rectangle : Shape
    {
        public float Width;
        public float Height;

        public Rectangle(float x, float y, float width, float height) : base (x, y)
        {
            Width = width;
            Height = height;
        }

        // Copy constructor
        public Rectangle(Rectangle rectangle) : base (rectangle)
        {
            Width = rectangle.Width;
            Height = rectangle.Height;
        }

        public override bool Equals(object obj)
        {
            if (!base.Equals(obj)) return false;
            Rectangle o = obj as Rectangle;
            if (o.Height != Height) return false;
            if (o.Width != Width) return false;
            return true;
        }

        // C# interface
        public override object Clone() => new Rectangle(this);
        public override object Copy() => new Rectangle(this);
    }
}
