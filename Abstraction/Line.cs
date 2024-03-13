using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.Oom.ObjectModel
{
    internal class Line
    {
        public Line(double b, double l)
        {
            K = b;
            L = l;
        }
        public readonly double K;
        public readonly double L;

        public Point? Intersection(Line other)
        {
            if(K==other.K) 
            {
                return null;
            }
            double x = (other.L - L) / (K - other.K);
            double y = K * x + L;
            return new Point(x, y);
        }
    }
}
