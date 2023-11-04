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
            this.tbxInpute = new System.Windows.Forms.TextBox();
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
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tbxOutput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOutputToInput = new System.Windows.Forms.Button();
            this.btnOutputClear = new System.Windows.Forms.Button();
            this.btnOutputCopy = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
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
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
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
            this.tableLayoutPanel2.Controls.Add(this.tbxInpute, 0, 1);
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
            // tbxInpute
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.tbxInpute, 4);
            this.tbxInpute.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxInpute.Location = new System.Drawing.Point(3, 31);
            this.tbxInpute.Multiline = true;
            this.tbxInpute.Name = "tbxInpute";
            this.tbxInpute.Size = new System.Drawing.Size(189, 290);
            this.tbxInpute.TabIndex = 1;
            this.tbxInpute.TextChanged += new System.EventHandler(this.tbxInpute_TextChanged);
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
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer splitContainer1;
        private TableLayoutPanel tableLayoutPanel2;
        private TextBox tbxInpute;
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
    }
}