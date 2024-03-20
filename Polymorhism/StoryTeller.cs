namespace Vsite.Oom.ObjectModel
{
    internal class StoryTeller
    {
        public StoryTeller(bool html)
        {
            this.html = html;
        }
        private readonly bool html=false;
        public void WriteParagraph(string text)
        {
            if (html)
            {
                Console.WriteLine($"<p>{text}</p>");
            }
            else
            {
				Console.WriteLine(text);
			}

        }

        public void WriteHeading1(string caption)
        {
            if (html)
            {
                Console.WriteLine($"<h1>{caption}</h1>");
            }
            else 
            {
                Console.WriteLine();

                ++heading1Number;

                caption = $"{heading1Number}. {caption}";
                Console.WriteLine(caption);
                Console.WriteLine(new string('=', caption.Length));
            }
        }

        public void WriteHeading2(string caption)
        {
            if (html)
            {
                Console.WriteLine($"<h2>{caption}</h2>");
            }
            else
            {
                Console.WriteLine();

                ++heading2Number;
                caption = $"{heading1Number}.{heading2Number}. {caption}";
                Console.WriteLine(caption);
                Console.WriteLine(new string('-', caption.Length));
            }
        }

        private int heading1Number = 0;
        private int heading2Number = 0;
    }
}
