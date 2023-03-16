using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.Oom.ObjectModel
{
    internal class PlainTextFormatter : iTextFormatter
    {
        public string WriteHeading1(string caption)
        {
            return $"{caption}\n{new string('=',caption.Length)}";
          
        }

        public string WriteHeading2(string caption)
        {
            return $"{caption}\n{new string('-', caption.Length)}";
        }

        public string WriteParagraph(string text)
        {
           return text;
        }
    }
}
