namespace TextTools
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tbxInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInputeToOutput = new System.Windows.Forms.Button();
            this.btnInputClear = new System.Windows.Forms.Button();
            this.btnInputCopy = new System.Windows.Forms.Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.cbOperation = new System.Windows.Forms.ComboBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.cbAuto = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.pageBlank = new System.Windows.Forms.TabPage();
            this.pageReplace = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxPRFindWhat = new System.Windows.Forms.TextBox();
            this.tbxPRReplaceWith = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nuPRReplacementNumber = new System.Windows.Forms.NumericUpDown();
            this.cbPRReplacementNumber = new System.Windows.Forms.CheckBox();
            this.btnReplaceNext = new System.Windows.Forms.Button();
            this.cbxPRCaseSensitive = new System.Windows.Forms.CheckBox();
            this.btnPRReplaceAll = new System.Windows.Forms.Button();
            this.cbxPRUseRegexp = new System.Windows.Forms.CheckBox();
            this.pageSplit = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxPSSeparator = new System.Windows.Forms.TextBox();
            this.tbxPSResultStart = new System.Windows.Forms.TextBox();
            this.tbxPSResultSeparator = new System.Windows.Forms.TextBox();
            this.tbxPSResultEnd = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tbxOutput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOutputToInput = new System.Windows.Forms.Button();
            this.btnOutputClear = new System.Windows.Forms.Button();
            this.btnOutputCopy = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pageAddPrefixSuffix = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.label11 = new System.Windows.Forms.Label();
            this.tbxAPSPrefix = new System.Windows.Forms.TextBox();
            this.tbxAPSSuffix = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.pageReplace.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuPRReplacementNumber)).BeginInit();
            this.pageSplit.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.pageAddPrefixSuffix.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 44);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(704, 324);
            this.splitContainer1.SplitterDistance = 195;
            this.splitContainer1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.tbxInput, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnInputeToOutput, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnInputClear, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnInputCopy, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.950617F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.04939F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(195, 324);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tbxInput
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.tbxInput, 4);
            this.tbxInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxInput.Location = new System.Drawing.Point(3, 31);
            this.tbxInput.Multiline = true;
            this.tbxInput.Name = "tbxInput";
            this.tbxInput.Size = new System.Drawing.Size(189, 290);
            this.tbxInput.TabIndex = 1;
            this.tbxInput.TextChanged += new System.EventHandler(this.tbxInpute_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Input";
            // 
            // btnInputeToOutput
            // 
            this.btnInputeToOutput.AutoSize = true;
            this.btnInputeToOutput.Location = new System.Drawing.Point(161, 3);
            this.btnInputeToOutput.Name = "btnInputeToOutput";
            this.btnInputeToOutput.Size = new System.Drawing.Size(31, 22);
            this.btnInputeToOutput.TabIndex = 3;
            this.btnInputeToOutput.Text = ">";
            this.toolTip1.SetToolTip(this.btnInputeToOutput, "Move To Output");
            this.btnInputeToOutput.UseVisualStyleBackColor = true;
            // 
            // btnInputClear
            // 
            this.btnInputClear.AutoSize = true;
            this.btnInputClear.Location = new System.Drawing.Point(130, 3);
            this.btnInputClear.Name = "btnInputClear";
            this.btnInputClear.Size = new System.Drawing.Size(25, 22);
            this.btnInputClear.TabIndex = 4;
            this.btnInputClear.Text = "C";
            this.toolTip1.SetToolTip(this.btnInputClear, "Clear");
            this.btnInputClear.UseVisualStyleBackColor = true;
            this.btnInputClear.Click += new System.EventHandler(this.btnInputClear_Click);
            // 
            // btnInputCopy
            // 
            this.btnInputCopy.Location = new System.Drawing.Point(80, 3);
            this.btnInputCopy.Name = "btnInputCopy";
            this.btnInputCopy.Size = new System.Drawing.Size(44, 22);
            this.btnInputCopy.TabIndex = 5;
            this.btnInputCopy.Text = "Copy";
            this.btnInputCopy.UseVisualStyleBackColor = true;
            this.btnInputCopy.Click += new System.EventHandler(this.btnInputCopy_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.tableLayoutPanel4);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.tableLayoutPanel3);
            this.splitContainer2.Size = new System.Drawing.Size(505, 324);
            this.splitContainer2.SplitterDistance = 306;
            this.splitContainer2.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 6;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel4.Controls.Add(this.cbOperation, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnStart, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.cbAuto, 2, 1);
            this.tableLayoutPanel4.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.tabControl1, 0, 2);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 5;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(306, 324);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // cbOperation
            // 
            this.tableLayoutPanel4.SetColumnSpan(this.cbOperation, 4);
            this.cbOperation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbOperation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOperation.FormattingEnabled = true;
            this.cbOperation.Items.AddRange(new object[] {
            "Uppercase",
            "Title Case",
            "Lowercase",
            "Count characters",
            "Count words",
            "Count lines",
            "Rotate 13",
            "Sort lines alpha (case insensitive)",
            "Sort lines alpha",
            "Word frequency",
            "Character frequency",
            "Column from table",
            "Trim lines start",
            "Trim lines end",
            "Trim lines",
            "Replace text with new line",
            "Replace text",
            "Replace text regexp",
            "Format JSON",
            "URLEncode",
            "URLDecode",
            "base64encode",
            "base64decode",
            "Add line numbers",
            "Split text",
            "Reverse text",
            "Generate numbers",
            "Unix to date",
            "Identify Hash",
            "Prefix/Suffix lines",
            "Format Numbers",
            "Underscore",
            "Strikeout",
            "Shuffle",
            "Remove duplicate lines",
            "Remove empty lines",
            "Expand template",
            "Indent with spaces",
            "Slugify - Converts string to slug replacing non-ascii symbols with",
            "Strip non-alphanumeric - Strips non-alphanumeric characters ↑Uppercase",
            "Title Case",
            "Lowercase",
            "Count characters",
            "Count words",
            "Count lines",
            "Rotate 13",
            "Sort lines alpha (case insensitive)",
            "Sort lines alpha",
            "Word frequency",
            "Character frequency",
            "Column from table",
            "Trim lines start",
            "Trim lines end",
            "Trim lines",
            "Replace text with new line",
            "Replace text",
            "Replace text regexp",
            "Format JSON",
            "URLEncode",
            "URLDecode",
            "base64encode",
            "base64decode",
            "Add line numbers",
            "Split text",
            "Reverse text",
            "Generate numbers",
            "Unix to date",
            "Identify Hash",
            "Prefix/Suffix lines",
            "Format Numbers",
            "Underscore",
            "Strikeout",
            "Shuffle",
            "Remove duplicate lines",
            "Remove empty lines",
            "Expand template",
            "Indent with spaces",
            "Slugify",
            "Strip non-alphanumeric"});
            this.cbOperation.Location = new System.Drawing.Point(105, 3);
            this.cbOperation.Name = "cbOperation";
            this.cbOperation.Size = new System.Drawing.Size(198, 23);
            this.cbOperation.TabIndex = 0;
            this.cbOperation.SelectedIndexChanged += new System.EventHandler(this.cbOperation_SelectedIndexChanged);
            // 
            // btnStart
            // 
            this.tableLayoutPanel4.SetColumnSpan(this.btnStart, 2);
            this.btnStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStart.Location = new System.Drawing.Point(3, 32);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(96, 23);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // cbAuto
            // 
            this.cbAuto.AutoSize = true;
            this.tableLayoutPanel4.SetColumnSpan(this.cbAuto, 2);
            this.cbAuto.Location = new System.Drawing.Point(105, 32);
            this.cbAuto.Name = "cbAuto";
            this.cbAuto.Size = new System.Drawing.Size(52, 19);
            this.cbAuto.TabIndex = 2;
            this.cbAuto.Text = "Auto";
            this.cbAuto.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.tableLayoutPanel4.SetColumnSpan(this.label3, 2);
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Operation ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tabControl1
            // 
            this.tableLayoutPanel4.SetColumnSpan(this.tabControl1, 6);
            this.tabControl1.Controls.Add(this.pageBlank);
            this.tabControl1.Controls.Add(this.pageReplace);
            this.tabControl1.Controls.Add(this.pageSplit);
            this.tabControl1.Controls.Add(this.pageAddPrefixSuffix);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabControl1.Location = new System.Drawing.Point(3, 61);
            this.tabControl1.Name = "tabControl1";
            this.tableLayoutPanel4.SetRowSpan(this.tabControl1, 3);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(300, 260);
            this.tabControl1.TabIndex = 4;
            // 
            // pageBlank
            // 
            this.pageBlank.Location = new System.Drawing.Point(4, 24);
            this.pageBlank.Name = "pageBlank";
            this.pageBlank.Size = new System.Drawing.Size(292, 232);
            this.pageBlank.TabIndex = 2;
            this.pageBlank.Text = "blank";
            this.pageBlank.UseVisualStyleBackColor = true;
            // 
            // pageReplace
            // 
            this.pageReplace.Controls.Add(this.tableLayoutPanel5);
            this.pageReplace.Location = new System.Drawing.Point(4, 24);
            this.pageReplace.Name = "pageReplace";
            this.pageReplace.Padding = new System.Windows.Forms.Padding(3);
            this.pageReplace.Size = new System.Drawing.Size(292, 232);
            this.pageReplace.TabIndex = 0;
            this.pageReplace.Text = "Replace";
            this.pageReplace.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.tbxPRFindWhat, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.tbxPRReplaceWith, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.label6, 0, 3);
            this.tableLayoutPanel5.Controls.Add(this.nuPRReplacementNumber, 1, 3);
            this.tableLayoutPanel5.Controls.Add(this.cbPRReplacementNumber, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.btnReplaceNext, 1, 6);
            this.tableLayoutPanel5.Controls.Add(this.cbxPRCaseSensitive, 0, 5);
            this.tableLayoutPanel5.Controls.Add(this.btnPRReplaceAll, 0, 6);
            this.tableLayoutPanel5.Controls.Add(this.cbxPRUseRegexp, 0, 4);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 7;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.Size = new System.Drawing.Size(286, 226);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 29);
            this.label4.TabIndex = 0;
            this.label4.Text = "Find What";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbxPRFindWhat
            // 
            this.tbxPRFindWhat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxPRFindWhat.Location = new System.Drawing.Point(100, 3);
            this.tbxPRFindWhat.Name = "tbxPRFindWhat";
            this.tbxPRFindWhat.Size = new System.Drawing.Size(183, 23);
            this.tbxPRFindWhat.TabIndex = 1;
            // 
            // tbxPRReplaceWith
            // 
            this.tbxPRReplaceWith.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxPRReplaceWith.Location = new System.Drawing.Point(100, 32);
            this.tbxPRReplaceWith.Name = "tbxPRReplaceWith";
            this.tbxPRReplaceWith.Size = new System.Drawing.Size(183, 23);
            this.tbxPRReplaceWith.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 29);
            this.label5.TabIndex = 3;
            this.label5.Text = "Replace With";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(3, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 29);
            this.label6.TabIndex = 4;
            this.label6.Text = "Replacement";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nuPRReplacementNumber
            // 
            this.nuPRReplacementNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nuPRReplacementNumber.Enabled = false;
            this.nuPRReplacementNumber.Location = new System.Drawing.Point(100, 86);
            this.nuPRReplacementNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nuPRReplacementNumber.Name = "nuPRReplacementNumber";
            this.nuPRReplacementNumber.Size = new System.Drawing.Size(183, 23);
            this.nuPRReplacementNumber.TabIndex = 5;
            this.nuPRReplacementNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbPRReplacementNumber
            // 
            this.cbPRReplacementNumber.AutoSize = true;
            this.tableLayoutPanel5.SetColumnSpan(this.cbPRReplacementNumber, 2);
            this.cbPRReplacementNumber.Location = new System.Drawing.Point(3, 61);
            this.cbPRReplacementNumber.Name = "cbPRReplacementNumber";
            this.cbPRReplacementNumber.Size = new System.Drawing.Size(142, 19);
            this.cbPRReplacementNumber.TabIndex = 9;
            this.cbPRReplacementNumber.Text = "Replacement Number";
            this.cbPRReplacementNumber.UseVisualStyleBackColor = true;
            this.cbPRReplacementNumber.CheckedChanged += new System.EventHandler(this.cbPRReplacementNumber_CheckedChanged);
            // 
            // btnReplaceNext
            // 
            this.btnReplaceNext.Location = new System.Drawing.Point(100, 165);
            this.btnReplaceNext.Name = "btnReplaceNext";
            this.btnReplaceNext.Size = new System.Drawing.Size(91, 23);
            this.btnReplaceNext.TabIndex = 7;
            this.btnReplaceNext.Text = "Replace Next";
            this.btnReplaceNext.UseVisualStyleBackColor = true;
            this.btnReplaceNext.Click += new System.EventHandler(this.btnReplaceNext_Click);
            // 
            // cbxPRCaseSensitive
            // 
            this.cbxPRCaseSensitive.AutoSize = true;
            this.tableLayoutPanel5.SetColumnSpan(this.cbxPRCaseSensitive, 2);
            this.cbxPRCaseSensitive.Location = new System.Drawing.Point(3, 140);
            this.cbxPRCaseSensitive.Name = "cbxPRCaseSensitive";
            this.cbxPRCaseSensitive.Size = new System.Drawing.Size(100, 19);
            this.cbxPRCaseSensitive.TabIndex = 10;
            this.cbxPRCaseSensitive.Text = "Case Sensitive";
            this.cbxPRCaseSensitive.UseVisualStyleBackColor = true;
            // 
            // btnPRReplaceAll
            // 
            this.btnPRReplaceAll.Location = new System.Drawing.Point(3, 165);
            this.btnPRReplaceAll.Name = "btnPRReplaceAll";
            this.btnPRReplaceAll.Size = new System.Drawing.Size(91, 23);
            this.btnPRReplaceAll.TabIndex = 6;
            this.btnPRReplaceAll.Text = "Replace All";
            this.btnPRReplaceAll.UseVisualStyleBackColor = true;
            this.btnPRReplaceAll.Click += new System.EventHandler(this.btnPRReplaceAll_Click);
            // 
            // cbxPRUseRegexp
            // 
            this.cbxPRUseRegexp.AutoSize = true;
            this.tableLayoutPanel5.SetColumnSpan(this.cbxPRUseRegexp, 2);
            this.cbxPRUseRegexp.Location = new System.Drawing.Point(3, 115);
            this.cbxPRUseRegexp.Name = "cbxPRUseRegexp";
            this.cbxPRUseRegexp.Size = new System.Drawing.Size(90, 19);
            this.cbxPRUseRegexp.TabIndex = 11;
            this.cbxPRUseRegexp.Text = "Use Regexp ";
            this.cbxPRUseRegexp.UseVisualStyleBackColor = true;
            // 
            // pageSplit
            // 
            this.pageSplit.Controls.Add(this.tableLayoutPanel6);
            this.pageSplit.Location = new System.Drawing.Point(4, 24);
            this.pageSplit.Name = "pageSplit";
            this.pageSplit.Padding = new System.Windows.Forms.Padding(3);
            this.pageSplit.Size = new System.Drawing.Size(292, 232);
            this.pageSplit.TabIndex = 1;
            this.pageSplit.Text = "Split";
            this.pageSplit.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel6.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.tbxPSSeparator, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.tbxPSResultStart, 1, 1);
            this.tableLayoutPanel6.Controls.Add(this.tbxPSResultSeparator, 1, 2);
            this.tableLayoutPanel6.Controls.Add(this.tbxPSResultEnd, 1, 3);
            this.tableLayoutPanel6.Controls.Add(this.label8, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.label9, 0, 2);
            this.tableLayoutPanel6.Controls.Add(this.label10, 0, 3);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 5;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel6.Size = new System.Drawing.Size(286, 226);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 29);
            this.label7.TabIndex = 0;
            this.label7.Text = "Separator";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbxPSSeparator
            // 
            this.tbxPSSeparator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxPSSeparator.Location = new System.Drawing.Point(101, 3);
            this.tbxPSSeparator.Name = "tbxPSSeparator";
            this.tbxPSSeparator.Size = new System.Drawing.Size(182, 23);
            this.tbxPSSeparator.TabIndex = 1;
            this.tbxPSSeparator.Text = ",";
            // 
            // tbxPSResultStart
            // 
            this.tbxPSResultStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxPSResultStart.Location = new System.Drawing.Point(101, 32);
            this.tbxPSResultStart.Name = "tbxPSResultStart";
            this.tbxPSResultStart.Size = new System.Drawing.Size(182, 23);
            this.tbxPSResultStart.TabIndex = 2;
            // 
            // tbxPSResultSeparator
            // 
            this.tbxPSResultSeparator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxPSResultSeparator.Location = new System.Drawing.Point(101, 61);
            this.tbxPSResultSeparator.Name = "tbxPSResultSeparator";
            this.tbxPSResultSeparator.Size = new System.Drawing.Size(182, 23);
            this.tbxPSResultSeparator.TabIndex = 3;
            this.tbxPSResultSeparator.Text = "\\n";
            // 
            // tbxPSResultEnd
            // 
            this.tbxPSResultEnd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxPSResultEnd.Location = new System.Drawing.Point(101, 90);
            this.tbxPSResultEnd.Name = "tbxPSResultEnd";
            this.tbxPSResultEnd.Size = new System.Drawing.Size(182, 23);
            this.tbxPSResultEnd.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Location = new System.Drawing.Point(3, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 29);
            this.label8.TabIndex = 5;
            this.label8.Text = "Result Start";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Location = new System.Drawing.Point(3, 58);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 29);
            this.label9.TabIndex = 6;
            this.label9.Text = "Result Separator";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Location = new System.Drawing.Point(3, 87);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 29);
            this.label10.TabIndex = 7;
            this.label10.Text = "Result End";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.Controls.Add(this.tbxOutput, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnOutputToInput, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnOutputClear, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnOutputCopy, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.950617F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.04939F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(195, 324);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // tbxOutput
            // 
            this.tableLayoutPanel3.SetColumnSpan(this.tbxOutput, 4);
            this.tbxOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxOutput.Location = new System.Drawing.Point(3, 31);
            this.tbxOutput.Multiline = true;
            this.tbxOutput.Name = "tbxOutput";
            this.tbxOutput.Size = new System.Drawing.Size(189, 290);
            this.tbxOutput.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Output";
            // 
            // btnOutputToInput
            // 
            this.btnOutputToInput.AutoSize = true;
            this.btnOutputToInput.Location = new System.Drawing.Point(164, 3);
            this.btnOutputToInput.Name = "btnOutputToInput";
            this.btnOutputToInput.Size = new System.Drawing.Size(28, 22);
            this.btnOutputToInput.TabIndex = 3;
            this.btnOutputToInput.Text = "<";
            this.toolTip1.SetToolTip(this.btnOutputToInput, "Move To Input");
            this.btnOutputToInput.UseVisualStyleBackColor = true;
            this.btnOutputToInput.Click += new System.EventHandler(this.btnOutputToInput_Click);
            // 
            // btnOutputClear
            // 
            this.btnOutputClear.AutoSize = true;
            this.btnOutputClear.Location = new System.Drawing.Point(133, 3);
            this.btnOutputClear.Name = "btnOutputClear";
            this.btnOutputClear.Size = new System.Drawing.Size(25, 22);
            this.btnOutputClear.TabIndex = 4;
            this.btnOutputClear.Text = "C";
            this.toolTip1.SetToolTip(this.btnOutputClear, "Clear");
            this.btnOutputClear.UseVisualStyleBackColor = true;
            this.btnOutputClear.Click += new System.EventHandler(this.btnOutpotClear_Click);
            // 
            // btnOutputCopy
            // 
            this.btnOutputCopy.Location = new System.Drawing.Point(83, 3);
            this.btnOutputCopy.Name = "btnOutputCopy";
            this.btnOutputCopy.Size = new System.Drawing.Size(44, 22);
            this.btnOutputCopy.TabIndex = 5;
            this.btnOutputCopy.Text = "Copy";
            this.btnOutputCopy.UseVisualStyleBackColor = true;
            this.btnOutputCopy.Click += new System.EventHandler(this.btnOutputCopy_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.splitContainer1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.21495F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.78505F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(710, 449);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // pageAddPrefixSuffix
            // 
            this.pageAddPrefixSuffix.Controls.Add(this.tableLayoutPanel7);
            this.pageAddPrefixSuffix.Location = new System.Drawing.Point(4, 24);
            this.pageAddPrefixSuffix.Name = "pageAddPrefixSuffix";
            this.pageAddPrefixSuffix.Size = new System.Drawing.Size(292, 232);
            this.pageAddPrefixSuffix.TabIndex = 3;
            this.pageAddPrefixSuffix.Text = "AddPrefixSuffix";
            this.pageAddPrefixSuffix.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel7.Controls.Add(this.label11, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.tbxAPSPrefix, 1, 0);
            this.tableLayoutPanel7.Controls.Add(this.tbxAPSSuffix, 1, 1);
            this.tableLayoutPanel7.Controls.Add(this.label12, 0, 1);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 5;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel7.Size = new System.Drawing.Size(292, 232);
            this.tableLayoutPanel7.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Location = new System.Drawing.Point(3, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 29);
            this.label11.TabIndex = 0;
            this.label11.Text = "Prefix";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbxAPSPrefix
            // 
            this.tbxAPSPrefix.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxAPSPrefix.Location = new System.Drawing.Point(46, 3);
            this.tbxAPSPrefix.Name = "tbxAPSPrefix";
            this.tbxAPSPrefix.Size = new System.Drawing.Size(243, 23);
            this.tbxAPSPrefix.TabIndex = 1;
            // 
            // tbxAPSSuffix
            // 
            this.tbxAPSSuffix.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxAPSSuffix.Location = new System.Drawing.Point(46, 32);
            this.tbxAPSSuffix.Name = "tbxAPSSuffix";
            this.tbxAPSSuffix.Size = new System.Drawing.Size(243, 23);
            this.tbxAPSSuffix.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Location = new System.Drawing.Point(3, 29);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 29);
            this.label12.TabIndex = 5;
            this.label12.Text = "Suffix";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 449);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainForm";
            this.Text = "Text Tools";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.pageReplace.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuPRReplacementNumber)).EndInit();
            this.pageSplit.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pageAddPrefixSuffix.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer splitContainer1;
        private TableLayoutPanel tableLayoutPanel2;
        private TextBox tbxInput;
        private Label label1;
        private SplitContainer splitContainer2;
        private TableLayoutPanel tableLayoutPanel4;
        private ComboBox cbOperation;
        private Button btnStart;
        private CheckBox cbAuto;
        private TableLayoutPanel tableLayoutPanel3;
        private TextBox tbxOutput;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label3;
        private Button btnInputeToOutput;
        private Button btnInputClear;
        private Button btnOutputToInput;
        private Button btnOutputClear;
        private Button btnInputCopy;
        private Button btnOutputCopy;
        private ToolTip toolTip1;
        private TabControl tabControl1;
        private TabPage pageReplace;
        private TabPage pageSplit;
        private TableLayoutPanel tableLayoutPanel5;
        private Label label4;
        private TextBox tbxPRFindWhat;
        private TextBox tbxPRReplaceWith;
        private Label label5;
        private Label label6;
        private NumericUpDown nuPRReplacementNumber;
        private CheckBox cbPRReplacementNumber;
        private Button btnReplaceNext;
        private CheckBox cbxPRCaseSensitive;
        private Button btnPRReplaceAll;
        private CheckBox cbxPRUseRegexp;
        private TabPage pageBlank;
        private TableLayoutPanel tableLayoutPanel6;
        private Label label7;
        private TextBox tbxPSSeparator;
        private TextBox tbxPSResultStart;
        private TextBox tbxPSResultSeparator;
        private TextBox tbxPSResultEnd;
        private Label label8;
        private Label label9;
        private Label label10;
        private TabPage pageAddPrefixSuffix;
        private TableLayoutPanel tableLayoutPanel7;
        private Label label11;
        private TextBox tbxAPSPrefix;
        private TextBox tbxAPSSuffix;
        private Label label12;
    }
}