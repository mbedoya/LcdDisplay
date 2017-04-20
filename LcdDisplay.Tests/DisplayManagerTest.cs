using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LcdDisplay.Model;

namespace LcdDisplay.Tests
{
    [TestClass]
    public class DisplayManagerTest
    {
        [TestMethod]
        public void ProcessInputs_ReturnedCollectionsHasSameSize_ReturnedCollectionWithSameSize()
        {
            List<string> inputs = new List<string>();
            inputs.Add("3,2");

            List<DisplayElement> elements = DisplayManager.ProcessInputs(inputs, "html");
            Assert.AreEqual(inputs.Count, elements.Count);
        }
    }
}
