using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LcdDisplay.Model.Displays
{
    public class DisplayFactory
    {
        public static DisplayProvider CreateDisplay(string displayType)
        {
            if (displayType.ToLower() == "html")
            {
                return new HtmlDisplay();
            }

            throw new Exception(String.Format("Display type {0} is not supported", displayType));
        }
    }
}
