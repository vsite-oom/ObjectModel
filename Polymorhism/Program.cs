using System.Text;

namespace Vsite.Oom.ObjectModel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            StoryTeller st = new StoryTeller(true);
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