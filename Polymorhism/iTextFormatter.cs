using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.Oom.ObjectModel
{
    internal interface iTextFormatter
    {
        string WriteParagraph(string text);

        string WriteHeading1(string caption);


        string WriteHeading2(string caption);
   
    }
}
