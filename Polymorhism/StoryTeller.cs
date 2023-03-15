namespace Vsite.Oom.ObjectModel
{
    internal class StoryTeller
    {
        private ITextFormatter _textFormatter;

        public StoryTeller(ITextFormatter textFormatter)
        {
            this._textFormatter = textFormatter;
        }

        public void WriteParagraph(string text)
        {
            Console.WriteLine(_textFormatter.FormatParagraph(text));
        }

        public void WriteHeading1(string caption)
        {
            Console.WriteLine(_textFormatter.FormatHeading1(caption));
        }

        public void WriteHeading2(string caption)
        {
            Console.WriteLine(_textFormatter.FormatHeading2(caption));
        }
    }
}
