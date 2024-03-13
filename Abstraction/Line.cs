using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.Oom.ObjectModel
{
    internal class Line
    {
        public readonly double K;
        public readonly double L;
        public Line(double k, double l)
        {
            this.K = k;
            this.L = l;
        }
        public Point? Intersection(Line other)
        {
            double x = (other.L - L) / (K - other.K);
            double y = K * x + L;
            return new Point(x, y);
        }
    }
}
