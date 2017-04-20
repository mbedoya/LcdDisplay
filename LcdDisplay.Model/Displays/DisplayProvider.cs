using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LcdDisplay.Model.Displays
{
    public abstract class DisplayProvider
    {
        public List<string> GetFromNumber(int size, string number)
        {
            List<string> displays = new List<string>();
            for (int i = 0; i < number.Length; i++)
            {
                displays.Add(GetFromDigit(size, number.Substring(i, 1)));
            }

            return displays;
        }

        public String GetFromDigit(int size, string number)
        {
            switch (number)
            {
                case "0":
                    return GetDigitZero(size);
                case "1":
                    return GetDigitOne(size);
                case "2":
                    return GetDigitTwo(size);
                case "3":
                    return GetDigitThree(size);
                case "4":
                    return GetDigitFour(size);
                case "5":
                    return GetDigitFive(size);
                case "6":
                    return GetDigitSix(size);
                case "7":
                    return GetDigitSeven(size);
                case "8":
                    return GetDigitEight(size);
                case "9":
                    return GetDigitNine(size);
                default:
                    break;
            }
            return number;
        }

        private string GetDigitZero(int size)
        {
            return GetDots(size, false) + GetBlankSpaces(1) +
                RepeatString(GetPipes(1, false) + GetBlankSpaces(size, false) + GetPipes(1, false) + GetLineBreak(), size) +
                GetBlankSpaces(size) +
                RepeatString(GetPipes(1, false) + GetBlankSpaces(size, false) + GetPipes(1, false) + GetLineBreak(), size) +
                GetDots(size, false) + GetBlankSpaces(1);
        }

        private string GetDigitOne(int size)
        {
            return GetBlankSpaces(1) +
                RepeatString(GetPipes(1), size) +
                GetBlankSpaces(1) +
                RepeatString(GetPipes(1), size) +
                GetBlankSpaces(1);
        }

        private string GetDigitTwo(int size)
        {
            return
                GetDots(size, false) + GetBlankSpaces(1) +
                RepeatString(GetBlankSpaces(size, false) + GetPipes(1), size) +
                GetDots(size, false) + GetBlankSpaces(1) +
                RepeatString(GetPipes(1, false) + GetBlankSpaces(size, false) + GetLineBreak(), size) +
                GetDots(size, false) + GetBlankSpaces(1);
        }

        private string GetDigitThree(int size)
        {
            return
                GetDots(size, false) + GetBlankSpaces(1) +
                RepeatString(GetBlankSpaces(size, false) + GetPipes(1), size) +
                GetDots(size, false) + GetBlankSpaces(1) +
                RepeatString(GetBlankSpaces(size, false) + GetPipes(1), size) +
                GetDots(size, false) + GetBlankSpaces(1);
        }

        private string GetDigitFour(int size)
        {
            return
                GetBlankSpaces(size, false) + GetBlankSpaces(1) +
                RepeatString(GetPipes(1, false) + GetBlankSpaces(size, false) + GetPipes(1), size) +
                GetDots(size, false) + GetBlankSpaces(1) +
                RepeatString(GetBlankSpaces(size, false) + GetPipes(1), size) +
                GetBlankSpaces(size);
        }

        private string GetDigitFive(int size)
        {
            return
                GetDots(size, false) + GetBlankSpaces(1) +
                RepeatString(GetPipes(1, false) + GetBlankSpaces(size, false) + GetLineBreak(), size) +
                GetDots(size, false) + GetBlankSpaces(1) +
                RepeatString(GetBlankSpaces(size, false) + GetPipes(1), size) +
                GetDots(size, false) + GetBlankSpaces(1);
        }

        private string GetDigitSix(int size)
        {
            return
                GetDots(size, false) + GetBlankSpaces(1) +
                RepeatString(GetPipes(1, false) + GetBlankSpaces(size, false) + GetLineBreak(), size) +
                GetDots(size, false) + GetBlankSpaces(1) +
                RepeatString(GetPipes(1, false) + GetBlankSpaces(size, false) + GetPipes(1), size) +
                GetDots(size, false) + GetBlankSpaces(1);
        }

        private string GetDigitSeven(int size)
        {
            return
                GetDots(size, false) + GetBlankSpaces(1) +
                RepeatString(GetBlankSpaces(size, false) + GetPipes(1), size) +
                GetDots(size, false) + GetBlankSpaces(1) +
                RepeatString(GetBlankSpaces(size, false) + GetPipes(1), size) +
                GetBlankSpaces(size);
        }

        private string GetDigitEight(int size)
        {
            return
                GetDots(size, false) + GetBlankSpaces(1) +
                RepeatString(GetPipes(1, false) + GetBlankSpaces(size, false) + GetPipes(1, false) + GetLineBreak(), size) +
                GetDots(size, false) + GetBlankSpaces(1) +
                RepeatString(GetPipes(1, false) + GetBlankSpaces(size, false) + GetPipes(1, false) + GetLineBreak(), size) +
                GetDots(size, false) + GetBlankSpaces(1);
        }

        private string GetDigitNine(int size)
        {
            return
                GetDots(size, false) + GetBlankSpaces(1) +
                RepeatString(GetPipes(1, false) + GetBlankSpaces(size, false) + GetPipes(1, false) + GetLineBreak(), size) +
                GetDots(size, false) + GetBlankSpaces(1) +
                RepeatString(GetBlankSpaces(size, false) + GetPipes(1, false) + GetLineBreak(), size) +
                GetDots(size, false) + GetBlankSpaces(1);
        }

        public virtual string GetLineBreak()
        {
            return "\r\n";
        }

        public virtual string GetPipeChar()
        {
            return "|";
        }

        public virtual string GetEspaceChar()
        {
            return " ";
        }

        private string GetDots(int count, bool addLineBreak = true)
        {
            return GetChar("-", count, addLineBreak);
        }

        private string GetBlankSpaces(int count, bool addLineBreak = true)
        {
            return GetChar(GetEspaceChar(), count, addLineBreak);
        }

        private string GetPipes(int count, bool addLineBreak = true)
        {
            return GetChar(GetPipeChar(), count, addLineBreak);
        }

        private string GetChar(string text, int count, bool addLineBreak = true)
        {
            if (addLineBreak)
            {
                return RepeatString(text, count) + GetLineBreak();
            }
            else
            {
                return RepeatString(text, count);
            }
        }

        private String RepeatString(string text, int count)
        {
            return String.Concat(Enumerable.Repeat(text, count));
        }
    }
}
