using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OGB.Functions
{
    public static class Login
    {
        private static String uName = "";
        private static String uPassword = "";
        private static String uServer = "";

        public static void setCredentials(String acc, String pw, String server)
        {
            uName = acc;
            uPassword = pw;
            uServer = server;
        }

        public static void Proceed(ref WebBrowser wb)
        {
            HtmlElementCollection theElementCollection = default(HtmlElementCollection);
            theElementCollection = wb.Document.GetElementsByTagName("option");
            foreach (HtmlElement curElement in theElementCollection)
            {
                if (curElement.InnerHtml.Contains(uName))
                {
                    curElement.SetAttribute("selected", "selected");
                }
            }

            if (wb.Document.GetElementById("usernameLogin") != null)
            {
                wb.Document.GetElementById("usernameLogin").SetAttribute("value", uName);
            }

            if (wb.Document.GetElementById("passwordLogin") != null)
            {
                wb.Document.GetElementById("passwordLogin").SetAttribute("value", uPassword);
                wb.Document.GetElementById("loginSubmit").InvokeMember("click");
            }
        }

    }
}
