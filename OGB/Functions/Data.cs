using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OGB.Functions
{
    public static class Data
    {
        public static int levelOf(int buildingID, ref WebBrowser wb)
        {
            Regex digitsOnly = new Regex(@"[^\d]");
            List<int> levels = new List<int>();

            HtmlElementCollection theElementCollection = default(HtmlElementCollection);
            theElementCollection = wb.Document.GetElementsByTagName("span");

            foreach (HtmlElement curElement in theElementCollection)
                if (curElement.GetAttribute("classname").ToString().Equals("level"))
                    levels.Add(int.Parse(digitsOnly.Replace(curElement.InnerText, "")));

            switch (buildingID)
            {
                case Globals.Resources.MINE_METAL:
                    return levels[0];

                case Globals.Resources.MINE_CRYSTAL:
                    return levels[1];

                case Globals.Resources.MINE_DEUTER:
                    return levels[2];

                case Globals.Resources.SOLAR_PLANT:
                    return levels[3];

                case Globals.Resources.FUSION_REACTOR:
                    return levels[4];

                // case Globals.Resources.SOLAR_SATELITE:
                //    return levels[5];

                case Globals.Resources.STORAGE_METAL:
                    return levels[6];

                case Globals.Resources.STORAGE_CRYSTAL:
                    return levels[7];

                case Globals.Resources.STORAGE_DEUTER:
                    return levels[8];

                case Globals.Resources.DEN_METAL:
                    return levels[9];

                case Globals.Resources.DEN_CRYSTAL:
                    return levels[10];

                case Globals.Resources.DEN_DEUTER:
                    return levels[11];

            }

            return -1;
        }
        public static int levelOf(String buldingName, ref WebBrowser wb)
        {
            Regex digitsOnly = new Regex(@"[^\d]");
            List<int> levels = new List<int>();

            HtmlElementCollection theElementCollection = default(HtmlElementCollection);
            theElementCollection = wb.Document.GetElementsByTagName("span");

            foreach (HtmlElement curElement in theElementCollection)
                if (curElement.GetAttribute("classname").ToString().Equals("level"))
                    levels.Add(int.Parse(digitsOnly.Replace(curElement.InnerText, "")));

            switch (buldingName)
            {
                case "Metal mine":
                    return levels[0];

                case "Crystal mine":
                    return levels[1];

                case "Deuter mine":
                    return levels[2];

                case "Solar plant":
                    return levels[3];

                case "Fusion reactor":
                    return levels[4];

                // case Globals.Resources.SOLAR_SATELITE:
                //    return levels[5];

                case "Metal storage":
                    return levels[6];

                case "Crystal storage":
                    return levels[7];

                case "Deuter storage":
                    return levels[8];

                case "Metal Den":
                    return levels[9];

                case "Crystal den":
                    return levels[10];

                case "Deuter den":
                    return levels[11];

            }

            return -1;
        }

        public static float getMetal(ref WebBrowser wb)
        {
            return float.Parse(wb.Document.GetElementById("resources_metal").InnerText.Replace('.', ','));
        }

        public static float getCrystal(ref WebBrowser wb)
        {
            return float.Parse(wb.Document.GetElementById("resources_crystal").InnerText.Replace('.', ','));
        }

        public static float getDeuterium(ref WebBrowser wb)
        {
            return float.Parse(wb.Document.GetElementById("resources_deuterium").InnerText.Replace('.', ','));
        }

        public static float getDM(ref WebBrowser wb)
        {
            return float.Parse(wb.Document.GetElementById("resources_darkmatter").InnerText.Replace('.', ','));
        }

        public static float getEnergy(ref WebBrowser wb)
        {
            return float.Parse(wb.Document.GetElementById("resources_energy").InnerText.Replace('.', ','));
        }
    }
}
