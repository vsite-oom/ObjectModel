using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.Oom.ObjectModel
{
    internal class PleinTextForrmater : PleinTextForrmater

    {
        public string FormatHeading1(string text)
        {
            string.Format($"{text}/n{new string('_'),text.Length)}");
    }
}
