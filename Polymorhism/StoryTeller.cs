using static System.Net.Mime.MediaTypeNames;

namespace Vsite.Oom.ObjectModel
{
    internal class StoryTeller
    {
        private readonly ITextFormatter formatter;

        public StoryTeller(ITextFormatter formatter)
        {
            this.formatter = formatter;
        }
        public void WriteParagraph(string text)
        {
            Console.WriteLine(formatter.FormatParagraph(text));
        }

        public void WriteHeading1(string caption)
        {
            Console.WriteLine(formatter.FormatHeading1(text));
        }

        public void WriteHeading2(string caption)
        {
            Console.WriteLine(formatter.FormatHeading2(text));
        }
    }
}
