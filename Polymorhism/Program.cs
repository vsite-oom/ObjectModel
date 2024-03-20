using System.Text;

namespace Vsite.Oom.ObjectModel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            ITextFormatter tf = null;
            Console.WriteLine("Do you want HTML format?");
            string answer = Console.ReadLine();
            if(answer == "y")
            {
                tf=new HtmlTextFormatter();
            }
            else
            {
                tf = new PlainTextFormatter();
            }

            StoryTeller st = new StoryTeller(tf);
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