using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LcdDisplay.Model.Displays;

namespace LcdDisplay.Tests
{
    [TestClass]
    public class HtmlDisplayTest
    {

        [TestMethod]
        public void GetFromDigit_NumberReturnedHasData_ReturnedNumberHasData()
        {
            HtmlDisplay display = new HtmlDisplay();
            String result = display.GetFromDigit(1, "1");
            Assert.AreEqual(true, !String.IsNullOrEmpty(result));
        }

        [TestMethod]
        public void GetFromDigit_Number1InSize2IsWhatExpected_ExpectedText()
        {
            HtmlDisplay display = new HtmlDisplay();
            String result = display.GetFromDigit(2, "1");
            Assert.AreEqual("&nbsp;<br />|<br />|<br />&nbsp;<br />|<br />|<br />&nbsp;<br />", result);
        }

        [TestMethod]
        public void GetFromDigit_Number1InSize1IsWhatExpected_ExpectedText()
        {
            HtmlDisplay display = new HtmlDisplay();
            String result = display.GetFromDigit(1, "1");
            Assert.AreEqual("&nbsp;<br />|<br />&nbsp;<br />|<br />&nbsp;<br />", result);
        }

        [TestMethod]
        public void GetFromDigit_Number2InSize2IsWhatExpected_ExpectedText()
        {
            HtmlDisplay display = new HtmlDisplay();
            String result = display.GetFromDigit(2, "2");
            Assert.AreEqual("--&nbsp;<br />&nbsp;&nbsp;|<br />&nbsp;&nbsp;|<br />--&nbsp;<br />|&nbsp;&nbsp;<br />|&nbsp;&nbsp;<br />--&nbsp;<br />", result);
        }
    }
}
