using System.Text;

namespace Vsite.Oom.ObjectModel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            ITextFormatter formater = new PlainTextFormatter();
            Console.WriteLine("Do you want the text in html");
            if (Console.ReadLine() == "y")
            { 

                formater = new HtmlTextFormater();

            }


        
            StoryTeller st = new StoryTeller(formater);
            st.WriteHeading1("Snow White and the wolf");
            st.WriteHeading2("Leaving home");
            st.WriteParagraph("Once upon a time, in a land far, far away...");

            Console.ReadKey(false);
        }
    }
}