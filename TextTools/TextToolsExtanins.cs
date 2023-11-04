using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextTools
{
    public static class TextToolsExtensions
    {
        public static string TitleCaseWithSpace(this string text)
        {
            for (int i = 1; i < text.Length; i++)
            {
                if (text[i] >= 'A' && text[i] <= 'Z' && text[i - 1] != ' ')
                {
                    text = text.Insert(i , " ");
                    i++;
                }
            }
            return text;
        }
    }
}
