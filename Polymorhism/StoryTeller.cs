namespace Vsite.Oom.ObjectModel
{
    internal class StoryTeller
    {
        private readonly ITextFormatter _textFormatter;

        public StoryTeller(ITextFormatter textFormatter)
        {
            this._textFormatter = textFormatter;
        }

        private int heading1Number = 0;
        private int heading2Number = 0;

        public void WriteParagraph(string text)
        {
            _textFormatter.WriteParagraph(text);
        }

        public void WriteHeading1(string caption)
        {
            ++heading1Number;

            caption = $"{heading1Number}. {caption}";
            _textFormatter.WriteHeading1(caption);
        }

        public void WriteHeading2(string caption)
        {
            ++heading2Number;
            caption = $"{heading1Number}.{heading2Number}. {caption}";

            _textFormatter.WriteHeading2(caption);
        }
    }
}
