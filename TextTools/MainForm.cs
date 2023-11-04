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
                cbOperation.Items.Add(Enum.Parse(typeof(OperationEnum), operationList[i]));
            }
            cbOperation.SelectedIndex = 1;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            var textinfo = new CultureInfo("en-US", false).TextInfo;
            switch ((OperationEnum)cbOperation.SelectedItem)
            {
                case OperationEnum.Uppercase:
                    tbxOutput.Text = tbxInpute.Text.ToUpper();
                    break;
                case OperationEnum.TitleCase:
                    tbxOutput.Text = textinfo.ToTitleCase(tbxInpute.Text.ToLower());
                    break;
                case OperationEnum.Lowercase:
                    tbxOutput.Text = tbxInpute.Text.ToLower();
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

        private void tbxInpute_TextChanged(object sender, EventArgs e)
        {
            if (cbAuto.Checked)
                btnStart_Click(sender, e);
        }
    }
}