using System;

namespace Vsite.Oom.ObjectModel
{
    public class HtmlTextFormatter : ITextFormatter
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
