using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Vsite.Oom.ObjectModel
{
    internal class HtmlFormater : Textformater
    { 
        public string FormatHeading1(string text)
        {
            return $"<h1>{text}</h1>";
        } 
        public string FormatHeading2(string text)
        {
            return $"<h2>{text}</h2>";
        }
        public string FormatParagraph(string text) 
        {
            return $"<p>{text}</p>";
        }
    }

}

