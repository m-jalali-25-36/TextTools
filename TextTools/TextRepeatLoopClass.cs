using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static TextTools.TextRepeatLoopClass;

namespace TextTools
{
    public static class TextRepeatLoopClass
    {
        public static string TextRepeatLoopOperation(this string text, List<Loop> loops)
        {
            string result = "";
            string temp = "";
            double repeat = loops.Max(q => q.Repeat);
            while (repeat > 0)
            {
                temp = text;
                foreach (var loop in loops)
                {
                    if (!loop.IsNext())
                        loop.Reset();
                    temp = Regex.Replace(temp, loop.KeyWord, loop.GetIndex());
                    loop.Next();
                }
                foreach (var loop in loops)
                {
                    if (loop.InnerLoop == null || loop.InnerLoop.Count == 0)
                        continue;
                    temp = temp.TextRepeatLoopOperation(loop.InnerLoop);
                }
                result += temp;
                repeat--;
            }
            return result;
        }
        public class Loop
        {
            private bool isStart = false;
            public int ID;
            public string KeyWord;
            public string? FormatString;
            public double Index;
            public double Start;
            public double End;
            public double Step;
            public long Repeat { get => (long)((this.End - this.Start) / this.Step); }
            public List<Loop> InnerLoop { get; set; } = new List<Loop>();

            public string GetIndex()
            {
                if (!isStart)
                    Reset();
                return this.Index.ToString(this.FormatString);
            }
            public void Reset()
            {
                this.Index = this.Start;
                isStart = true;
            }
            public bool IsNext()
            {
                if (!isStart)
                    Reset();
                if (this.Step > 0)
                    return this.Index < this.End;

                return this.Index > this.End;
            }
            public void Next()
            {
                if (!isStart)
                    Reset();
                this.Index += this.Step;
            }

        }
    }
}
