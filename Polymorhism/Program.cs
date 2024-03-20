using System.Security.Cryptography;
using System.Text;

namespace Vsite.Oom.ObjectModel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("Pick format:");
            Console.WriteLine("\t1 - Plain text");
            Console.WriteLine("\t2 - HTML");
            var key = Console.ReadKey().KeyChar.ToString();
            ITextFormatter e;
            switch (key){
                case "1": e = new PlainTextFormatter(); break;
                case "2": e = new HtmlTextFormatter(); break;

                default: return;
            }

            StoryTeller st = new StoryTeller(e);
            st.WriteHeading1("Snow White and the Wolf");
            st.WriteHeading2("She's leaving home");
            st.WriteParagraph("Once upon a time, in a land far, far away...");

            st.WriteHeading2("A Chance Encounter with a Prince on White Horse");
            st.WriteParagraph("She was dancing alone on the dancing floor...");

            st.WriteHeading1("The End");
            st.WriteParagraph("And they lived happily ever after...");

            Console.ReadKey(false);
        }
    }
}