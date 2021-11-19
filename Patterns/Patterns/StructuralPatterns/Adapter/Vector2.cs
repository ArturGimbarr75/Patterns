using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.StructuralPatterns.Adapter
{
    class Vector2
    {
        public virtual double X { get => _x; set => _x = value; }
        public virtual double Y { get => _y; set => _y = value; }

        private double _x;
        private double _y;

        public double Distance(Vector2 pos)
        {
            return Math.Sqrt
                (
                    Math.Pow(X - pos.X, 2) +
                    Math.Pow(Y - pos.Y, 2)
                );
        }
    }
}
