using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.Oom.ObjectModel
{
    public class PlainTextFormatter : ITextFormatter
    {
        public void WriteHeading1(string caption)
        {
            Console.WriteLine();

            Console.WriteLine(caption);
            Console.WriteLine(new string('=', caption.Length));
        }

        public void WriteHeading2(string caption)
        {
            Console.WriteLine();

            Console.WriteLine(caption);
            Console.WriteLine(new string('-', caption.Length));
        }

        public void WriteParagraph(string text)
        {
            Console.WriteLine(text);
        }
    }
}
