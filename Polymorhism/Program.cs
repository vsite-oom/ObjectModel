using System.Text;

namespace Vsite.Oom.ObjectModel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            ITextFormatter _textFormatter;

            Console.WriteLine("Do you want text formatted as HTML? (y/n)");

            if (Console.ReadLine() == "y")
                _textFormatter = new HtmlTextFormatter();

            else
                _textFormatter = new PlainTextFormatter();


            StoryTeller st = new StoryTeller(_textFormatter);
            st.WriteHeading1("Snow White and the wolf");
            st.WriteHeading2("Leaving home");
            st.WriteParagraph("Once upon a time, in a land far, far away...");

            Console.ReadKey(false);
        }
    }
}