using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LcdDisplay.Model
{
    public class LineParserResult
    {
        public int Size { get; set; }
        public String Number { get; set; }
        public LineParserResultStatus Status { get; set; }
    }

    public enum LineParserResultStatus
    {
        ValidLine = 0,
        SizeNotSent = 1,
        NumberNotSent = 2,
        SeparatorNotSent = 3,
        EmptyString = 4,
        InvalidarCharInSize = 5,
        InvalidarCharInNumber = 6,
        InvalidRangeForSize = 7,
        ProcessAlreadyDone = 8
    }
}
