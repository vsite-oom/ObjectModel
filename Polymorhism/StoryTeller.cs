namespace Vsite.Oom.ObjectModel
{
    internal class StoryTeller
    {
        public StoryTeller(ITextFormater textFormater)
        {
            this.textFormater = textFormater;
        }
        private readonly ITextFormater textFormater;
        public void WriteParagraph(string text)
        {
            textFormater.WriteParagraph(text);
        }

        public void WriteHeading1(string caption)
        {
            ++heading1Number;

            caption = $"{heading1Number}. {caption}";
            textFormater.WriteHeading1(caption);
        }

        public void WriteHeading2(string caption)
        {
            ++heading2Number;

            caption = $"{heading1Number}.{heading2Number} {caption}";
            textFormater.WriteHeading2(caption);
        }


        private int heading1Number = 0;
        private int heading2Number = 0;
    }
}
