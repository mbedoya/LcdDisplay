using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LcdDisplay.Model;

namespace LcdDisplay.Tests
{
    [TestClass]
    public class LineParserTest
    {
        [TestMethod]
        public void Parse_BasicLineIsValid_LineValidResult()
        {
            String line = "0,0";
            LineParserResult result = new LineParser(line).Parse();
            Assert.AreEqual(true, result.Status == LineParserResultStatus.ValidLine);
        }
    }
}
