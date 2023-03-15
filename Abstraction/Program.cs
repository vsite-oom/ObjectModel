namespace Vsite.Oom.ObjectModel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var l1 = new Line(1, 2);
            var l2 = new Line(3, 4);

            var rez = l1.IntersectionWith(l2);

            if (rez == null)
                Console.WriteLine("Lines are paralel");

            else
                Console.WriteLine(rez);
        }
    }
}