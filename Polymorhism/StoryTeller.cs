using static System.Net.Mime.MediaTypeNames;

namespace Vsite.Oom.ObjectModel
{
    internal class StoryTeller
    {
        private iTextFormatter formatter;
        public StoryTeller(iTextFormatter formatter)
        {
            this.formatter = formatter;

        }
        public void WriteParagraph(string text)
        {
            Console.WriteLine(formatter.WriteParagraph(text));
         }

        public void WriteHeading1(string caption)
        {
            Console.WriteLine(formatter.WriteHeading1(caption));
        }

        public void WriteHeading2(string caption)
        {
            Console.WriteLine(formatter.WriteHeading2(caption));
        }
    }
}
