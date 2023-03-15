using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.Oom.ObjectModel
{
    internal interface ITextFormatter
    {
        public string FormatParagraph(string text);
        public string FormatHeading1(string text);
        public string FormatHeading2(string text);
    }
}
