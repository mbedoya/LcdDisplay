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
            this.text = text;
        }

        public LineParserResult Parse()
        {
            LineParserResult result = new LineParserResult();
            result.Status = LineParserResultStatus.ValidLine;
            return result;
        }
    }
}
