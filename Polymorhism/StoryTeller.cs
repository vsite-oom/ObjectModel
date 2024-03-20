namespace Vsite.Oom.ObjectModel
{
    internal class StoryTeller
    {
        private readonly bool html;
        public StoryTeller(bool html = false)
        {
            this.html = html;
        }

        private int heading1Number = 0;
        private int heading2Number = 0;

        public void WriteParagraph(string text)
        {
            if(html)
                Console.WriteLine($"<p>{text}</p>");
            else Console.WriteLine(text);
        }

        public void WriteHeading1(string caption)
        {
            Console.WriteLine();

            ++heading1Number;

            caption = $"{heading1Number}. {caption}";
            if (!html)
            {
                Console.WriteLine(caption);
                Console.WriteLine(new string('=', caption.Length));
            }
            else
            {
                Console.WriteLine("<h1>" + caption + "</h1>");
            }

        }

        public void WriteHeading2(string caption)
        {
            Console.WriteLine();

            ++heading2Number;
            caption = $"{heading1Number}.{heading2Number}. {caption}";
            if (!html)
            {
                Console.WriteLine(caption);
                Console.WriteLine(new string('-', caption.Length));
            }
            else
            {
                Console.WriteLine("<h2>" + caption + "</h2>");
            }
            
        }


    }
}
