using System.Text;

namespace Vsite.Oom.ObjectModel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ITextFormatter formatter = new PlainTextFormatter();

            Console.WriteLine("Do you want in HTML? (y/n)");
            if (Console.ReadLine() == "y")
            {
                formatter = new HtmlTextFormatter();
            }

            StoryTeller st = new StoryTeller(formatter);
            st.WriteHeading1("Snow White and the wolf");
            st.WriteHeading2("Leaving home");
            st.WriteParagraph("Once upon a time, in a land far, far away...");

            Console.ReadKey(false);
        }
    }
}