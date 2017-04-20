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
            String line = "1,0";
            LineParserResult result = new LineParser(line).Parse();
            Assert.AreEqual(true, result.Status == LineParserResultStatus.ValidLine);
        }

        [TestMethod]
        public void Parse_BasicLineIsValid_SizeReturned()
        {
            String line = "1,0";
            LineParserResult result = new LineParser(line).Parse();
            Assert.AreEqual(true, result.Size >= 0);
        }

        [TestMethod]
        public void Parse_BasicLineIsValid_NumberReturned()
        {
            String line = "1,0";
            LineParserResult result = new LineParser(line).Parse();
            Assert.AreEqual(true, !String.IsNullOrEmpty(result.Number));
        }

        [TestMethod]
        public void Parse_SizeNotSent_SizeNotSentResult()
        {
            String line = ",0";
            LineParserResult result = new LineParser(line).Parse();
            Assert.AreEqual(true, result.Status == LineParserResultStatus.SizeNotSent);
        }

        [TestMethod]
        public void Parse_NumberNotSent_NumberNotSentResult()
        {
            String line = "1,";
            LineParserResult result = new LineParser(line).Parse();
            Assert.AreEqual(true, result.Status == LineParserResultStatus.NumberNotSent);
        }

        [TestMethod]
        public void Parse_SeparatorNotSent_SeparatorNotSentResult()
        {
            String line = "11";
            LineParserResult result = new LineParser(line).Parse();
            Assert.AreEqual(true, result.Status == LineParserResultStatus.NumberNotSent);
        }

        [TestMethod]
        public void Parse_EmptyStringSent_EmptyStringResult()
        {
            String line = "";
            LineParserResult result = new LineParser(line).Parse();
            Assert.AreEqual(true, result.Status == LineParserResultStatus.EmptyString);
        }

        [TestMethod]
        public void Parse_CharSentAsSize_InvalidarCharInSizeResult()
        {
            String line = "a,3";
            LineParserResult result = new LineParser(line).Parse();
            Assert.AreEqual(true, result.Status == LineParserResultStatus.InvalidarCharInSize);
        }

        [TestMethod]
        public void Parse_CharSentInNumber_InvalidarCharInNumberResult()
        {
            String line = "2,a";
            LineParserResult result = new LineParser(line).Parse();
            Assert.AreEqual(true, result.Status == LineParserResultStatus.InvalidarCharInNumber);
        }

        [TestMethod]
        public void Parse_ReturnedNumberIsWhatExpected_ExpectedNumber()
        {
            String line = "2,3";
            LineParserResult result = new LineParser(line).Parse();
            Assert.AreEqual("3", result.Number);
        }

        [TestMethod]
        public void Parse_ReturnedSizeIsWhatExpected_ExpectedSize()
        {
            String line = "2,3";
            LineParserResult result = new LineParser(line).Parse();
            Assert.AreEqual(2, result.Size);
        }

        [TestMethod]
        public void Parse_SizeIsLowerThanExpecetd_InvalidRangeForSize()
        {
            String line = "0,1";
            LineParserResult result = new LineParser(line).Parse();
            Assert.AreEqual(true, result.Status == LineParserResultStatus.InvalidRangeForSize);
        }

        [TestMethod]
        public void Parse_SizeIsGreaterThanExpecetd_InvalidRangeForSize()
        {
            String line = "11,1";
            LineParserResult result = new LineParser(line).Parse();
            Assert.AreEqual(true, result.Status == LineParserResultStatus.InvalidRangeForSize);
        }
        
    }
}
