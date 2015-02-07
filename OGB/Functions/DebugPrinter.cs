using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OGB.Functions
{
    public partial class DebugPrinter
    {
        private static OGBForm f = null;
        public static void setForm(ref OGBForm form)
        {
            f = form;
        }
        private static String prepare(int mode, String msg)
        {
            String m = "";
            if (mode == Globals.Const.DEBUG_ALL)
                m += "[ALL] ";

            if (mode == Globals.Const.DEBUG_INFO)
                m += "[INFO] ";

            m += (msg + '\n');
            return m;
        }

        public static void print(int mesageType, String msg)
        {
            if (!f.Equals(null))
            {
                String outMsg = prepare(mesageType, msg);
                f.RTB_Debug.AppendText(outMsg);
            }
            else
                throw new NullReferenceException("Could not find form, use setForm method to bind a form for printing data");
            
        }
    }
}
