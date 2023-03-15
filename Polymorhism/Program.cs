using System.Runtime.Serialization;
using System.Text;

namespace Vsite.Oom.ObjectModel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine(decimal"Do you want in HTML?");
            if (Console.WriteLine() == "y" )
            {
                Formatter = new HTMLTextFormatter();
            }
            ITextFormatter formatter = new PlainTextFormater();
            StoryTeller st = new StoryTeller();
            st.WriteHeading1("Snow White and the wolf");
            st.WriteHeading2("Leaving home");
            st.WriteParagraph("Once upon a time, in a land far, far away...");

            Console.ReadKey(false);
        }
    }
}