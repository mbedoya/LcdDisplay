using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LcdDisplay.Model;

namespace LcdDisplay.Tests
{
    [TestClass]
    public class IntegrationTest
    {
        [TestMethod]
        public void ProcessInputs_2LinesSuccessfullyProcessed_ValuesChecked()
        {
            List<String> inputs = new List<string>();
            inputs.Add("2,1");
            inputs.Add("0,0");

            List<DisplayElement> elements = DisplayManager.ProcessInputs(inputs, "html");
            Assert.AreEqual("&nbsp;<br />|<br />|<br />&nbsp;<br />|<br />|<br />&nbsp;<br />", elements[0].LcdDigits[0]);
        }
    }
}
