
using LcdDisplay.Model.Displays;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LcdDisplay.Model
{
    public class DisplayManager
    {
        public static List<DisplayElement> ProcessInputs(List<string> inputs, string displayType)
        {
            string doneLine = "0,0";
            bool processingMustStop = false;

            List<DisplayElement> resultList = new List<DisplayElement>();

            foreach (string item in inputs)
            {
                if (item == doneLine)
                {
                    processingMustStop = true;
                }

                DisplayElement element = new DisplayElement();

                LineParser parser = new LineParser(item);
                element.LineStatus = parser.Parse();
                element.SourceText = item;

                if (processingMustStop)
                {
                     element.LineStatus.Status = LineParserResultStatus.ProcessAlreadyDone;
                }else
                {
                    if (element.LineStatus.Status == LineParserResultStatus.ValidLine)
                    {
                        element.LcdDigits = DisplayFactory.CreateDisplay(displayType).GetFromNumber(element.LineStatus.Size, element.LineStatus.Number);
                    }
                }

                resultList.Add(element);
            }

            return resultList;
        }
    }
}
