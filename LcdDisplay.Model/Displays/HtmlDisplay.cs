using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LcdDisplay.Model.Displays
{
    public class HtmlDisplay : DisplayProvider
    {
        public HtmlDisplay()
        {

        }

        public override string GetLineBreak()
        {
            return "<br />";
        }

        public override string GetEspaceChar()
        {
            return "&nbsp;";
        }
        
    }
}
