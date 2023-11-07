using System.Globalization;
using System.Text.RegularExpressions;
using System.Web;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace TextTools
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            cbOperation.Items.Clear();
            var operationList = Enum.GetNames(typeof(OperationEnum));
            for (int i = 0; i < operationList.Length; i++)
            {
                cbOperation.Items.Add(operationList[i].TitleCaseWithSpace());
            }
            cbOperation.SelectedIndex = 1;
            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.ItemSize = new Size(0, 1);
            tabControl1.SizeMode = TabSizeMode.Fixed;

            tbxInput.TextChanged += autoStart;
            tbxAPSPrefix.TextChanged += autoStart;
            tbxAPSSuffix.TextChanged += autoStart;
            cbAuto.CheckedChanged += autoStart;
            tbxSBRegex.TextChanged += autoStart;
            tbxSPSPrefix.TextChanged += autoStart;
            tbxSPSSuffix.TextChanged += autoStart;
        }

        public string InputText
        {
            get
            {
                return tbxInput.Text.Replace("\r\n", "\n");
            }
            set
            {
                tbxInput.Text = value.Replace("\n", "\r\n");
            }
        }
        public string OutputText
        {
            get
            {
                return tbxOutput.Text.Replace("\r\n", "\n");
            }
            set
            {
                tbxOutput.Text = value.Replace("\n", "\r\n");
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            var textinfo = new CultureInfo("en-US", false).TextInfo;
            OperationEnum s = (OperationEnum)Enum.Parse(typeof(OperationEnum), ((string)cbOperation.SelectedItem).Replace(" ", ""));
            switch (s)
            {
                case OperationEnum.Uppercase:
                    OutputText = InputText.ToUpper();
                    break;
                case OperationEnum.TitleCase:
                    OutputText = textinfo.ToTitleCase(InputText.ToLower());
                    break;
                case OperationEnum.TitleCaseWithoutSpace:
                    OutputText = textinfo.ToTitleCase(InputText.ToLower()).Replace(" ", "");
                    break;
                case OperationEnum.TitleCaseWithSpace:
                    OutputText = textinfo.ToTitleCase(InputText.TitleCaseWithSpace());
                    break;
                case OperationEnum.Lowercase:
                    OutputText = InputText.ToLower();
                    break;
                case OperationEnum.SnakeCase:
                    OutputText = InputText.TitleCaseWithSpace().ToLower().Replace(" ", "_").Replace("_\n", "\n");
                    break;
                case OperationEnum.InvertCase:
                    OutputText = InputText.InvertCase();
                    break;
                case OperationEnum.SortLines:
                    OutputText = InputText.SortLines();
                    break;
                case OperationEnum.TrimLinesStart:
                    OutputText = InputText.TrimLinesStart();
                    break;
                case OperationEnum.TrimLinesEnd:
                    OutputText = InputText.TrimLinesEnd();
                    break;
                case OperationEnum.TrimLines:
                    OutputText = InputText.TrimLines();
                    break;
                case OperationEnum.RemoveExtraSpaces:
                    OutputText = InputText.RemoveExtraSpaces();
                    break;
                case OperationEnum.AddCommasToNumbers:
                    OutputText = InputText.AddCommasToNumbers();
                    break;
                case OperationEnum.ReplaceText:
                    replaceOperation();
                    break;
                case OperationEnum.AdvancedReplace:
                    advancedReplaceOperation();
                    break;
                case OperationEnum.SplitText:
                    splitTextOperation();
                    break;
                case OperationEnum.SelectTextByRegex:
                    selectTextByRegexOperation();
                    break;
                case OperationEnum.SelectTextByPrefixSuffix:
                    selectTextByPrefixSuffixOperation();
                    break;
                case OperationEnum.ReverseText:
                    OutputText = InputText.ReverseText();
                    break;
                case OperationEnum.ReverseLine:
                    OutputText = InputText.ReverseLine();
                    break;
                case OperationEnum.StripHtmlTags:
                    OutputText = InputText.StripHTMLTags();
                    break;
                case OperationEnum.AddLineNumbers:
                    addLineNumbersOperation();
                    break;
                case OperationEnum.Base64Encode:
                    OutputText = InputText.Base64Encode();
                    break;
                case OperationEnum.Base64Decode:
                    OutputText = InputText.Base64Decode();
                    break;
                case OperationEnum.Urlencode:
                    OutputText = HttpUtility.UrlEncode(InputText);
                    break;
                case OperationEnum.Urldecode:
                    OutputText = HttpUtility.UrlDecode(InputText);
                    break;
                case OperationEnum.GatheringInALine:
                    OutputText = InputText.Replace("\n", "\\n").Replace("\t", "\\t");
                    break;
                case OperationEnum.ApplyControlCharacter:
                    OutputText = InputText.ToControlChar();
                    break;
                case OperationEnum.FormatJson:
                    break;
                case OperationEnum.RemoveDuplicateLines:
                    break;
                case OperationEnum.RemoveEmptyLines:
                    OutputText = InputText.RemoveEmptyLines();
                    break;
                case OperationEnum.CountCharacters:
                    break;
                case OperationEnum.CountWords:
                    break;
                case OperationEnum.CountLines:
                    break;
                case OperationEnum.NumbersOperations:
                    numbersOperation();
                    break;
                case OperationEnum.TextRepeatLoop:
                    textRepeatLoopOperation();
                    break;
                case OperationEnum.ConvertToAsciiCodeNumber:
                    convertToAsciiCodeNumberOperation();
                    break;
                case OperationEnum.AddPrefixSuffixIntoEachLine:
                    addPrefixSuffixIntoEachLineOperation();
                    break;
                default:
                    break;
            }
        }

        private void advancedReplaceOperation()
        {
            OutputText = InputText.AdvancedReplace(
                tbxPARFindWhat.ToControlChar(),
                tbxPARReplaceWith.ToControlChar(),
                q => q,
                tbxPARSelectedKeyword.Text
                );
        }

        private void textRepeatLoopOperation()
        {
            try
            {
                var data = new List<TextRepeatLoopClass.Loop>();
                foreach (DataGridViewRow row in dgvTextRepeatLoop.Rows)
                {
                    if (row.Cells["dgvcID"].Value == null)
                        continue;
                    var loop = new TextRepeatLoopClass.Loop();
                    loop.ID = int.Parse(row.Cells["dgvcID"].Value.ToString());
                    loop.KeyWord = row.Cells["dgvcKeyWord"].Value.ToString().ToControlChar();
                    loop.FormatString = row.Cells["dgvcFormatString"].Value?.ToString();
                    loop.Start = double.Parse(row.Cells["dgvcStart"].Value.ToString(), CultureInfo.InvariantCulture);
                    loop.End = double.Parse(row.Cells["dgvcEnd"].Value.ToString(), CultureInfo.InvariantCulture);
                    loop.Step = double.Parse(row.Cells["dgvcStep"].Value.ToString(), CultureInfo.InvariantCulture);
                    data.Add(loop);
                }
                var loops = new List<TextRepeatLoopClass.Loop>();
                foreach (DataGridViewRow row in dgvTextRepeatLoop.Rows)
                {
                    if (row.Cells["dgvcID"].Value == null)
                        continue;
                    int id = int.Parse(row.Cells["dgvcID"].Value.ToString());
                    var loopChild = data.First(q => q.ID == id);
                    int parent = int.Parse(row.Cells["dgvcParent"].Value.ToString());
                    if (parent == 0)
                    {
                        loops.Add(loopChild);
                        continue;
                    }
                    var loopParent = data.FirstOrDefault(q => q.ID == parent);
                    if (loopParent == null)
                    {
                        loops.Add(loopChild);
                        continue;
                    }
                    loopParent.InnerLoop.Add(loopChild);
                }
                OutputText = InputText.TextRepeatLoopOperation(loops);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in input data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void selectTextByRegexOperation()
        {
            string result = "";
            string text = InputText;
            if (string.IsNullOrEmpty(tbxSBRegex.ToControlChar()))
            {
                OutputText = "";
                return;
            }
            try
            {
                Match match = Regex.Match(text, tbxSBRegex.ToControlChar());
                while (match.Success)
                {
                    result += $"{match.Value}\n";
                    match = match.NextMatch();
                }
                OutputText = result;
            }
            catch (Exception ex)
            {
                OutputText = "";
            }
        }

        private void selectTextByPrefixSuffixOperation()
        {
            string result = "";
            string text = InputText;
            if (string.IsNullOrEmpty(tbxSPSPrefix.ToControlChar()) || string.IsNullOrEmpty(tbxSPSSuffix.ToControlChar()))
            {
                OutputText = "";
                return;
            }
            try
            {
                Match matchPrefix = Regex.Match(text, tbxSPSPrefix.ToControlChar());
                Match matchSuffix = Regex.Match(text, tbxSPSSuffix.ToControlChar());
                while (matchPrefix.Success && matchSuffix.Success && matchPrefix.Index < matchSuffix.Index)
                {
                    int indexStart = matchPrefix.Index + matchPrefix.Value.Length;
                    int length = matchSuffix.Index - indexStart;
                    result += $"{text.Substring(indexStart, length)}\n";
                    matchPrefix = matchPrefix.NextMatch();
                    matchSuffix = matchSuffix.NextMatch();
                }
                OutputText = result;
            }
            catch (Exception ex)
            {
                OutputText = "";
            }
        }

        private void addPrefixSuffixIntoEachLineOperation()
        {
            string result = "";
            var lins = InputText.Split("\n");
            for (int i = 0; i < lins.Length; i++)
            {
                result += $"{tbxAPSPrefix.Text}{lins[i]}{tbxAPSSuffix.Text}\n";
            }
            OutputText = result;
        }

        private void numbersOperation()
        {
            double sum = 0;
            long count = 0;
            double middle;
            List<double> sortList = new List<double>();
            double t;
            var num = InputText.Split(" ");
            for (int i = 0; i < num.Length; i++)
            {
                if (double.TryParse(num[i], out t))
                {
                    sum += t;
                    count++;
                    sortList.Add(t);
                }
            }
            if (count <= 0)
                return;
            sortList.Sort();
            if (sortList.Count % 2 == 0)
                middle = (sortList[sortList.Count / 2] + sortList[(sortList.Count / 2) + 1]) / 2;
            else if (sortList.Count > 1)
                middle = sortList[(sortList.Count + 1) / 2];
            else
                middle = sortList[0];

            OutputText = $"sum: {sum}\n" +
                $"Count: {count}\n" +
                $"Average: {sum / count}\n" +
                $"Middle: {middle}\n" +
                "Sort: " + sortList.Select(a => a.ToString()).Aggregate((x, y) => $"{x} {y}");
        }

        private void convertToAsciiCodeNumberOperation()
        {
            string result = "";
            string text = InputText;
            for (int i = 0; i < text.Length; i++)
            {
                result += $"{(int)text[i]} ";
            }
            OutputText = result;
        }

        private void addLineNumbersOperation()
        {
            string result = "";
            var lins = InputText.Split("\n");
            for (int i = 0; i < lins.Length; i++)
            {
                result += $"{i + 1} {lins[i]}\n";
            }
            OutputText = result;
        }

        private void splitTextOperation()
        {
            OutputText = tbxPSResultStart.ToControlChar()
                + InputText.Split(tbxPSSeparator.ToControlChar())
                .Aggregate((x, y) => $"{x}{tbxPSResultSeparator.ToControlChar()}{y}")
                + tbxPSResultEnd.ToControlChar();
        }

        private void replaceOperation(string arg = "All")
        {
            StringComparison opsStr = StringComparison.InvariantCultureIgnoreCase;
            RegexOptions opsReg = RegexOptions.IgnoreCase;
            if (cbxPRCaseSensitive.Checked)
            {
                opsStr = StringComparison.CurrentCulture;
                opsReg = RegexOptions.None;
            }
            string replaceWith = tbxPRReplaceWith.Text;
            string inputText = InputText;
            if (cbxPRUseRegexp.Checked)
                replaceWith = replaceWith.ToControlChar();
            if (arg == "Next" || cbPRReplacementNumber.Checked)
            {
                int rep = 0;
                do
                {
                    if (!cbxPRUseRegexp.Checked)
                    {
                        var index = inputText.IndexOf(tbxPRFindWhat.Text, opsStr);
                        if (index >= 0)
                        {
                            inputText = inputText
                               .Substring(0, index + tbxPRFindWhat.Text.Length)
                               .Replace(tbxPRFindWhat.Text, replaceWith, opsStr)
                               + inputText
                               .Substring(index + tbxPRFindWhat.Text.Length);
                        }
                    }
                    else
                    {
                        var math = Regex.Match(inputText, tbxPRFindWhat.Text, opsReg);
                        if (math.Success)
                        {
                            inputText = Regex.Replace(
                                inputText.Substring(0, math.Index + math.Length),
                                tbxPRFindWhat.Text,
                                replaceWith,
                                opsReg)
                                + inputText.Substring(math.Index + math.Length);
                        }
                    }
                    rep++;
                } while (cbPRReplacementNumber.Checked && rep < nuPRReplacementNumber.Value);
                OutputText = inputText;
            }
            else
            {
                if (!cbxPRUseRegexp.Checked)
                {
                    OutputText = inputText.Replace(tbxPRFindWhat.Text, replaceWith, opsStr);
                }
                else
                {
                    OutputText = Regex.Replace(inputText, tbxPRFindWhat.Text, replaceWith, opsReg);
                }
            }
        }

        private void btnInputClear_Click(object sender, EventArgs e)
        {
            InputText = "";
        }

        private void btnOutpotClear_Click(object sender, EventArgs e)
        {
            OutputText = "";
        }

        private void btnOutputToInput_Click(object sender, EventArgs e)
        {
            InputText = OutputText;
        }

        private void btnInputeToOutput_Click(object sender, EventArgs e)
        {
            OutputText = InputText;
        }

        private void cbOperation_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbAuto.Checked)
                btnStart_Click(sender, e);
            OperationEnum s = (OperationEnum)Enum.Parse(typeof(OperationEnum), ((string)cbOperation.SelectedItem).Replace(" ", ""));
            switch (s)
            {
                case OperationEnum.ReplaceText:
                    tabControl1.SelectedTab = pageReplace;
                    break;
                case OperationEnum.AdvancedReplace:
                    tabControl1.SelectedTab = pageAdvancedReplace;
                    break;
                case OperationEnum.SplitText:
                    tabControl1.SelectedTab = pageSplit;
                    break;
                case OperationEnum.AddPrefixSuffixIntoEachLine:
                    tabControl1.SelectedTab = pageAddPrefixSuffix;
                    break;
                case OperationEnum.SelectTextByRegex:
                    tabControl1.SelectedTab = pageSelectByRegex;
                    break;
                case OperationEnum.SelectTextByPrefixSuffix:
                    tabControl1.SelectedTab = pageSelectByPrefixSuffix;
                    break;
                case OperationEnum.TextRepeatLoop:
                    tabControl1.SelectedTab = pageTextRepeatLoop;
                    break;
                default:
                    tabControl1.SelectedTab = pageBlank;
                    break;
            }
        }
        private void autoStart(object sender, EventArgs e)
        {
            if (cbAuto.Checked)
                btnStart_Click(sender, e);
        }

        private void btnInputCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(InputText);
        }

        private void btnOutputCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(OutputText);
        }

        private void btnPRReplaceAll_Click(object sender, EventArgs e)
        {
            replaceOperation("All");
        }

        private void btnReplaceNext_Click(object sender, EventArgs e)
        {
            replaceOperation("Next");
        }

        private void cbPRReplacementNumber_CheckedChanged(object sender, EventArgs e)
        {
            nuPRReplacementNumber.Enabled = cbPRReplacementNumber.Checked;
        }

    }
}