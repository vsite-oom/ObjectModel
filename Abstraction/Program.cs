namespace Vsite.Oom.ObjectModel
{
    internal class Program
    {
        static void main(string[] args)
        {
            try
            {
                double k1 = double.parse(args[0]);
                double l1 = double.parse(args[1]);
                double k2 = double.parse(args[2]);
                double l2 = double.parse(args[3]);

                var line1 = new Line(k1, L1);
                var line1 = new Line(k2, L2);

                var result = line1.Intersection(line2);
                if (result == null)
                {
                    Console.WriteLine("Lines are parrarel");
                }
                else
                {
                    Console.WriteLine($"Intersection: {result?.X},{result?.Y})");
                }

           //     if (k1 == k2)
           // {
           //     console.writeline("lines are parallel");
           //   }
           //  else
           //      {
           //     double x = (l2 - l1) / (k1 - k2);
           //    double y = k1 * x + l1;
           //    console.writeline($"ıntersection: ({x}, {y})");
           // }
           //      }
            catch (exception)
            {
                console.writeline("ınvalid entry");
            }
        }
    }
}