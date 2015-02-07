using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OGB.Functions
{
    public static class Navigator
    {
        public static String getLocation(ref WebBrowser wb)
        {
            if (wb.Url.Equals(Globals.Url.Overview))
                return "Overwiew";
            if (wb.Url.Equals(Globals.Url.Resources))
                return "Resources";
            if (wb.Url.Equals(Globals.Url.Facilities))
                return "Facilities";
            if (wb.Url.Equals(Globals.Url.Research))
                return "Research";
            if (wb.Url.Equals(Globals.Url.Shipyard))
                return "Shipyard";
            if (wb.Url.Equals(Globals.Url.Defence))
                return "Defence";
            if (wb.Url.Equals(Globals.Url.Fleet))
                return "Fleet";
            if (wb.Url.Equals(Globals.Url.Galaxy))
                return "Galaxy";
            if (wb.Url.Equals(Globals.Url.Alliance))
                return "Alliance";

            return null;
        }

    }
}
