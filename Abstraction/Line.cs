using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.Oom.ObjectModel
{
    internal class Line
    {
        public double K { get; private set; }
        public double L { get; private set; }
        public Line(double K, double L)
        {
            this.K = K;
            this.L = L;  
        }
        public Point? Intersection(Line other)
        {
            if(K==other.K) return null;

            double x = (other.L - L) / (K - other.K);
            double y = K * x + L;
            return new Point(x, y);
        }
    }
}
