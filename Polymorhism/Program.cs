using System.Text;

namespace Vsite.Oom.ObjectModel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            iTextFormatter formatter = new PlainTextFormatter();

            Console.WriteLine("Do you want HTML? (y/n)");
           var answer = Console.ReadLine();
            if (answer![0] == 'y')
            {
                formatter = new HtmlFormatter();
            }
            StoryTeller st= new StoryTeller(formatter);
            st.WriteHeading1("Snow White and the wolf");
            st.WriteHeading2("Leaving home");
            st.WriteParagraph("Once upon a time, in a land far, far away...");

            Console.ReadKey(false);
        }
    }
}