﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
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
        public static string SortLines(this string text)
        {
            var lins = text.Split("\n").ToList();
            lins.Sort();
            return lins.Aggregate((x, y) => $"{x}\n{y}");
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
        public static string RemoveEmptyLines(this string text)
        {
            string result = "";
            var lins = text.Split("\n");
            for (int i = 0; i < lins.Length; i++)
            {
                if (!string.IsNullOrWhiteSpace(lins[i]))
                    result += lins[i] + "\n";
            }
            return result;
        }
        public static string AdvancedReplace(this string text, string selectPattern, string replacement, Func<string, string> func, string replacePattern = "%value%", RegexOptions regenOption = RegexOptions.None)
        {
            string result = "";
            int startIndex = 0;
            if (func == null)
                func = q => q;
            Match match = Regex.Match(text, selectPattern, regenOption);
            while (match.Success)
            {
                result += text.Substring(startIndex, match.Index - startIndex) +
                       Regex.Replace(replacement, replacePattern, func(match.Value));
                startIndex = match.Index + match.Length;
                match = match.NextMatch();
            }
            return result + text.Substring(startIndex);
        }
        public static string AddCommasToNumbers(this string text)
        {
            text = text.AdvancedReplace("^[0-9,]+[./]?[0-9,]*( |\n)",
                "%value%\n",
                q => string.Format("{0:#,###.#}", double.Parse(q.Replace("/", ".").Replace(",", ""), CultureInfo.InvariantCulture)),
                regenOption: RegexOptions.Multiline
                );
            text = text.AdvancedReplace(" [0-9,]+[./]?[0-9,]* ",
                " %value% ",
                q => string.Format("{0:#,###.#}", double.Parse(q.Replace("/", ".").Replace(",", ""), CultureInfo.InvariantCulture)),
                regenOption: RegexOptions.Multiline
                );
            return text;
        }
        public static string StripHTMLTags(this string text)
        {
            return Regex.Replace(text, "<.*?>", " ").RemoveExtraSpaces().RemoveEmptyLines();
        }
        public static string Base64Encode(this string plainText)
        {
            try
            {
                var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
                return System.Convert.ToBase64String(plainTextBytes);
            }
            catch (Exception)
            {
                return "";
            }
        }
        public static string Base64Decode(this string base64EncodedData)
        {
            try
            {
                var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
                return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
            }
            catch (Exception)
            {
                return "";
            }
        }

        public static string PersianNumbersToEnglish(this string input)
        {
            string[] persian = new string[10] { "۰", "۱", "۲", "۳", "۴", "۵", "۶", "۷", "۸", "۹" };

            for (int j = 0; j < persian.Length; j++)
                input = input.Replace(persian[j], j.ToString());

            return input;
        }
    }
}
