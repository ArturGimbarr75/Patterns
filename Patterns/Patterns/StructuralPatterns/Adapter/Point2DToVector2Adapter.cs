using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.StructuralPatterns.Adapter
{
    class Point2DToVector2Adapter : Vector2
    {
        private readonly Point2D _point;

        public Point2DToVector2Adapter(Point2D point)
        {
            _point = point;
        }

        public override double X { get => _point.X; set => _point.X = value; }
        public override double Y { get => _point.Y; set => _point.Y = value; }
    }
}
