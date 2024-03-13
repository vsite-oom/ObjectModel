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
            if (this.K == other.K) return null;
            double x = (other.L - this.L) / (this.K - other.K);
            double y = this.K * x + this.L;
            return new Point(x, y);
        }
    }
}
