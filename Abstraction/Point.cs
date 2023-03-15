using System;

namespace Vsite.Oom.ObjectModel
{
    internal struct Point
    {
        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }
        public readonly double X;
        public readonly double Y;
    }
}
