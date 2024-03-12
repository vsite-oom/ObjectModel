using System.Text;

namespace Vsite.Oom.ObjectModel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            StoryTeller st = new StoryTeller();
            st.WriteHeading1("Snow White and the wolf");
            st.WriteHeading2("She's leaving home");
            st.WriteParagraph("Once upon a time, in a land far, far away...");

            Console.ReadKey(false);
        }
    }
}