namespace Vsite.Oom.ObjectModel
{
    internal class StoryTeller
    {
        public StoryTeller(ITextFormated textFormated)
        {
            this.textFormated = textFormated;
        }

        private ITextFormated textFormated;
        public void WriteParagraph(string text)
        {
            textFormated.WriteParagraph(text);
        }

        public void WriteHeading1(string caption)
        {
            ++heading1Number;

            caption = $"{heading1Number}. {caption}";
            textFormated.WriteHeading1(caption);

        }

        public void WriteHeading2(string caption)
        {
            ++heading2Number;

            caption = $"{heading1Number}.{heading2Number}.{caption}";
            textFormated.WriteHeading2(caption);
        }


        private int heading1Number = 0;
        private int heading2Number = 0;
    }
}
