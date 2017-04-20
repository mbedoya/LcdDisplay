using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LcdDisplay.Model
{
    public class DisplayElement
    {
        public string SourceText { get; set; }
        public List<String> LcdDigits { get; set; }
        public LineParserResult LineStatus { get; set; }
    }
}
