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
        ValidLine,
        SizeNotSent,
        NumberNotSent,
        SeparatorNotSent,
        EmptyString,
        InvalidarCharInSize,
        InvalidarCharInNumber,
        InvalidRangeForSize,
        ProcessAlreadyDone
    }
}
