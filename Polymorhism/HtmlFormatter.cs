using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.Oom.ObjectModel
{
    internal class HtmlFormatter : iTextFormatter
    {
        public string WriteHeading1(string caption)
        {
            return $"<h1>{caption}</h1>";
        }

        public string WriteHeading2(string caption)
        {
            return $"<h2>{caption}</h2>";

        }

        public string WriteParagraph(string text)
        {
            return $"<p>{text}</p>";

        }
    }
}
