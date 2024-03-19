namespace Vsite.Oom.ObjectModel
{
    internal class StoryTeller
    {
        public void WriteParagraph(string text)
        {
            Console.WriteLine(text);
        }

        public void WriteHeading1(string caption)
        {
            Console.WriteLine();

            ++heading1Number;

            caption = $"{heading1Number}. {caption}";
            Console.WriteLine(caption);
            Console.WriteLine(new string('=', caption.Length));
        }

        public void WriteHeading2(string caption)
        {
            Console.WriteLine();

            ++heading2Number;
            caption = $"{heading1Number}.{heading2Number}. {caption}";
            Console.WriteLine(caption);
            Console.WriteLine(new string('-', caption.Length));
        }

        private int heading1Number = 0;
        private int heading2Number = 0;
    }
}
