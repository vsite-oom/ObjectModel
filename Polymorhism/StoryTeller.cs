using static System.Net.Mime.MediaTypeNames;

namespace Vsite.Oom.ObjectModel
{
    internal class StoryTeller
    {
        public StoryTeller(ITextFormatter textFormatter)
        {
            this.textFormatter = textFormatter;
        }
        private readonly ITextFormatter textFormatter;
        public void WriteParagraph(string text)
        {

            textFormatter.WriteParagraph(text);
        }

        public void WriteHeading1(string caption)
        {
            ++heading1Number;
            caption = $"{heading1Number}, {caption}";
            textFormatter.WriteHeading1(caption);
            
        }

        public void WriteHeading2(string caption)
        {

            ++heading2Number;
            caption = $"{heading2Number}, {caption}";
            textFormatter.WriteHeading2(caption);
        }

        private int heading1Number = 0;
        private int heading2Number = 0;
    }
}
