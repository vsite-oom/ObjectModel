using System;

namespace Vsite.Oom.ObjectModel
{
    internal class Line
    {
        public Line(double k, double l)
        {
            K = k;
            L = l;
        }

        public Point? Intersection(Line other)
        {
            if (K == other.K)
            {
                return null;
            }
            else
            {
                double x = (other.L - L) / (this.K - other.K);
                double y = K * x + L;
                return new Point(x, y);
            }
        }

        public double K { get; private set; }
        public double L { get; private set; }
    }
}
