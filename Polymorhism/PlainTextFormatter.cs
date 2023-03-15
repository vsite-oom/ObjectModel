using System;

namespace Vsite.Oom.ObjectModel
{
    public class PlainTextFormatter : ITextFormatter
    {
        public string FormatHeading1(string text)
        {
            return string.Format($"{text}\n{new string('=', text.Length)}");
        }

        public string FormatHeading2(string text)
        {
            return string.Format($"{text}\n{new string('-', text.Length)}");
        }

        public string FormatParagraph(string text)
        {
            return text;
        }
    }
}
