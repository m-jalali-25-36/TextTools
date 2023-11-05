using System.Globalization;
using System.Text.RegularExpressions;
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
                case OperationEnum.ReplaceText:
                    replaceOperation();
                    break;
                case OperationEnum.SplitText:
                    splitTextOperation();
                    break;
                case OperationEnum.ReverseText:
                    OutputText = InputText.ReverseText();
                    break;
                case OperationEnum.ReverseLine:
                    OutputText = InputText.ReverseLine();
                    break;
                case OperationEnum.AddLineNumbers:
                    addLineNumbersOperation();
                    break;
                case OperationEnum.Urlencode:
                    break;
                case OperationEnum.Urldecode:
                case OperationEnum.GatheringInALine:
                    gatheringInALineOperation();
                    break;
                case OperationEnum.FormatJson:
                    break;
                case OperationEnum.RemoveDuplicateLines:
                    break;
                case OperationEnum.RemoveEmptyLines:
                    break;
                case OperationEnum.CountCharacters:
                    break;
                case OperationEnum.CountWords:
                    break;
                case OperationEnum.CountLines:
                    break;
                default:
                    break;
            }
        }

        private void gatheringInALineOperation()
        {
            OutputText = InputText.Replace("\n", "\\n").Replace("\t", "\\t");
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
            OutputText = tbxPSResultStart.ToRegexChar()
                + InputText.Split(tbxPSSeparator.ToRegexChar())
                .Aggregate((x, y) => $"{x}{tbxPSResultSeparator.ToRegexChar()}{y}")
                + tbxPSResultEnd.ToRegexChar();
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
                replaceWith = replaceWith.ToRegexChar();
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
                case OperationEnum.SplitText:
                    tabControl1.SelectedTab = pageSplit;
                    break;
                default:
                    tabControl1.SelectedTab = pageBlank;
                    break;
            }
        }
        private void tbxInpute_TextChanged(object sender, EventArgs e)
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