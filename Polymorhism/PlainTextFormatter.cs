using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.Oom.ObjectModel
{
    internal class PlainTextFormatter : ITextFormatter
    {
        public string FormatHeading1(string text)
        {
            return string.Format($"{text}\n{new string('=', text.Length)}");
        }

        public string FormatHeading2(string text)
        {
            return string.Format($"{text}\n{new string('-', text.Length)}");
        }

        public string FormatParagraph(string text)
        {
            return text;
        }
    }
}
