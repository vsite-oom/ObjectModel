using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.Oom.ObjectModel
{
    internal class HTMLTextFormatter : ITextFormatter
    {
        public string FormatHeading1(string text)
        {
            return $"<h1>{text}<h1/>;
        }

        public string FormatHeading2(string text)
        {
            return $"<h1>{text}<h1/>;
        }

        public string FormatParagraph(string text)
        {
            return $"<h1>{text}<h1/>;
        }
    }
}
