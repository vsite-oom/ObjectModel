namespace Vsite.Oom.ObjectModel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var l1 = new Line(1, 2);
            var l2 = new Line(3, 4);

            var res = l1.Intersection(l2);

            if (res == null)
            {
                Console.WriteLine("Lines are parallel");
            }
            else
            {
                Console.WriteLine($"Intersection: ({res?.X}, {res?.Y})");
            }
        }
    }
}