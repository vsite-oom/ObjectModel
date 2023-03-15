namespace Vsite.Oom.ObjectModel
{
    internal class StoryTeller
    {
        private readonly ITextFormatter _formatter;
        public StoryTeller(ITextFormatter formatter)
        {
            _formatter = formatter;
        }
        public void WriteParagraph(string text)
        {
            Console.WriteLine(_formatter.FormatParagraph(text));
        }

        public void WriteHeading1(string caption)
        {
            Console.WriteLine(_formatter.FormatHeading1(caption));
        }

        public void WriteHeading2(string caption)
        {
            Console.WriteLine(_formatter.FormatHeading2(caption));
        }
    }
}
