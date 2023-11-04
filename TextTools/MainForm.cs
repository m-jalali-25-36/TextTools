using System.Globalization;

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
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            var textinfo = new CultureInfo("en-US", false).TextInfo;
            OperationEnum s = (OperationEnum)Enum.Parse(typeof(OperationEnum), ((string)cbOperation.SelectedItem).Replace(" ", ""));
            switch (s)
            {
                case OperationEnum.Uppercase:
                    tbxOutput.Text = tbxInpute.Text.ToUpper();
                    break;
                case OperationEnum.TitleCase:
                    tbxOutput.Text = textinfo.ToTitleCase(tbxInpute.Text.ToLower());
                    break;
                case OperationEnum.TitleCaseWithoutSpace:
                    tbxOutput.Text = textinfo.ToTitleCase(tbxInpute.Text.ToLower()).Replace(" ", "");
                    break;
                case OperationEnum.TitleCaseWithSpace:
                    tbxOutput.Text = textinfo.ToTitleCase(tbxInpute.Text.TitleCaseWithSpace());
                    break;
                case OperationEnum.Lowercase:
                    tbxOutput.Text = tbxInpute.Text.ToLower();
                    break;
                case OperationEnum.TrimLinesStart:
                    tbxOutput.Text = tbxInpute.Text.TrimLinesStart();
                    break;
                case OperationEnum.TrimLinesEnd:
                    tbxOutput.Text = tbxInpute.Text.TrimLinesEnd();
                    break;
                case OperationEnum.TrimLines:
                    tbxOutput.Text = tbxInpute.Text.TrimLines();
                    break;
                case OperationEnum.RemoveExtraSpaces:
                    tbxOutput.Text = tbxInpute.Text.RemoveExtraSpaces();
                    break;
                case OperationEnum.ReplaceText:
                    break;
                case OperationEnum.SplitText:
                    break;
                case OperationEnum.ReverseText:
                    break;
                case OperationEnum.AddLineNumbers:
                    break;
                case OperationEnum.Urlencode:
                    break;
                case OperationEnum.Urldecode:
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

        private void btnInputClear_Click(object sender, EventArgs e)
        {
            tbxInpute.Text = "";
        }

        private void btnOutpotClear_Click(object sender, EventArgs e)
        {
            tbxOutput.Text = "";
        }

        private void btnOutputToInput_Click(object sender, EventArgs e)
        {
            tbxInpute.Text = tbxOutput.Text;
        }

        private void btnInputeToOutput_Click(object sender, EventArgs e)
        {
            tbxOutput.Text = tbxInpute.Text;
        }

        private void cbOperation_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbAuto.Checked)
                btnStart_Click(sender, e);
        }
        private void tbxInpute_TextChanged(object sender, EventArgs e)
        {
            if (cbAuto.Checked)
                btnStart_Click(sender, e);
        }

        private void btnInputCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(tbxInpute.Text);
        }

        private void btnOutputCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(tbxOutput.Text);
        }

    }
}