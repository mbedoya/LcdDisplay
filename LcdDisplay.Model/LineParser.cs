using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LcdDisplay.Model
{
    public class LineParser
    {
        private String text;
        private Char separator = ',';
        private int sizeIndex = 0;
        private int numberIndex = 1;

        public LineParser(String text)
        {
            this.text = text.Trim();
        }

        private LineParserResultStatus CheckTextFormat()
        {
            LineParserResultStatus status = LineParserResultStatus.ValidLine;

            if (String.IsNullOrEmpty(text))
            {
                return LineParserResultStatus.EmptyString;
            }

            if (!text.Contains(separator))
            {
                return LineParserResultStatus.NumberNotSent;
            }

            return status;
        }

        private LineParserResultStatus CheckSizeFormat(string size)
        {
            LineParserResultStatus status = LineParserResultStatus.ValidLine;

            if (String.IsNullOrEmpty(size))
            {
                return LineParserResultStatus.SizeNotSent;
            }

            int sizeResult;
            if (!int.TryParse(size, out sizeResult))
            {
                return LineParserResultStatus.InvalidarCharInSize;
            }

            return status;
        }

        private LineParserResultStatus CheckNumberFormat(string number)
        {
            LineParserResultStatus status = LineParserResultStatus.ValidLine;

            if (String.IsNullOrEmpty(number))
            {
                return LineParserResultStatus.NumberNotSent;
            }

            int numberResult;
            if (!int.TryParse(number, out numberResult))
            {
                return LineParserResultStatus.InvalidarCharInNumber;
            }

            return status;
        }

        public LineParserResult Parse()
        {
            LineParserResult result = new LineParserResult();
            
            result.Status = CheckTextFormat();
            if (result.Status != LineParserResultStatus.ValidLine)
            {
                return result;
            }           

            String[] values = text.Split(separator);
            String sizeString = values[sizeIndex];
            String numberString = values[numberIndex];

            result.Status = CheckSizeFormat(sizeString);
            if (result.Status != LineParserResultStatus.ValidLine)
            {
                return result;
            }

            result.Status = CheckNumberFormat(numberString);
            if (result.Status != LineParserResultStatus.ValidLine)
            {
                return result;
            }

            result.Size = int.Parse(sizeString);
            result.Number = numberString;

            return result;
        }
    }
}
