using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace TextTools
{
    public static class ColorTools
    {

        public static string MultiHexToColor(string hexColor)
        {
            return hexColor.AdvancedReplace("#(?:[0-9a-fA-F]{3}){1,2}", "%value%", a => TryHexToColor(a));

            //var line = hexColor.Split('\n');
            //var result = string.Empty;
            //for (int i = 0; i < line.Length; i++)
            //{
            //    result += TryHexToColor(line[i]) + "\n";
            //}
            //return result;
        }

        public static string TryHexToColor(string hexColor)
        {
            try
            {
                return HexToColor(hexColor);
            }
            catch (Exception)
            {
                return hexColor;
            }
        }
        public static string HexToColor(string hexColor)
        {
            //Remove # if present
            if (hexColor.IndexOf('#') != -1)
                hexColor = hexColor.Replace("#", "");

            int red = 0;
            int green = 0;
            int blue = 0;

            if (hexColor.Length == 6)
            {
                //#RRGGBB
                red = int.Parse(hexColor.Substring(0, 2), NumberStyles.AllowHexSpecifier);
                green = int.Parse(hexColor.Substring(2, 2), NumberStyles.AllowHexSpecifier);
                blue = int.Parse(hexColor.Substring(4, 2), NumberStyles.AllowHexSpecifier);
            }
            else if (hexColor.Length == 3)
            {
                //#RGB
                red = int.Parse(hexColor[0].ToString() + hexColor[0].ToString(), NumberStyles.AllowHexSpecifier);
                green = int.Parse(hexColor[1].ToString() + hexColor[1].ToString(), NumberStyles.AllowHexSpecifier);
                blue = int.Parse(hexColor[2].ToString() + hexColor[2].ToString(), NumberStyles.AllowHexSpecifier);
            }

            //return Color.FromArgb(red, green, blue);
            return $"{red} {green} {blue}";
        }
    }
}
