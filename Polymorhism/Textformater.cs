using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.Oom.ObjectModel
{
    internal interface Textformater
    {
        string FormatParagraph(string text);
        string FormatHeading1(string text);
        string FormatHeading2(string text); 
    }
}
