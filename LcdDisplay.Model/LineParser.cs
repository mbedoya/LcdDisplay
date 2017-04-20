using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LcdDisplay.Model
{
    public class LineParser
    {
        private String text;

        public LineParser(String text)
        {
            this.text = text.Trim();
        }

        public LineParserResult Parse()
        {
            LineParserResult result = new LineParserResult();

            if (String.IsNullOrEmpty(text))
            {
                result.Status = LineParserResultStatus.EmptyString;
                return result;
            }

            if (!text.Contains(','))
            {
                result.Status = LineParserResultStatus.NumberNotSent;
                return result;
            }

            String[] values = text.Split(',');

            if (String.IsNullOrEmpty(values[0]))
            {
                result.Status = LineParserResultStatus.SizeNotSent;
                return result;
            }

            int sizeResult;
            if (!int.TryParse(values[0], out sizeResult))
            {
                result.Status = LineParserResultStatus.InvalidarCharInSize;
                return result;
            }

            if (String.IsNullOrEmpty(values[1]))
            {
                result.Status = LineParserResultStatus.NumberNotSent;
                return result;
            }

            int numberResult;
            if (!int.TryParse(values[1], out numberResult))
            {
                result.Status = LineParserResultStatus.InvalidarCharInNumber;
                return result;
            }

            result.Size = sizeResult;
            result.Number = numberResult.ToString();

            result.Status = LineParserResultStatus.ValidLine;
            return result;
        }
    }
}
