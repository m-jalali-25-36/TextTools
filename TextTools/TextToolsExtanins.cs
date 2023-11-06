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
        public static string ToControlChar(this TextBox textBox)
        {
            return textBox.Text.Replace("\\n", "\n")
                .Replace("\\\\", "\\")
                .Replace("\\r", "\r")
                .Replace("\\a", "\a")
                .Replace("\\b", "\b")
                .Replace("\\f", "\f")
                .Replace("\\'", "\'")
                .Replace("\\\"", "\"")
                .Replace("\\v", "\v")
                .Replace("\\t", "\t");
        }
        public static string ToControlChar(this string text)
        {
            return text.Replace("\\n", "\n")
                .Replace("\\\\", "\\")
                .Replace("\\r", "\r")
                .Replace("\\a", "\a")
                .Replace("\\b", "\b")
                .Replace("\\f", "\f")
                .Replace("\\'", "\'")
                .Replace("\\\"", "\"")
                .Replace("\\v", "\v")
                .Replace("\\t", "\t");
        }
        public static string TitleCaseWithSpace(this string text)
        {
            for (int i = 1; i < text.Length; i++)
            {
                if (text[i] >= 'A' && text[i] <= 'Z' && text[i - 1] != ' ' && text[i - 1] != '\n')
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
        public static string InvertCase(this string text)
        {
            string result = "";
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] >= 'A' && text[i] <= 'Z')
                    result += (char)((int)text[i] + (int)'a' - (int)'A');
                else if (text[i] >= 'a' && text[i] <= 'z')
                    result += (char)((int)text[i] - (int)'a' + (int)'A');
                else
                    result += text[i];
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
        public static string ReverseText(this string text)
        {
            string result = "";
            for (int i = text.Length - 1; i >= 0; i--)
            {
                result += text[i];
            }
            return result;
        }
        public static string ReverseLine(this string text)
        {
            string result = "";
            var lins = text.Split("\n");
            for (int i = 0; i < lins.Length; i++)
            {
                result += lins[i].ReverseText() + "\n";
            }
            return result;
        }
    }
}
