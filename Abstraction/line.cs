using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.Oom.ObjectModel
{
    internal class line
    {
            public line(double k, double l)
            {
                K = k;
                L = l;
            }

            public Point? Intersection(line other)
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
