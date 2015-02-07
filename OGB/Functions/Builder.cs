using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OGB.Functions
{
    public static class Builder
    {
        //class="fastBuild"
        // <a
        
        public static void Build(int buildingID, ref WebBrowser wb)
        {
            HtmlElementCollection theElementCollection = default(HtmlElementCollection);
            theElementCollection = wb.Document.GetElementsByTagName("a");   // <a
            foreach (HtmlElement curElement in theElementCollection)
            {
                if (curElement.GetAttribute("classname").ToString().Contains("fastBuild"))
                {
                    if (curElement.OuterHtml.Contains("type=" + buildingID.ToString() + "&"))
                    {
                        curElement.RaiseEvent("onclick");
                    }
                }
            }
        }
    }
}
