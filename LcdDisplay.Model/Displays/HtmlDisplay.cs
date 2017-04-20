using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LcdDisplay.Model.Displays
{
    public class HtmlDisplay
    {
        public HtmlDisplay()
        {

        }

        public String GetFromDigit(int size, string number)
        {
            switch (number)
            {
                case "1":
                    return GetDigitOne(size, number);
                default:
                    break;
            }
            return number;
        }

        private string GetDigitOne(int size, string number)
        {
            return GetBlankSpaces(1) + GetPipes(size) + GetBlankSpaces(1) + GetPipes(size) + GetBlankSpaces(1);
        }

        private string GetBlankSpaces(int count)
        {
            return RepeatString("&nbsp;", count) + "<br />";
        }

        private string GetPipes(int count)
        {
            return RepeatString("|<br />", count);
        }

        private String RepeatString(string text, int count)
        {
            return String.Concat(Enumerable.Repeat(text, count));
        }
    }
}
