using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TextTools
{
    public static class TextToolsExtensions
    {
        public static string ToRegexChar(this TextBox textBox)
        {
            return textBox.Text.Replace("\\n", "\n").Replace("\\\\", "\\").Replace("\\t", "\t");
        }
        public static string ToRegexChar(this string text)
        {
            return text.Replace("\\n", "\n").Replace("\\\\", "\\").Replace("\\t", "\t");
        }
        public static string TitleCaseWithSpace(this string text)
        {
            for (int i = 1; i < text.Length; i++)
            {
                if (text[i] >= 'A' && text[i] <= 'Z' && text[i - 1] != ' ')
                {
                    text = text.Insert(i, " ");
                    i++;
                }
            }
            return text;
        }
        public static string TrimLinesStart(this string text)
        {
            string result = "";
            var lins = text.Split("\n");
            for (int i = 0; i < lins.Length; i++)
            {
                result += lins[i].TrimStart() + "\n";
            }
            return result;
        }
        public static string TrimLinesEnd(this string text)
        {
            string result = "";
            var lins = text.Split("\n");
            for (int i = 0; i < lins.Length; i++)
            {
                result += lins[i].TrimEnd() + "\n";
            }
            return result;
        }
        public static string TrimLines(this string text)
        {
            string result = "";
            var lins = text.Split("\n");
            for (int i = 0; i < lins.Length; i++)
            {
                result += lins[i].Trim() + "\n";
            }
            return result;
        }
        public static string RemoveExtraSpaces(this string text)
        {
            return Regex.Replace(text, @"[ ]+", " ").TrimLines();
        }
    }
}
