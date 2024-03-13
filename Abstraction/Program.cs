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

                Line Line1 = new Line(k1, l1);
                Line Line2 = new Line(k2, l2);

                var intersection = Line1.Intersetcion(Line2);

                if (intersection == null)
                {
                    Console.WriteLine("Lines are parallel");
                }
                else
                {
                    Console.WriteLine($"Intersection: ({intersection?.X}, {intersection?.Y})");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid entry");
            }
        }
    }
}