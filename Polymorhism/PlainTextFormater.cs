using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.Oom.ObjectModel
{
    internal class PlainTextFormater : ITextFormater
    {
        public string FormatHeading1 (string text)
        {
            return string.Format
        }
        public string FormatHeading2(string text)
        {
            return string.Format
        }

        public string FormatParagraph(string text)
        {
            return $"<h1>{text}<h1/>;
        }
    }
}
