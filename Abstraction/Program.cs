namespace Vsite.Oom.ObjectModel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            line l1 = new(1, 2);
            line l2 = new(3, 4);

                var res = l1.Intersection(l2);

                if (res == null)
                {
                    Console.WriteLine("Lines are parallel");
                }
                else
                {
                    Console.WriteLine($"Intersection new: ({res?.X}, {res?.Y})");
                }
            }
        }
    }