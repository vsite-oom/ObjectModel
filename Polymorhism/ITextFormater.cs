using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.Oom.ObjectModel
{
    internal interface ITextFormater
    {
        void WriteParagraph(string text);
        void WriteHeading1(string caption);
        void WriteHeading2(string caption);
    }
}
