namespace Vsite.Oom.ObjectModel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double k1 = double.Parse(args[0]);
                double l1 = double.Parse(args[1]);
                double k2 = double.Parse(args[2]);
                double l2 = double.Parse(args[3]);

                Line line1 = new Line(k1, l1);
                Line line2 = new Line(k2, l2);

                Point? intersectionPoint = line1.GetIntersection(line2);
                if (intersectionPoint != null)
                {
                    Console.WriteLine($"Intersection point at: {intersectionPoint?.X},{intersectionPoint?.Y}");
                }
                else throw new Exception("Lines are parallel");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}