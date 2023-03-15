namespace Vsite.Oom.ObjectModel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var l1 = new Line(1, 2);
            var l2 = new Line(3, 4);

            var res = l1.Intersection(l2);
            if (res==null)
            {
                Console.WriteLine("Lines are parallel");
            }

            else
            {
                Console.WriteLine($"Intersection: ({res.X},{res.Y})");
            }
            //try
            //{
            //    double k1 = double.Parse(args[0]);
            //    double l1 = double.Parse(args[1]);
            //    double k2 = double.Parse(args[2]);
            //    double l2 = double.Parse(args[3]);

            //    if (k1 == k2)
            //    {
            //        Console.WriteLine("Lines are parallel");
            //    }
            //    else
            //    {
            //        double x = (l2 - l1) / (k1 - k2);
            //        double y = k1 * x + l1;
            //        Console.WriteLine($"Intersection: ({x}, {y})");
            //    }
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Invalid entry");
            //}
        }
    }
}