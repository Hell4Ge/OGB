using System.Windows.Forms;

namespace OGB.Functions
{
    public static class Clock
    {
        public static bool inProgress(ref WebBrowser wb)
        {
            HtmlElementCollection theElementCollection = default(HtmlElementCollection);
            theElementCollection = wb.Document.GetElementsByTagName("span");
            foreach (HtmlElement curElement in theElementCollection)
            {
                if (curElement.GetAttribute("id").Equals("test") && curElement.GetAttribute("classname").Equals("time") && curElement.GetAttribute("name").Equals("zeit"))
                    return true;
            }
            return false;
        }
    }
}
