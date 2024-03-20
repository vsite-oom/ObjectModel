using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.Oom.ObjectModel
{
    internal class PlainTextFormat : ITextFormated
    {
        public void WriteParagraph(string text)
        {
            Console.WriteLine(text);
        }

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
    }
}
