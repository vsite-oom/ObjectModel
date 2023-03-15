using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.Oom.ObjectModel
{
    internal class Line
    {
        public Line (double k, double l)
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

            double x = (other.L - L) / (K - other.K);
            double y = this.K * x + this.L;
            return new Point(x, y);
        }
       

        public double K { get; private set; }
        public double L { get; private set; }
    }
}
