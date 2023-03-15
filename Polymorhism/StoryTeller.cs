using static System.Net.Mime.MediaTypeNames;

namespace Vsite.Oom.ObjectModel
{
    internal class StoryTeller
    {
        private readonly ITextFormatter _textFormatter;
        public StoryTeller(ITextFormatter textFormatter)
        {
            _textFormatter = textFormatter;
        }

        public void WriteParagraph(string text)
        {
            Console.WriteLine(_textFormatter.FormatParagraf(text));
        }

        public void WriteHeading1(string text)
        {

            Console.WriteLine(_textFormatter.FormatHeading1(text));
        }

        public void WriteHeading2(string text)
        {

            Console.WriteLine(_textFormatter.FormatHeading2(text));
        }
    }
}
