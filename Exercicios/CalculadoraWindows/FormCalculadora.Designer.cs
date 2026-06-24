namespace CalculadoraWindows
{
    partial class FormCalculadora
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
            modulusButton = new Button();
            clearEntryButton = new Button();
            clearAllButton = new Button();
            backspaceButton = new Button();
            divideButton = new Button();
            button6 = new Button();
            squareButton = new Button();
            button8 = new Button();
            multiplyButton = new Button();
            numberNineButton = new Button();
            numberEightButton = new Button();
            numberSevenButton = new Button();
            subtractButton = new Button();
            numberSixButton = new Button();
            numberFiveButton = new Button();
            numberFourButton = new Button();
            addButton = new Button();
            numberThreeButton = new Button();
            numberTwoButton = new Button();
            numberOneButton = new Button();
            equalsButton = new Button();
            commaButton = new Button();
            numberZeroButton = new Button();
            moreOrLessButton = new Button();
            buttonsLayoutPanel = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            entryBox = new TextBox();
            expressionBox = new TextBox();
            buttonsLayoutPanel.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // modulusButton
            // 
            modulusButton.BackColor = Color.FromArgb(224, 224, 224);
            modulusButton.Dock = DockStyle.Fill;
            modulusButton.Enabled = false;
            modulusButton.Font = new Font("Segoe UI", 15.75F);
            modulusButton.Location = new Point(3, 190);
            modulusButton.Name = "modulusButton";
            modulusButton.Size = new Size(83, 63);
            modulusButton.TabIndex = 1;
            modulusButton.Text = "%";
            modulusButton.UseVisualStyleBackColor = false;
            modulusButton.Click += modulusButton_Click;
            // 
            // clearEntryButton
            // 
            clearEntryButton.BackColor = Color.FromArgb(224, 224, 224);
            clearEntryButton.Dock = DockStyle.Fill;
            clearEntryButton.Font = new Font("Segoe UI", 15.75F);
            clearEntryButton.Location = new Point(92, 190);
            clearEntryButton.Name = "clearEntryButton";
            clearEntryButton.Size = new Size(83, 63);
            clearEntryButton.TabIndex = 2;
            clearEntryButton.Text = "CE";
            clearEntryButton.UseVisualStyleBackColor = false;
            clearEntryButton.Click += clearEntryButton_Click;
            // 
            // clearAllButton
            // 
            clearAllButton.BackColor = Color.FromArgb(224, 224, 224);
            clearAllButton.Dock = DockStyle.Fill;
            clearAllButton.Font = new Font("Segoe UI", 15.75F);
            clearAllButton.Location = new Point(181, 190);
            clearAllButton.Name = "clearAllButton";
            clearAllButton.Size = new Size(83, 63);
            clearAllButton.TabIndex = 3;
            clearAllButton.Text = "C";
            clearAllButton.UseVisualStyleBackColor = false;
            clearAllButton.Click += clearAllButton_Click;
            // 
            // backspaceButton
            // 
            backspaceButton.BackColor = Color.FromArgb(224, 224, 224);
            backspaceButton.Dock = DockStyle.Fill;
            backspaceButton.Font = new Font("Segoe UI", 15.75F);
            backspaceButton.Location = new Point(270, 190);
            backspaceButton.Name = "backspaceButton";
            backspaceButton.Size = new Size(84, 63);
            backspaceButton.TabIndex = 4;
            backspaceButton.Text = "⌫";
            backspaceButton.UseVisualStyleBackColor = false;
            backspaceButton.Click += backspaceButton_Click;
            // 
            // divideButton
            // 
            divideButton.BackColor = Color.FromArgb(224, 224, 224);
            divideButton.Dock = DockStyle.Fill;
            divideButton.Font = new Font("Segoe UI", 15.75F);
            divideButton.Location = new Point(270, 259);
            divideButton.Name = "divideButton";
            divideButton.Size = new Size(84, 63);
            divideButton.TabIndex = 8;
            divideButton.Text = "÷";
            divideButton.UseVisualStyleBackColor = false;
            divideButton.Click += divideButton_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(224, 224, 224);
            button6.Dock = DockStyle.Fill;
            button6.Enabled = false;
            button6.Font = new Font("Segoe UI", 15.75F);
            button6.Location = new Point(181, 259);
            button6.Name = "button6";
            button6.Size = new Size(83, 63);
            button6.TabIndex = 7;
            button6.Text = "²√x";
            button6.UseVisualStyleBackColor = false;
            // 
            // squareButton
            // 
            squareButton.BackColor = Color.FromArgb(224, 224, 224);
            squareButton.Dock = DockStyle.Fill;
            squareButton.Font = new Font("Segoe UI", 15.75F);
            squareButton.Location = new Point(92, 259);
            squareButton.Name = "squareButton";
            squareButton.Size = new Size(83, 63);
            squareButton.TabIndex = 6;
            squareButton.Text = "x²";
            squareButton.UseVisualStyleBackColor = false;
            squareButton.Click += squareButton_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.FromArgb(224, 224, 224);
            button8.Dock = DockStyle.Fill;
            button8.Enabled = false;
            button8.Font = new Font("Segoe UI", 15.75F);
            button8.Location = new Point(3, 259);
            button8.Name = "button8";
            button8.Size = new Size(83, 63);
            button8.TabIndex = 5;
            button8.Text = "¹/x";
            button8.UseVisualStyleBackColor = false;
            // 
            // multiplyButton
            // 
            multiplyButton.BackColor = Color.FromArgb(224, 224, 224);
            multiplyButton.Dock = DockStyle.Fill;
            multiplyButton.Font = new Font("Segoe UI", 15.75F);
            multiplyButton.Location = new Point(270, 328);
            multiplyButton.Name = "multiplyButton";
            multiplyButton.Size = new Size(84, 63);
            multiplyButton.TabIndex = 12;
            multiplyButton.Text = "x";
            multiplyButton.UseVisualStyleBackColor = false;
            multiplyButton.Click += multiplyButton_Click;
            // 
            // numberNineButton
            // 
            numberNineButton.BackColor = SystemColors.ButtonFace;
            numberNineButton.Dock = DockStyle.Fill;
            numberNineButton.Font = new Font("Segoe UI", 15.75F);
            numberNineButton.Location = new Point(181, 328);
            numberNineButton.Name = "numberNineButton";
            numberNineButton.Size = new Size(83, 63);
            numberNineButton.TabIndex = 11;
            numberNineButton.Text = "9";
            numberNineButton.UseVisualStyleBackColor = false;
            numberNineButton.Click += numberNineButton_Click;
            // 
            // numberEightButton
            // 
            numberEightButton.BackColor = SystemColors.ButtonFace;
            numberEightButton.Dock = DockStyle.Fill;
            numberEightButton.Font = new Font("Segoe UI", 15.75F);
            numberEightButton.Location = new Point(92, 328);
            numberEightButton.Name = "numberEightButton";
            numberEightButton.Size = new Size(83, 63);
            numberEightButton.TabIndex = 10;
            numberEightButton.Text = "8";
            numberEightButton.UseVisualStyleBackColor = false;
            numberEightButton.Click += numberEightButton_Click;
            // 
            // numberSevenButton
            // 
            numberSevenButton.BackColor = SystemColors.ButtonFace;
            numberSevenButton.Dock = DockStyle.Fill;
            numberSevenButton.Font = new Font("Segoe UI", 15.75F);
            numberSevenButton.Location = new Point(3, 328);
            numberSevenButton.Name = "numberSevenButton";
            numberSevenButton.Size = new Size(83, 63);
            numberSevenButton.TabIndex = 9;
            numberSevenButton.Text = "7";
            numberSevenButton.UseVisualStyleBackColor = false;
            numberSevenButton.Click += numberSevenButton_Click;
            // 
            // subtractButton
            // 
            subtractButton.BackColor = Color.FromArgb(224, 224, 224);
            subtractButton.Dock = DockStyle.Fill;
            subtractButton.Font = new Font("Segoe UI", 15.75F);
            subtractButton.Location = new Point(270, 397);
            subtractButton.Name = "subtractButton";
            subtractButton.Size = new Size(84, 63);
            subtractButton.TabIndex = 16;
            subtractButton.Text = "-";
            subtractButton.UseVisualStyleBackColor = false;
            subtractButton.Click += subtractButton_Click;
            // 
            // numberSixButton
            // 
            numberSixButton.BackColor = SystemColors.Control;
            numberSixButton.Dock = DockStyle.Fill;
            numberSixButton.Font = new Font("Segoe UI", 15.75F);
            numberSixButton.Location = new Point(181, 397);
            numberSixButton.Name = "numberSixButton";
            numberSixButton.Size = new Size(83, 63);
            numberSixButton.TabIndex = 15;
            numberSixButton.Text = "6";
            numberSixButton.UseVisualStyleBackColor = false;
            numberSixButton.Click += numberSixButton_Click;
            // 
            // numberFiveButton
            // 
            numberFiveButton.BackColor = SystemColors.ButtonFace;
            numberFiveButton.Dock = DockStyle.Fill;
            numberFiveButton.Font = new Font("Segoe UI", 15.75F);
            numberFiveButton.Location = new Point(92, 397);
            numberFiveButton.Name = "numberFiveButton";
            numberFiveButton.Size = new Size(83, 63);
            numberFiveButton.TabIndex = 14;
            numberFiveButton.Text = "5";
            numberFiveButton.UseVisualStyleBackColor = false;
            numberFiveButton.Click += numberFiveButton_Click;
            // 
            // numberFourButton
            // 
            numberFourButton.BackColor = SystemColors.ButtonFace;
            numberFourButton.Dock = DockStyle.Fill;
            numberFourButton.Font = new Font("Segoe UI", 15.75F);
            numberFourButton.Location = new Point(3, 397);
            numberFourButton.Name = "numberFourButton";
            numberFourButton.Size = new Size(83, 63);
            numberFourButton.TabIndex = 13;
            numberFourButton.Text = "4";
            numberFourButton.UseVisualStyleBackColor = false;
            numberFourButton.Click += numberFourButton_Click;
            // 
            // addButton
            // 
            addButton.BackColor = Color.FromArgb(224, 224, 224);
            addButton.Dock = DockStyle.Fill;
            addButton.Font = new Font("Segoe UI", 15.75F);
            addButton.Location = new Point(270, 466);
            addButton.Name = "addButton";
            addButton.Size = new Size(84, 63);
            addButton.TabIndex = 20;
            addButton.Text = "+";
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += addButton_Click;
            // 
            // numberThreeButton
            // 
            numberThreeButton.BackColor = SystemColors.ButtonFace;
            numberThreeButton.Dock = DockStyle.Fill;
            numberThreeButton.Font = new Font("Segoe UI", 15.75F);
            numberThreeButton.Location = new Point(181, 466);
            numberThreeButton.Name = "numberThreeButton";
            numberThreeButton.Size = new Size(83, 63);
            numberThreeButton.TabIndex = 19;
            numberThreeButton.Text = "3";
            numberThreeButton.UseVisualStyleBackColor = false;
            numberThreeButton.Click += numberThreeButton_Click;
            // 
            // numberTwoButton
            // 
            numberTwoButton.BackColor = SystemColors.ButtonFace;
            numberTwoButton.Dock = DockStyle.Fill;
            numberTwoButton.Font = new Font("Segoe UI", 15.75F);
            numberTwoButton.Location = new Point(92, 466);
            numberTwoButton.Name = "numberTwoButton";
            numberTwoButton.Size = new Size(83, 63);
            numberTwoButton.TabIndex = 18;
            numberTwoButton.Text = "2";
            numberTwoButton.UseVisualStyleBackColor = false;
            numberTwoButton.Click += numberTwoButton_Click;
            // 
            // numberOneButton
            // 
            numberOneButton.BackColor = SystemColors.ButtonFace;
            numberOneButton.Dock = DockStyle.Fill;
            numberOneButton.Font = new Font("Segoe UI", 15.75F);
            numberOneButton.Location = new Point(3, 466);
            numberOneButton.Name = "numberOneButton";
            numberOneButton.Size = new Size(83, 63);
            numberOneButton.TabIndex = 17;
            numberOneButton.Text = "1";
            numberOneButton.UseVisualStyleBackColor = false;
            numberOneButton.Click += numberOneButton_Click;
            // 
            // equalsButton
            // 
            equalsButton.BackColor = Color.DeepSkyBlue;
            equalsButton.Dock = DockStyle.Fill;
            equalsButton.Font = new Font("Segoe UI", 15.75F);
            equalsButton.Location = new Point(270, 535);
            equalsButton.Name = "equalsButton";
            equalsButton.Size = new Size(84, 66);
            equalsButton.TabIndex = 24;
            equalsButton.Text = "=";
            equalsButton.UseVisualStyleBackColor = false;
            equalsButton.Click += equalsButton_Click;
            // 
            // commaButton
            // 
            commaButton.BackColor = SystemColors.ButtonFace;
            commaButton.Dock = DockStyle.Fill;
            commaButton.Font = new Font("Segoe UI", 15.75F);
            commaButton.Location = new Point(181, 535);
            commaButton.Name = "commaButton";
            commaButton.Size = new Size(83, 66);
            commaButton.TabIndex = 23;
            commaButton.Text = ",";
            commaButton.UseVisualStyleBackColor = false;
            commaButton.Click += commaButton_Click;
            // 
            // numberZeroButton
            // 
            numberZeroButton.BackColor = SystemColors.ButtonFace;
            numberZeroButton.Dock = DockStyle.Fill;
            numberZeroButton.Font = new Font("Segoe UI", 15.75F);
            numberZeroButton.Location = new Point(92, 535);
            numberZeroButton.Name = "numberZeroButton";
            numberZeroButton.Size = new Size(83, 66);
            numberZeroButton.TabIndex = 22;
            numberZeroButton.Text = "0";
            numberZeroButton.UseVisualStyleBackColor = false;
            numberZeroButton.Click += zeroButton_Click;
            // 
            // moreOrLessButton
            // 
            moreOrLessButton.BackColor = SystemColors.ButtonFace;
            moreOrLessButton.Dock = DockStyle.Fill;
            moreOrLessButton.Enabled = false;
            moreOrLessButton.Font = new Font("Segoe UI", 15.75F);
            moreOrLessButton.Location = new Point(3, 535);
            moreOrLessButton.Name = "moreOrLessButton";
            moreOrLessButton.Size = new Size(83, 66);
            moreOrLessButton.TabIndex = 21;
            moreOrLessButton.Text = "+/-";
            moreOrLessButton.UseVisualStyleBackColor = false;
            moreOrLessButton.Click += moreOrLessButton_Click;
            // 
            // buttonsLayoutPanel
            // 
            buttonsLayoutPanel.ColumnCount = 4;
            buttonsLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            buttonsLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            buttonsLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            buttonsLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            buttonsLayoutPanel.Controls.Add(moreOrLessButton, 0, 6);
            buttonsLayoutPanel.Controls.Add(clearAllButton, 2, 1);
            buttonsLayoutPanel.Controls.Add(backspaceButton, 3, 1);
            buttonsLayoutPanel.Controls.Add(divideButton, 3, 2);
            buttonsLayoutPanel.Controls.Add(numberZeroButton, 1, 6);
            buttonsLayoutPanel.Controls.Add(clearEntryButton, 1, 1);
            buttonsLayoutPanel.Controls.Add(button6, 2, 2);
            buttonsLayoutPanel.Controls.Add(modulusButton, 0, 1);
            buttonsLayoutPanel.Controls.Add(commaButton, 2, 6);
            buttonsLayoutPanel.Controls.Add(squareButton, 1, 2);
            buttonsLayoutPanel.Controls.Add(equalsButton, 3, 6);
            buttonsLayoutPanel.Controls.Add(button8, 0, 2);
            buttonsLayoutPanel.Controls.Add(addButton, 3, 5);
            buttonsLayoutPanel.Controls.Add(numberThreeButton, 2, 5);
            buttonsLayoutPanel.Controls.Add(numberTwoButton, 1, 5);
            buttonsLayoutPanel.Controls.Add(numberOneButton, 0, 5);
            buttonsLayoutPanel.Controls.Add(subtractButton, 3, 4);
            buttonsLayoutPanel.Controls.Add(multiplyButton, 3, 3);
            buttonsLayoutPanel.Controls.Add(numberSixButton, 2, 4);
            buttonsLayoutPanel.Controls.Add(numberNineButton, 2, 3);
            buttonsLayoutPanel.Controls.Add(numberFiveButton, 1, 4);
            buttonsLayoutPanel.Controls.Add(numberEightButton, 1, 3);
            buttonsLayoutPanel.Controls.Add(numberFourButton, 0, 4);
            buttonsLayoutPanel.Controls.Add(numberSevenButton, 0, 3);
            buttonsLayoutPanel.Controls.Add(tableLayoutPanel2, 0, 0);
            buttonsLayoutPanel.Dock = DockStyle.Fill;
            buttonsLayoutPanel.Location = new Point(0, 0);
            buttonsLayoutPanel.Margin = new Padding(3, 4, 3, 4);
            buttonsLayoutPanel.Name = "buttonsLayoutPanel";
            buttonsLayoutPanel.RowCount = 7;
            buttonsLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 31F));
            buttonsLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 11.5F));
            buttonsLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 11.5F));
            buttonsLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 11.5F));
            buttonsLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 11.5F));
            buttonsLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 11.5F));
            buttonsLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 11.5F));
            buttonsLayoutPanel.Size = new Size(357, 604);
            buttonsLayoutPanel.TabIndex = 25;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = SystemColors.ControlLight;
            tableLayoutPanel2.ColumnCount = 1;
            buttonsLayoutPanel.SetColumnSpan(tableLayoutPanel2, 4);
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(entryBox, 0, 1);
            tableLayoutPanel2.Controls.Add(expressionBox, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 4);
            tableLayoutPanel2.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 45.108696F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 54.891304F));
            tableLayoutPanel2.Size = new Size(351, 179);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // entryBox
            // 
            entryBox.BackColor = SystemColors.ControlLight;
            entryBox.BorderStyle = BorderStyle.None;
            entryBox.Dock = DockStyle.Bottom;
            entryBox.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            entryBox.Location = new Point(3, 96);
            entryBox.Name = "entryBox";
            entryBox.ReadOnly = true;
            entryBox.Size = new Size(345, 80);
            entryBox.TabIndex = 1;
            entryBox.TabStop = false;
            entryBox.TextAlign = HorizontalAlignment.Right;
            // 
            // expressionBox
            // 
            expressionBox.BackColor = SystemColors.ControlLight;
            expressionBox.BorderStyle = BorderStyle.None;
            expressionBox.Dock = DockStyle.Bottom;
            expressionBox.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            expressionBox.ForeColor = Color.FromArgb(64, 64, 64);
            expressionBox.Location = new Point(3, 28);
            expressionBox.Name = "expressionBox";
            expressionBox.ReadOnly = true;
            expressionBox.Size = new Size(345, 49);
            expressionBox.TabIndex = 0;
            expressionBox.TabStop = false;
            expressionBox.TextAlign = HorizontalAlignment.Right;
            // 
            // FormCalculadora
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(357, 604);
            Controls.Add(buttonsLayoutPanel);
            MinimumSize = new Size(375, 651);
            Name = "FormCalculadora";
            Text = "Calculadora";
            Load += FormCalculadora_Load;
            KeyDown += FormCalculadora_KeyDown;
            KeyPress += FormCalculadora_KeyPress;
            buttonsLayoutPanel.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button modulusButton;
        private Button clearEntryButton;
        private Button clearAllButton;
        private Button backspaceButton;
        private Button divideButton;
        private Button button6;
        private Button squareButton;
        private Button button8;
        private Button multiplyButton;
        private Button numberNineButton;
        private Button numberEightButton;
        private Button numberSevenButton;
        private Button subtractButton;
        private Button numberSixButton;
        private Button numberFiveButton;
        private Button numberFourButton;
        private Button addButton;
        private Button numberThreeButton;
        private Button numberTwoButton;
        private Button numberOneButton;
        private Button equalsButton;
        private Button commaButton;
        private Button numberZeroButton;
        private Button moreOrLessButton;
        private TableLayoutPanel buttonsLayoutPanel;
        private TextBox entryBox;
        private TextBox expressionBox;
        private TableLayoutPanel tableLayoutPanel2;
    }
}
